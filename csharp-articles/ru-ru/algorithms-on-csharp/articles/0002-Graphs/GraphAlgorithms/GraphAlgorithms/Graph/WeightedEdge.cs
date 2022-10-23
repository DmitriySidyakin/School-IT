using System;
namespace GraphAlgorithms.Graph
{
    public class WeightedEdge
    {
        public NodeWithWeightedEdges To { get; init; }

        public long Weight { get; set; } = long.MaxValue;

        public WeightedEdge(NodeWithWeightedEdges to) { To = to; }

        public WeightedEdge(NodeWithWeightedEdges to, long weight) : this(to) { Weight = weight; }
    }
}
