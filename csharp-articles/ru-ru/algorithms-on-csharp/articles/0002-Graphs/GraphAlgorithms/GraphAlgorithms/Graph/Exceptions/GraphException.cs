namespace GraphAlgorithms.Graph.Exceptions
{

    /// <summary>
    /// Исключение вызванное работой с графами
    /// </summary>
    public class GraphException : Exception
    {
        public GraphException() { }

        public GraphException(string? message) : base(message) { }

        public GraphException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
