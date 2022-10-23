using GraphAlgorithms.Graph.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph
{
    public partial class MultiDirectedGraph : Graph
    {
        #region Graph Properties

        /// <summary>
        /// Метод показывает является ли граф сильно связанным.
        /// </summary>
        public bool IsStronglyConnected
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Initializers

        /// <summary>
        /// Метод создаёт связь от узла from до узла to.
        /// </summary>
        /// <param name="from">Начало связи</param>
        /// <param name="to">Конец связи</param>
        /// <returns>Созданная связь</returns>
        public new Edge AddEdge(NodeWithEdges from, NodeWithEdges to)
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

            return Nodes[from.Id].AddEdge(Nodes[to.Id]);
        }

        #endregion

    }
}
