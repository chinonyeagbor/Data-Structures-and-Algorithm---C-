using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Node
    {
        // Declare a private integer variable to store the node's data
        // and public Node variables that represent the node's left and right children
        private int data;
        public Node Left, Right;


        // Declare a constructor that takes an integer argument to set the node's data
        public Node(int item)
        {
            // this assigns the value of "item" to the "data" variable
            // and initializes the left and right children to null

            data = item;
            Left = null;
            Right = null;

        }

        // Declare a public property called "Data" to access the node's data
        // Getters to return data and Setters to set value of data
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
