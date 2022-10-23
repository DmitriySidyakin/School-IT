using GraphAlgorithms.Graph.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph
{
    public class Tree
    {
        #region Fields

        /// <summary>
        /// Шаг пакетизации в массиве узлов по умолчанию
        /// </summary>
        public static long NodeDefaultStep { get; } = 100;

        /// <summary>
        /// Применяемый шаг пакетизации в массиве узлов
        /// </summary>
        public long NodeStep { get; init; }

        /// <summary>
        /// Применяемый шаг пакетизации рёбер графа
        /// </summary>
        public long EdgeStep { get; init; }

        // Далее идут защищаемые поля

        /// <summary>
        /// Массив узлов
        /// </summary>
        internal NodeWithEdges[] Nodes { get; set; }

        /// <summary>
        /// Индекс последнего добавленного узла в поле/массиве Nodes
        /// </summary>
        protected long LastNodeIndex { get; set; } = -1;

        /// <summary>
        /// Количество узлов
        /// </summary>
        public long NodeCount { get { return LastNodeIndex + 1; } }

        #endregion

        #region Constructors and their methods

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Tree()
        {
            NodeStep = NodeDefaultStep;
            EdgeStep = NodeWithEdges.EdgeDefaultStep;
            Nodes = new NodeWithEdges[NodeStep];
        }

        /// <summary>
        /// Конструктор с заданием шага генерации пакетов сущностей.
        /// </summary>
        /// <param name="nodeStep">Шаг пакетов при наполнении узлов</param>
        /// <param name="edgeStep">Шаг пакетов при наполнении рёбер</param>
        public Tree(long nodeStep, long edgeStep)
        {
            CheckGraphSteps(nodeStep, edgeStep);

            NodeStep = nodeStep;
            EdgeStep = edgeStep;
            Nodes = new NodeWithEdges[NodeStep];
        }

        /// <summary>
        /// Метод валидирует имеет ли пакетный шаг узлов и рёбер значение больше нуля.
        /// </summary>
        /// <param name="nodeStep">Пакетный шаг узлов</param>
        /// <param name="edgeStep">Пакетный шаг рёбер</param>
        /// <exception cref="GraphException">Исключение генерируется, если пакетный шаг узлов или рёбер меньше 1</exception>
        protected static void CheckGraphSteps(long nodeStep, long edgeStep)
        {
            if (nodeStep <= 0)
                throw new GraphException("Пакетный шаг узлов должен быть больше нуля!", new ArgumentOutOfRangeException(nameof(nodeStep)));
            if (edgeStep <= 0)
                throw new GraphException("Пакетный шаг рёбер должен быть больше нуля!", new ArgumentOutOfRangeException(nameof(edgeStep)));
        }

        #endregion

        #region Initializers

        /// <summary>
        /// Метод добавляет новый узел и возвращает его.
        /// </summary>
        /// <returns>Последний добавленный узел</returns>
        public NodeWithEdges AddEmptyNode()
        {

            if ((LastNodeIndex + 1) == Nodes.LongLength)
            {
                NodeWithEdges[] oldNodes = Nodes;
                NodeWithEdges[] newNodes = new NodeWithEdges[oldNodes.LongLength + NodeStep];

                for (long i = 0; i < oldNodes.LongLength; i++)
                    newNodes[i] = oldNodes[i];

                Nodes = newNodes;
            }

            LastNodeIndex++;
            Nodes[LastNodeIndex] = new NodeWithEdges(LastNodeIndex, EdgeStep);

            return Nodes[LastNodeIndex];
        }

        /// <summary>
        /// Метод создаёт связь от узла from до узла to.
        /// </summary>
        /// <param name="from">Начало связи</param>
        /// <param name="to">Конец связи</param>
        /// <returns>Созданная связь</returns>
        public Edge AddEdge(NodeWithEdges from, NodeWithEdges to)
        {
            if(LastNodeIndex < 1)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(to) + " " + nameof(from)));

            if (from.Id > LastNodeIndex || from.Id < 0)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(from)));

            if (to.Id > LastNodeIndex || to.Id < 0)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(to)));

            // Добавить грань на узел на которую никто не направлен.
            if (CheckNewEdge(to))
                return Nodes[from.Id].AddEdge(Nodes[to.Id]);
            else
                throw new TreeException("Дерево становиться циклическим!", new ArgumentOutOfRangeException(nameof(to) + " " + nameof(from)));
        }

        /// <summary>
        /// Метод проверяет существует ли уже связь на узел to.
        /// </summary>
        /// <param name="to">Узел на который направлена связь</param>
        /// <returns>true - если узел существует</returns>
        public bool CheckNewEdge(NodeWithEdges to)
        {
            return !((from n in Nodes
                      where to.Id == n.Id
                      select n).Count() > 0);
        }

        #endregion

        #region Getters

        /// <summary>
        /// Получает узел графа по его индексу.
        /// </summary>
        /// <param name="nodeIndex">Индекс узла</param>
        /// <returns>Узел</returns>
        /// <exception cref="TreeException">Генерируется, если входной индекс не существует в массиве узлов.</exception>
        public NodeWithEdges GetNode(long nodeIndex)
        {
            if (nodeIndex > LastNodeIndex || nodeIndex < 0)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(nodeIndex)));

            return Nodes[nodeIndex];
        }

        /// <summary>
        /// Получает грань определённого узла
        /// </summary>
        /// <param name="nodeIndex">Индекс узла</param>
        /// <param name="edgeIndex">Индекс грани</param>
        /// <returns>Грань с заданными индексами</returns>
        /// <exception cref="GraphException">Генерируется, если входной индекс не существует в массиве узлов или рёбер.</exception>
        public Edge GetEdge(long nodeIndex, long edgeIndex)
        {
            if (nodeIndex > LastNodeIndex || nodeIndex < 0)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(nodeIndex)));

            var node = Nodes[nodeIndex];

            if (edgeIndex > node.LastEdgeIndex || edgeIndex < 0)
                throw
                    new TreeException("Индекс ребра не существует!", new ArgumentOutOfRangeException(nameof(edgeIndex)));

            return node.Edges[edgeIndex];
        }

        #endregion

        #region Graph Properties

        /// <summary>
        /// Свойство показывающее, является ли граф связанным. Возвращает true, если граф связанный, иначе false.
        /// </summary>
        public bool IsConnected
        {
            get
            {
                bool result = true;

                for (var i = 0; i < Nodes.Length && result; i++)
                {
                    // У узла есть связи на другие узлы? Является ли он листом?
                    if (Nodes[i].EdgeCount == 0)
                    {
                        // Если нет, то ...
                        // На узел ссылаются из другого узла?
                        var node = Nodes[i];
                        bool isConnected = (from n in Nodes
                                            from e in n.Edges
                                            where e.To.Id == node.Id
                                            select true).Count() == 0;
                        if (!isConnected)
                            result = false;
                    }
                }

                return result;
            }
        }

        #endregion

        #region Different methods

        public bool hasThisEdge(NodeWithEdges @from, NodeWithEdges to) {
            return (from n in Nodes
                   where n.Id == @from.Id
                   select n).Count() > 0;
        }

        #endregion
    }
}
