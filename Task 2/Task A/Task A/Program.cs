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
            //create a new binary tree instance
            BinTree testTree = new BinTree();

            // Insert items into the tree
            testTree.InsertItem(4);
            testTree.InsertItem(3);
            testTree.InsertItem(1);
            testTree.InsertItem(7);
            testTree.InsertItem(5);
            testTree.InsertItem(9);

            Console.WriteLine("InOrder traversal:");
            testTree.InOrder();

            Console.WriteLine("\n\nPostOrder traversal:");
            testTree.PostOrder();

            Console.WriteLine("\n\nPreOrder traversal:");
            testTree.PreOrder();

            Console.ReadLine();


        }
    }
}
