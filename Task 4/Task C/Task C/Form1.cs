using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_C
{
    public partial class Form1 : Form
    {
        private Graph graph;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
        }

        private void AddNameButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a Name");
                return;
            }
            graph.AddNode(name);
            NameTextBox.Clear();

            PreviewLabel.Text = $"{name} has been added.";
        }

        private void AddEdgeButton_Click(object sender, EventArgs e)
        {
            string Friend1 = FromTextBox.Text;
            string Friend2 = ToTextBox.Text;

            if (string.IsNullOrEmpty(Friend1) || string.IsNullOrEmpty(Friend2))
            {
                MessageBox.Show("Enter a name on the List");
                return;
            }

            graph.AddEdge(Friend1, Friend2);
            FromTextBox.Clear();
            ToTextBox.Clear();

            PreviewLabel.Text = $"{Friend1} and {Friend2} are now friends.";
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Display.Items.Clear();

            List<GraphNode> allNodes = graph.GetAllNodes();

            if(allNodes.Count == 0)
            {
                MessageBox.Show("The list is empty. Enter a name.");
            }

            foreach (GraphNode node in allNodes)
            {
                Display.Items.Add(node.Name);
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string name = RemoveTextBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a name to Remove");
                return;
            }
            graph.RemoveNode(name);
            RemoveTextBox.Clear();
            PreviewLabel.Text = $"{name} has been removed.";
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            Display.Items.Clear();
            List<GraphNode> allNodes = graph.GetAllNodes();

            foreach (GraphNode node in allNodes)
            {
                Display.Items.Add(node.Name);
            }
        }

        private void ShowFriendsButton_Click(object sender, EventArgs e)
        {
            {
                Display.Items.Clear();
                string name = ShowFrierndsTextBox.Text;

                GraphNode n = graph.GetNodeByName(name);
                if (n == null)
                {
                    MessageBox.Show($"{name} has no friends or wrong name entered");
                    return;
                }

                List<string> friendList = new List<string>();

                if (DirectFriendsRadioButton.Checked)
                {
                    LinkedList<GraphNode> adjl = n.GetAdjList();
                    friendList = adjl.Select(friend => friend.Name).ToList();
                }

                else if (IndirectFriendsRadioButton.Checked)
                {
                    List<string> allFriends = graph.GetDirectAndIndirectFriends(name);
                    HashSet<string> directFriendSet = new HashSet<string>(n.GetAdjList().Select(friend => friend.Name));
                    friendList = allFriends.Where(friend => !directFriendSet.Contains(friend)).ToList();

                }

                else if (AllNetworkFriendsRadioButton.Checked)
                {
                    friendList = graph.GetDirectAndIndirectFriends(name);
                }

                StringBuilder sb = new StringBuilder();
                if (DirectFriendsRadioButton.Checked)
                {
                    sb.AppendLine($"Direct friends of {name} :");
                }

                else if (IndirectFriendsRadioButton.Checked)
                {
                    sb.AppendLine($"Indirect friends of {name} :");
                }

                else if (AllNetworkFriendsRadioButton.Checked)
                {
                    sb.AppendLine($"Direct and indirect friends of {name} :");
                }

                Display.Items.Add(sb.ToString());

                foreach (string friend in friendList)
                {
                    Display.Items.Add(friend);
                }

               

            }
        }
    }
}
