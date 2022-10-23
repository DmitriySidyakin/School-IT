// See https://aka.ms/new-console-template for more information
using GraphAlgorithms.Graph;
using GraphAlgorithms.Graph.Exceptions;

int testsCount = 6;

for (int testNum = 1; testNum <= testsCount; testNum++)
    switch (testNum)
    {
        case 1: Test001TestGraphNameSpace(); break;
        case 2: Test002TestGraphNameSpace(); break;
        case 3: Test003TestGraphNameSpace(); break;
        case 4: Test004TestWeightedGraphNameSpace(); break;
        case 5: Test005TestMultiDirectedGraphNameSpace(); break;
        case 6: Test006TestMultiDirectedWeightedGraphNameSpace(); break;
        default: Console.WriteLine($"Ошибка! Выберите правильный номер теста от 1 до {testsCount}."); break;
    }



void Test006TestMultiDirectedWeightedGraphNameSpace()
{
    try
    {
        var graph = MakeMultiDirectedWeightedGraph(1);

        (var steps, long resultSteps) = graph.FindAcyclicShortestPath(0, 7);

        string path = "";
        if (resultSteps > -1)
        {
            path = "Путь состоит из шагов: ";

            foreach (var step in steps)
            {
                path += $" {step.Id};";
            }
        }

        PrintSuccess($"Test 6 Found the way with {resultSteps} steps ! {path}");
    }
    catch (GraphException ex)
    {
        PrintFail(ex.Message);
    }
}

void Test005TestMultiDirectedGraphNameSpace()
{
    try
    {
        var graph = MakeMultiDirectedGraph(1);

        (var steps, long resultSteps) = graph.FindAcyclicShortestPath(0, 7);

        string path = "";
        if (resultSteps > -1)
        {
            path = "Путь состоит из шагов: ";

            foreach (var step in steps)
            {
                path += $" {step.Id};";
            }
        }

        PrintSuccess($"Test 5 Found the way with {resultSteps} steps ! {path}");
    }
    catch (GraphException ex)
    {
        PrintFail(ex.Message);
    }
}

void Test004TestWeightedGraphNameSpace()
{
    try
    {
        var graph = MakeWeightedGraph(1);

        (var steps, long resultSteps) = graph.FindAcyclicShortestPath(0, 7);

        string path = "";
        if (resultSteps > -1)
        {
            path = "Путь состоит из шагов: ";

            foreach (var step in steps)
            {
                path += $" {step.Id};";
            }
        }

        PrintSuccess($"Test 4 Found the way with {resultSteps} steps ! {path}");
    }
    catch (GraphException ex)
    {
        PrintFail(ex.Message);
    }
}

void Test003TestGraphNameSpace()
{
    try
    {
        var graph = MakeGraph(1);

        (var steps, long resultSteps) = graph.FindAcyclicShortestPath(0, 4);

        string path = "";
        if (resultSteps > - 1)
        {
            path = "Путь состоит из шагов: ";

            foreach (var step in steps)
            {
                path += $" {step.Id};";
            }
        }
        

        PrintSuccess($"Test 3 Found the way with {resultSteps} steps ! {path}");

    }
    catch (GraphException ex)
    {
        PrintFail(ex.Message);
    }
}

void Test002TestGraphNameSpace()
{
    try
    {
        var graph = MakeGraph(1);
        if(!graph.IsConnected)
            PrintSuccess("Test 2: Step 1 is over.");

        var graph2 = MakeGraph(2);
        if (graph2.IsConnected)
            PrintSuccess("Test 2: Step 2 is over.");

        PrintSuccess("Test 2 successed!"); ;
    }
    catch (GraphException ex)
    {
        PrintFail(ex.Message);
    }
}

void Test001TestGraphNameSpace()
{
    try
    {
        Console.WriteLine("Make graph 1:");
        var graph = MakeGraph(1);
        printGraph(graph);

        Console.WriteLine("Make graph 2:");
        var graph2 = MakeGraph(2);
        printGraph(graph2);

        PrintSuccess("Test 1 successed!");
    }
    catch(GraphException ex)
    {
        PrintFail(ex.Message);
    } 
}

void printGraph(Graph graph)
{
    for (int n = 0; n < graph.NodeCount; n++)
    {
        string nodeInfo = $"Node{graph.GetNode(n).Id+1}:";
        for(int eC = 0; eC < graph.GetNode(n).EdgeCount; eC++)
        {
            nodeInfo += $" {graph.GetEdge(n, eC).To.Id+1};";
        }

        Console.WriteLine(nodeInfo);
        Console.WriteLine();
    }
    
}

static void PrintSuccess(string message)
{
    var color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}

static void PrintFail(string message)
{
    var color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}


static Graph MakeGraph(byte number) => number switch
{
    1 => MakeGraph001(),
    2 => MakeGraph002(),
    _ => throw new ArgumentOutOfRangeException(nameof(number)),
};

static WeightedGraph MakeWeightedGraph(byte number) => number switch
{
    1 => MakeWeightedGraph001(),
    _ => throw new ArgumentOutOfRangeException(nameof(number)),
};

static MultiDirectedGraph MakeMultiDirectedGraph(byte number) => number switch
{
    1 => MakeMultiDirectedGraph001(),
    _ => throw new ArgumentOutOfRangeException(nameof(number)),
};

static MultiDirectedWeightedGraph MakeMultiDirectedWeightedGraph(byte number) => number switch
{
    1 => MakeMultiDirectedWeightedGraph001(),
    _ => throw new ArgumentOutOfRangeException(nameof(number)),
};
static MultiDirectedWeightedGraph MakeMultiDirectedWeightedGraph001()
{
    MultiDirectedWeightedGraph g = new MultiDirectedWeightedGraph();
    NodeWithWeightedEdges node1 = g.AddEmptyNode();
    NodeWithWeightedEdges node2 = g.AddEmptyNode();
    NodeWithWeightedEdges node3 = g.AddEmptyNode();
    NodeWithWeightedEdges node4 = g.AddEmptyNode();
    NodeWithWeightedEdges node5 = g.AddEmptyNode();
    NodeWithWeightedEdges node6 = g.AddEmptyNode();
    NodeWithWeightedEdges node7 = g.AddEmptyNode();
    NodeWithWeightedEdges node9 = g.AddEmptyNode();

    _ = g.AddEdge(node1, node2, 30);
    _ = g.AddEdge(node1, node3, 5);
    _ = g.AddEdge(node1, node4, 5);
    _ = g.AddEdge(node1, node5, 1);
    _ = g.AddEdge(node2, node5, 1);
    _ = g.AddEdge(node5, node7, 5);
    _ = g.AddEdge(node3, node6, 5);
    _ = g.AddEdge(node4, node7, 5);
    _ = g.AddEdge(node4, node7, 5);
    _ = g.AddEdge(node2, node9, 1);
    _ = g.AddEdge(node5, node9, 15);

    return g;
}

static MultiDirectedGraph MakeMultiDirectedGraph001()
{
    MultiDirectedGraph g = new MultiDirectedGraph();
    NodeWithEdges node1 = g.AddEmptyNode();
    NodeWithEdges node2 = g.AddEmptyNode();
    NodeWithEdges node3 = g.AddEmptyNode();
    NodeWithEdges node4 = g.AddEmptyNode();
    NodeWithEdges node5 = g.AddEmptyNode();
    NodeWithEdges node6 = g.AddEmptyNode();
    NodeWithEdges node7 = g.AddEmptyNode();
    NodeWithEdges node9 = g.AddEmptyNode();

    _ = g.AddEdge(node1, node2);
    _ = g.AddEdge(node1, node3);
    _ = g.AddEdge(node1, node4);
    _ = g.AddEdge(node1, node5);
    _ = g.AddEdge(node2, node5);
    _ = g.AddEdge(node5, node7);
    _ = g.AddEdge(node3, node6);
    _ = g.AddEdge(node4, node7);
    _ = g.AddEdge(node4, node7);
    _ = g.AddEdge(node2, node9);
    _ = g.AddEdge(node5, node9);

    return g;
}

static Graph MakeGraph001()
{
    Graph g = new Graph();
    NodeWithEdges node1 = g.AddEmptyNode();
    NodeWithEdges node2 = g.AddEmptyNode();
    NodeWithEdges node3 = g.AddEmptyNode();
    NodeWithEdges node4 = g.AddEmptyNode();
    NodeWithEdges node5 = g.AddEmptyNode();
    NodeWithEdges node6 = g.AddEmptyNode();
    NodeWithEdges node7 = g.AddEmptyNode();
    NodeWithEdges node8 = g.AddEmptyNode();

    g.AddEdge(node1, node2);
    g.AddEdge(node1, node3);
    g.AddEdge(node1, node4);
    g.AddEdge(node1, node5);
    g.AddEdge(node2, node5);
    g.AddEdge(node5, node7);
    g.AddEdge(node3, node6);
    g.AddEdge(node6, node5);
    g.AddEdge(node4, node7);

    return g;
}

static Graph MakeGraph002()
{
    Graph g = new Graph();
    NodeWithEdges node1 = g.AddEmptyNode();
    NodeWithEdges node2 = g.AddEmptyNode();
    NodeWithEdges node3 = g.AddEmptyNode();
    NodeWithEdges node4 = g.AddEmptyNode();
    NodeWithEdges node5 = g.AddEmptyNode();
    NodeWithEdges node6 = g.AddEmptyNode();
    NodeWithEdges node7 = g.AddEmptyNode();

    g.AddEdge(node1, node2);
    g.AddEdge(node1, node3);
    g.AddEdge(node1, node4);
    g.AddEdge(node1, node5);
    g.AddEdge(node2, node5);
    g.AddEdge(node5, node7);
    g.AddEdge(node3, node6);
    g.AddEdge(node4, node7);

    return g;
}

static WeightedGraph MakeWeightedGraph001()
{
    WeightedGraph g = new WeightedGraph();
    NodeWithWeightedEdges node1 = g.AddEmptyNode();
    NodeWithWeightedEdges node2 = g.AddEmptyNode();
    NodeWithWeightedEdges node3 = g.AddEmptyNode();
    NodeWithWeightedEdges node4 = g.AddEmptyNode();
    NodeWithWeightedEdges node5 = g.AddEmptyNode();
    NodeWithWeightedEdges node6 = g.AddEmptyNode();
    NodeWithWeightedEdges node7 = g.AddEmptyNode();
    NodeWithWeightedEdges node9 = g.AddEmptyNode();

    _ = g.AddEdge(node1, node2, 30);
    _ = g.AddEdge(node1, node3, 5);
    _ = g.AddEdge(node1, node4, 5);
    _ = g.AddEdge(node1, node5, 1);
    _ = g.AddEdge(node2, node5, 1);
    _ = g.AddEdge(node5, node7, 5);
    _ = g.AddEdge(node3, node6, 5);
    _ = g.AddEdge(node4, node7, 15);
    _ = g.AddEdge(node2, node9, 1);
    _ = g.AddEdge(node5, node9, 15);

    return g;
}