namespace GraphAlgorithms.Graph
{
    public class Edge
    {
        public NodeWithEdges To { get; init; }

        public Edge(NodeWithEdges to)
        {
            To = to;
        }
    }
}
