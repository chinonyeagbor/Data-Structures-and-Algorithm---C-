using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            // Add nodes to the graph
            graph.AddNode(1);
            graph.AddNode(2);
            graph.AddNode(3);
            graph.AddNode(4);

            // Add edges to the graph
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            

            Console.WriteLine("Number of nodes in Graph: " + graph.NumNodesGraph());
            Console.WriteLine("Number of edges in Graph: " + graph.NumEdgesGraph());
                       

            Console.ReadLine();

           
        }
    }
}
    
