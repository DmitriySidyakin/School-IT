using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAlgorithms.Graph;
using GraphAlgorithms.Graph.Exceptions;

namespace GraphAlgorithms.Algorithms
{
    // Алгоритм поиска в ширину в невзвешенном графе. 
    public class G1BreadthFirstSearch
    {
        // Поиск в ширину
        public static GraphAlgorithms.Graph.Graph BreadthFirstSearch(GraphAlgorithms.Graph.Graph graph)
        {
            if (graph is null)
            {
                throw new ArgumentNullException(nameof(graph));
            }

            GraphAlgorithms.Graph.Graph result = new GraphAlgorithms.Graph.Graph();

            return result;
        }
    }
}
