using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_B
{
    public partial class Form1 : Form
    {
        private Graph graph;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void AddBbutton_Click(object sender, EventArgs e)
        {
            string name = AddNameTextBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a Name");
                return;
            }
            graph.AddNode(name);
            AddNameTextBox.Clear();

            MessageBox.Show($"{name} has been added.");
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            string Friend1 = FromTextBox.Text;
            string Friend2 = ToTextBox.Text;

            if (string.IsNullOrEmpty(Friend1) || string.IsNullOrEmpty(Friend2))
            {
                MessageBox.Show("Enter a name on the List");
            }

            graph.AddEdge(Friend1, Friend2);
                        FromTextBox.Clear();
            ToTextBox.Clear();

            MessageBox.Show($"{Friend1} and {Friend2} are now friends.");
        }

        private void ShowFriendsButton_Click(object sender, EventArgs e)
                   
        {
            Display.Items.Clear();
            string name = FriendTextBox4.Text;
            // Define a list where we are going to store the adjacency list of the node 
            LinkedList<GraphNode> adjl = new LinkedList<GraphNode>();



            // Get the GraphNode of the node with name = input name
            // and store it in the variable n

            GraphNode n = graph.GetNodeByName(name);

            if (n == null)
            {
                MessageBox.Show($"{name} no friends found or wrong name entered.");
                return;
            }

            // Get and store in adjl the adjacency list of the node n           
            adjl = n.GetAdjList(); 

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Direct friends of {name}:");

            // display the names of all nodes that are in adjl
            foreach  (GraphNode friend in adjl)
            {
                sb.AppendLine(friend.Name);
            }
            MessageBox.Show(sb.ToString());
               
   
            Display.Items.Add(sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Items.Clear();


            List<GraphNode> allNodes = graph.GetAllNodes();

            foreach (GraphNode node in allNodes)
            {
                Display.Items.Add(node.Name);
            }
        }
     
    }
}

