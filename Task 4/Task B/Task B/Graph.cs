using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class Graph
    {
        // list of graphnodes in the graph (represents all the nodes present in the graph)
        public LinkedList<GraphNode> nodes;

        // constructor of a Graph. Construct a graph and set 
        // the list of nodes in the graph to be the empty list;
        // the constructed graph has no nodes
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        // Add a new node (with the specific name) to the graph.
        // Use the constructor of graphnode
        // "AddLast" adds the constructed graphnode to the list of all nodes.
        // May also use "AddFirst" - as long as the new node is added to the list of the nodes 
        // it does not matter where it is added (first or last)
        public void AddNode(string name)
        {
            nodes.AddLast(new GraphNode(name));
        }

        //Return the graphnode with the specific name passed as input argument
        public GraphNode GetNodeByName(string name)
        {
            // Search through the list of all nodes in the graph for the node with the specific name
            foreach (GraphNode n in nodes)
            {
                // found the node n with the specific name; return n
                if (name.CompareTo(n.Name) == 0)
                    return n;
            }

            // the node has not been found (no node with the specific name is present in the graph)
            return null;
        }

        // Add a directed edge between nodes with names "from" and "to" 
        public void AddEdge(string from, string to)
        {
            // Get the graphnode that corresponds to the node with name "from"
            GraphNode n1 = GetNodeByName(from);

            // Get the graphnode that corresponds to the node with name "to"
            GraphNode n2 = GetNodeByName(to);
            if (n1 == null || n2 == null)
            {
                Console.WriteLine("Error: both nodes must have a value");
            }

            // add a directed edge going from node n1 to node n2
            n1.AddEdge(n2);
        }

        // Display the names of all persons present in the graph
        public void DisplayAllNodes()
        {
            Console.WriteLine("Nodes in the graph:");

            foreach (GraphNode n in nodes)
            {
                Console.WriteLine(n.Name);
            }

            Console.WriteLine();
        }

        // Display the names of the direct friends of a person (adjacent nodes in the graph)

      

        public void DisplayDirectFriends(string name)
            {
            GraphNode n = GetNodeByName(name);
            Console.WriteLine($"Direct Friends of {n.Name}");
        }
        

        public int NumNodesGraph()
        {
            return nodes.Count;
        }

        // returns the total number of edges present in the graph
        public int NumEdgesGraph()
        {
            int numEdges = 0;
            foreach (GraphNode n in nodes)
            {
                numEdges += n.GetAdjList().Count;
            }
            return numEdges;
        }

        public List<GraphNode> GetAllNodes()
        {
            return nodes.ToList();
        }
    }
}


    