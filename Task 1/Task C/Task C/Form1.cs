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
        private readonly CustomerQueue.Queue customerQueue = new CustomerQueue.Queue();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void EnqueueButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            customerQueue.Enqueue(new Customer(name, age));
            Preview.Items.Add($"{name}, {age} years old.");
            PreviewLabel.Text = $"{name}, Added Successfully!";
            NameTextBox.Clear();
            AgeTextBox.Clear();
            Label();
        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            if (customerQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty.");
            }
            else
            {
                Customer remove = customerQueue.Dequeue();
                Preview.Items.RemoveAt(0);
                PreviewLabel.Text = ($"{remove.Name}, Removed Successfully!");
                MessageBox.Show($"{remove.Name}, {remove.Age} years, removed from the queue.");
                Label();
            }

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (customerQueue.IsEmpty())
            {
                Preview.Text = "Queue is empty.";
                MessageBox.Show("Queue is empty.");
            }
            else
            {
                string contents = customerQueue.GetContents();
                Preview.Text = contents;
                MessageBox.Show(contents);
            }
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            int k = int.Parse(ReverseTextBox.Text);
            customerQueue.ReverseFirstK(k);
            Reverse.Items.Clear();
            foreach (var customer in customerQueue.GetCustomers())
            {
                Reverse.Items.Add($"{customer.Name}, {customer.Age} years old.");
            }
        }

        public void Label()
        {
            QueueTotalLabel.Text = "Number of Customers in queue: " + customerQueue.Count();
        }
    }
}
