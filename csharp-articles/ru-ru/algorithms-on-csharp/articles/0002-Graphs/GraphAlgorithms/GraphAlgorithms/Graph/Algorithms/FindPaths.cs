using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.Graph
{
    public partial class Graph
    {
        public List<(List<NodeWithEdges>, long)> FindAcyclicPaths(long nodeIdStart, long nodeIdEnd)
        {
            NodeWithEdges startNode = GetNode(nodeIdStart);
            NodeWithEdges endNode = GetNode(nodeIdEnd);

            List<(List<NodeWithEdges>, long)> paths = FindAcyclicPathsRecursively(0, new List<NodeWithEdges>(), startNode, endNode);

            return paths;
        }

        public (List<NodeWithEdges>, long) FindAcyclicShortestPath(long nodeIdStart, long nodeIdEnd)
        {
            List<(List<NodeWithEdges>, long)> paths = FindAcyclicPaths(nodeIdStart, nodeIdEnd);
            //PrintPaths(paths);
            (List<NodeWithEdges>, long) shortestAcyclicPath;
            try
            {
                shortestAcyclicPath = paths.MinBy((i) => i.Item2);
            }
            catch (Exception)
            {
                return (new(), -1);
            }

            return shortestAcyclicPath;
        }

        #region Debug methods

        protected void PrintPaths(List<(List<NodeWithEdges>, long)> paths)
        {
            long i = 0;
            foreach (var (list, weight) in paths)
            {
                Console.Write($"Path {i}, W = {weight}: ");

                foreach (var node in list)
                {
                    Console.Write($"{node.Id}, ");
                }
                Console.WriteLine();
                i++;
            }
        }

        #endregion

        private List<(List<NodeWithEdges>, long)> FindAcyclicPathsRecursively(long startPathWeight, List<NodeWithEdges> currentPath, NodeWithEdges startNode, NodeWithEdges endNode)
        {
            currentPath.Add(startNode);

            List<(List<NodeWithEdges>, long)> acyclicPaths = new List<(List<NodeWithEdges>, long)>();

            long resultWeight = startPathWeight;

            if (startNode.Id != endNode.Id && startNode.EdgeCount > 0)
            {
                for (var i = 0; i < startNode.EdgeCount; i++)
                {
                    var edge = startNode.Edges[i];

                    // Избежание циклических связей
                    if (currentPath.Contains(edge.To))
                    {
                        continue;
                    }

                    acyclicPaths.AddRange(FindAcyclicPathsRecursively(resultWeight + 1 /* или вместо 1 вес ребра */, new List<NodeWithEdges>(currentPath), edge.To, endNode));
                }

                return acyclicPaths;
            }
            else
            {

                if (endNode.Id != startNode.Id)   
                    return acyclicPaths;

                acyclicPaths.Add((currentPath, resultWeight));
                return acyclicPaths;
            }
        }
    }

    public partial class WeightedGraph
    {
        public List<(List<NodeWithWeightedEdges>, long)> FindAcyclicPaths(long nodeIdStart, long nodeIdEnd)
        {
            NodeWithWeightedEdges startNode = GetNode(nodeIdStart);
            NodeWithWeightedEdges endNode = GetNode(nodeIdEnd);
            
            List<(List<NodeWithWeightedEdges>, long)> paths = FindAcyclicPathsRecursively(0, new List<NodeWithWeightedEdges>(), startNode, endNode);

            return paths;
        }

        public (List<NodeWithWeightedEdges>, long) FindAcyclicShortestPath(long nodeIdStart, long nodeIdEnd)
        {
            List<(List<NodeWithWeightedEdges>, long)> paths = FindAcyclicPaths(nodeIdStart, nodeIdEnd);
            //PrintPaths(paths);
            (List<NodeWithWeightedEdges>, long) shortestAcyclicPath;
            try
            {
                shortestAcyclicPath = paths.MinBy((i) => i.Item2);
            }
            catch (Exception)
            {
                return (new(), -1);
            }

            return shortestAcyclicPath;
        }

        #region Debug methods

        protected void PrintPaths(List<(List<NodeWithWeightedEdges>, long)> paths)
        {
            long i = 0;
            foreach(var (list, weight) in paths)
            {
                Console.Write($"Path {i}, W = {weight}: ");
                    
                foreach(var node in list)
                {
                    Console.Write($"{node.Id}, ");
                }
                Console.WriteLine();
                i++;
            }
        }

        #endregion

        private List<(List<NodeWithWeightedEdges>, long)> FindAcyclicPathsRecursively(
            long startPathWeight,
            List<NodeWithWeightedEdges> currentPath,
            NodeWithWeightedEdges startNode,
            NodeWithWeightedEdges endNode)
        {
            currentPath.Add(startNode);

            List<(List<NodeWithWeightedEdges>, long)> acyclicPaths = new List<(List<NodeWithWeightedEdges>, long)>();

            long resultWeight = startPathWeight;

            if (startNode.Id != endNode.Id && startNode.EdgeCount > 0)
            {
                for (var i = 0; i < startNode.EdgeCount; i++)
                {
                    var edge = startNode.WeightedEdges[i];

                    // Избежание циклических связей
                    if (currentPath.Contains(edge.To))
                    {
                        continue;
                    }
                        
                    acyclicPaths.AddRange(
                        FindAcyclicPathsRecursively(resultWeight + edge.Weight /* или 1 в невзвешенном графе */
                        , new List<NodeWithWeightedEdges>(currentPath), edge.To, endNode)
                        ); 
                }

                return acyclicPaths;
            }
            else
            {
                if (endNode.Id != startNode.Id)
                    return acyclicPaths;

                acyclicPaths.Add((currentPath, resultWeight));
                return acyclicPaths;
            }
        }

    }

    public partial class MultiDirectedGraph
    {
        public new List<(List<NodeWithEdges>, long)> FindAcyclicPaths(long nodeIdStart, long nodeIdEnd)
        {
            NodeWithEdges startNode = GetNode(nodeIdStart);
            NodeWithEdges endNode = GetNode(nodeIdEnd);

            List<(List<NodeWithEdges>, long)> paths = FindAcyclicPathsRecursively(0, new List<NodeWithEdges>(), startNode, endNode);
            //PrintPaths(paths);
            return paths;
        }

        public new (List<NodeWithEdges>, long) FindAcyclicShortestPath(long nodeIdStart, long nodeIdEnd)
        {
            List<(List<NodeWithEdges>, long)> paths = FindAcyclicPaths(nodeIdStart, nodeIdEnd);

            (List<NodeWithEdges>, long) shortestAcyclicPath;
            try
            {
                shortestAcyclicPath = paths.MinBy((i) => i.Item2);
            }
            catch (Exception)
            {
                return (new(), -1);
            }

            return shortestAcyclicPath;
        }

        #region Debug methods

        protected new void PrintPaths(List<(List<NodeWithEdges>, long)> paths)
        {
            long i = 0;
            foreach (var (list, weight) in paths)
            {
                Console.Write($"Path {i}, W = {weight}: ");

                foreach (var node in list)
                {
                    Console.Write($"{node.Id}, ");
                }
                Console.WriteLine();
                i++;
            }
        }

        #endregion

        private List<(List<NodeWithEdges>, long)> FindAcyclicPathsRecursively(long startPathWeight, List<NodeWithEdges> currentPath, NodeWithEdges startNode, NodeWithEdges endNode)
        {
            currentPath.Add(startNode);

            List<(List<NodeWithEdges>, long)> acyclicPaths = new List<(List<NodeWithEdges>, long)>();

            long resultWeight = startPathWeight;

            if (startNode.Id != endNode.Id && startNode.EdgeCount > 0)
            {
                for (var i = 0; i < startNode.EdgeCount; i++)
                {
                    var edge = startNode.Edges[i];

                    // Избежание циклических связей
                    if (currentPath.Contains(edge.To))
                    {
                        continue;
                    }
                    acyclicPaths.AddRange(FindAcyclicPathsRecursively(resultWeight + 1, new List<NodeWithEdges>(currentPath), edge.To, endNode));
                }

                return acyclicPaths;
            }
            else
            {
                if (endNode.Id != startNode.Id)
                    return acyclicPaths;

                acyclicPaths.Add((currentPath, resultWeight));
                return acyclicPaths;
            }
        }
    }

    public partial class MultiDirectedWeightedGraph
    {
        public new List<(List<NodeWithWeightedEdges>, long)> FindAcyclicPaths(long nodeIdStart, long nodeIdEnd)
        {
            NodeWithWeightedEdges startNode = GetNode(nodeIdStart);
            NodeWithWeightedEdges endNode = GetNode(nodeIdEnd);

            List<(List<NodeWithWeightedEdges>, long)> paths = FindAcyclicPathsRecursively(0, new List<NodeWithWeightedEdges>(), startNode, endNode);
            //PrintPaths(paths);
            return paths;
        }

        public new (List<NodeWithWeightedEdges>, long) FindAcyclicShortestPath(long nodeIdStart, long nodeIdEnd)
        {
            List<(List<NodeWithWeightedEdges>, long)> paths = FindAcyclicPaths(nodeIdStart, nodeIdEnd);

            (List<NodeWithWeightedEdges>, long) shortestAcyclicPath;
            try
            {
                shortestAcyclicPath = paths.MinBy((i) => i.Item2);
            }
            catch (Exception)
            {
                return (new(), -1);
            }

            return shortestAcyclicPath;
        }

        #region Debug methods

        protected new void PrintPaths(List<(List<NodeWithWeightedEdges>, long)> paths)
        {
            long i = 0;
            foreach (var (list, weight) in paths)
            {
                Console.Write($"Path {i}, W = {weight}: ");

                foreach (var node in list)
                {
                    Console.Write($"{node.Id}, ");
                }
                Console.WriteLine();
                i++;
            }
        }

        #endregion

        private List<(List<NodeWithWeightedEdges>, long)> FindAcyclicPathsRecursively(long startPathWeight, List<NodeWithWeightedEdges> currentPath, NodeWithWeightedEdges startNode, NodeWithWeightedEdges endNode)
        {
            currentPath.Add(startNode);

            List<(List<NodeWithWeightedEdges>, long)> acyclicPaths = new List<(List<NodeWithWeightedEdges>, long)>();

            long resultWeight = startPathWeight;

            if (startNode.Id != endNode.Id && startNode.EdgeCount > 0)
            {
                for (var i = 0; i < startNode.EdgeCount; i++)
                {
                    var edge = startNode.WeightedEdges[i];

                    // Избежание циклических связей
                    if (currentPath.Contains(edge.To))
                    {
                        continue;
                    }

                    acyclicPaths.AddRange(FindAcyclicPathsRecursively(resultWeight + edge.Weight, new List<NodeWithWeightedEdges>(currentPath), edge.To, endNode));
                }

                return acyclicPaths;
            }
            else
            {
                if (endNode.Id != startNode.Id)
                    return acyclicPaths;

                acyclicPaths.Add((currentPath, resultWeight));
                return acyclicPaths;
            }
        }
    }
}
