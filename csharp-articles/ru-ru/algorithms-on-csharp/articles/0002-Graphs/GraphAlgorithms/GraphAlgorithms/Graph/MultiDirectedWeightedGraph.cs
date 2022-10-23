using GraphAlgorithms.Graph.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph
{
    public partial class MultiDirectedWeightedGraph : WeightedGraph
    {
        #region Graph Properties

        /// <summary>
        /// Метод показывает является ли граф сильно связанным.
        /// </summary>
        public bool IsStronglyConnected
        {
            get
            {
                bool result = true;

                bool[][] Explored = ToEdgeArray<bool>(false);

                for (int i = 0; i < Nodes.Length && result; i++)
                {
                    for (int j = 0; j < Nodes.Length && result; j++)
                    {
                        if (i == j)
                            continue;

                        result &= IsStronglyConnectedNodes(Explored, Nodes[i], Nodes[j]);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Метод показывает существует ли маршрут от узла from до узла to. Метод на основе поиска в ширину.
        /// </summary>
        /// <param name="Explored">Уже просмотренные грани</param>
        /// <param name="from">Начальный узел маршрута</param>
        /// <param name="to">Конечный узел маршрута</param>
        /// <returns>true, если маршрут существует, иначе false</returns>
        protected bool IsStronglyConnectedNodes(bool[][] Explored, NodeWithWeightedEdges from, NodeWithWeightedEdges to)
        {
            bool result = false;

            foreach (WeightedEdge edge in from.WeightedEdges)
            {
                if (!Explored[to.Id][from.Id])
                {
                    if (edge.To == to)
                    {
                        return true;
                    }
                    else
                    {
                        Explored[from.Id][to.Id] = true;

                        result |= IsStronglyConnectedNodes(Explored, to, edge.To);
                    }
                }
            }

            return result;
        }

        #endregion

        #region Initializers

        /// <summary>
        /// Метод создаёт связь от узла from до узла to.
        /// </summary>
        /// <param name="from">Начало связи</param>
        /// <param name="to">Конец связи</param>
        /// <returns>Созданная связь</returns>
        public new WeightedEdge AddEdge(NodeWithWeightedEdges from, NodeWithWeightedEdges to, long weight)
        {
            if (_LastNodeIndex < 1)
                throw
                    new TreeException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(to) + " " + nameof(from)));

            if (from.Id > _LastNodeIndex || from.Id < 0)
                throw
                    new GraphException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(from)));

            if (to.Id > _LastNodeIndex || to.Id < 0)
                throw
                    new GraphException("Индекс узла не существует!", new ArgumentOutOfRangeException(nameof(to)));

            return Nodes[from.Id].AddEdge(Nodes[to.Id], weight);
        }

        #endregion
    }
}
