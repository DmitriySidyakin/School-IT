using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph
{
    public class NodeWithWeightedEdges
    {
        /// <summary>
        /// Идентификатор (индекс) узла в графе
        /// </summary>
        public long Id { get; init; }

        /// <summary>
        /// Шаг пакетизации рёбер графа по умолчанию
        /// </summary>
        public static long EdgeDefaultStep { get; } = 5;

        /// <summary>
        /// Применяемый шаг пакетизации рёбер графа
        /// </summary>
        public long EdgeStep { get; set; }

        /// <summary>
        /// Индекс последней добавленной грани в поле/массив Edges
        /// </summary>
        internal long LastEdgeIndex { get; set; } = -1;

        /// <summary>
        /// Массив рёбер
        /// </summary>
        internal WeightedEdge[] WeightedEdges { get; set; }

        /// <summary>
        /// Количество граней
        /// </summary>
        public long EdgeCount { get { return LastEdgeIndex + 1; } }

        /// <summary>
        /// Основной конструктор создания узла
        /// </summary>
        /// <param name="id">Индекс элемента узла в графе</param>
        public NodeWithWeightedEdges(long id) { 

            Id = id;
            EdgeStep = EdgeDefaultStep;
            WeightedEdges = new WeightedEdge[EdgeStep];
        }

        /// <summary>
        /// Конструктор создания узла с определённым идентификатором (индексом) и шагом пакетизации граней
        /// </summary>
        /// <param name="id">Идентификатор (индекс) узла</param>
        /// <param name="edgeStep">Шаг создания граней для узла</param>
        public NodeWithWeightedEdges(long id, long edgeStep)
        {

            Id = id;
            EdgeStep = edgeStep;
            WeightedEdges = new WeightedEdge[EdgeStep];
        }

        /// <summary>
        /// Метод добывляет грань к текущему узлу
        /// </summary>
        /// <param name="to">Узел в напралении которого направлена связь.</param>
        /// <returns>Возвращает добавленную грань.</returns>
        internal WeightedEdge AddEdge(NodeWithWeightedEdges to, long weight)
        {
            if ((LastEdgeIndex + 1) == WeightedEdges.LongLength)
            {
                WeightedEdge[] oldEdges = WeightedEdges;
                WeightedEdge[] newEdges = new WeightedEdge[oldEdges.LongLength + EdgeStep];

                for (long i = 0; i < oldEdges.LongLength; i++)
                    newEdges[i] = oldEdges[i];

                WeightedEdges = newEdges;
            }

            LastEdgeIndex++;
            WeightedEdges[LastEdgeIndex] = new WeightedEdge(to, weight);

            return WeightedEdges[LastEdgeIndex];
        }
    }
}
