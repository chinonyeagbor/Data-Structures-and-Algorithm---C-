using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskB
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
            string name = CustomerInput.Text;
            customerQueue.Enqueue(name);
            Preview.Items.Add(name);
            CustomerInput.Clear();
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
                string remove = customerQueue.Dequeue();
                Preview.Items.Remove(remove);
                MessageBox.Show($"{remove} removed from the queue.");
                Label();
            }

        }

      
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (customerQueue.IsEmpty())
            {
                DisplayBox.Text = "Queue is empty.";
                MessageBox.Show("Queue is empty.");
            }
            else
            {
                string contents = customerQueue.GetContents();
                DisplayBox.Text = contents + Environment.NewLine;
            }


        }
        public void Label()
        {
            QueueTotalLabel.Text = "Number of Customers in queue: " + customerQueue.Count();
        }

        private void QueueTotalLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
