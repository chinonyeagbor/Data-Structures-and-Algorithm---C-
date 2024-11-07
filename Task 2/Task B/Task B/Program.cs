using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new binary tree instance
            BinTree testTree = new BinTree();

            // Insert items into the tree
            testTree.InsertItem(4);
            testTree.InsertItem(3);
            testTree.InsertItem(1);
            testTree.InsertItem(7);
            testTree.InsertItem(5);
            testTree.InsertItem(9);

            //Prints the Inorder, PostOrder and PreOrder traversal
            Console.WriteLine("InOrder traversal:");
            testTree.InOrder();

            Console.WriteLine("\n\nPostOrder traversal:");
            testTree.PostOrder();

            Console.WriteLine("\n\nPreOrder traversal:");
            testTree.PreOrder();

            // Test the Contains method
            int item1 = 2;
            int item2 = 5;
            Console.WriteLine("\n\nContains({0}): {1}", item1, testTree.Contains(item1));
            Console.WriteLine("Contains({0}): {1}", item2, testTree.Contains(item2));


            Console.ReadLine();

        }
    }
}
