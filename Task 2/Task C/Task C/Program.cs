using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a binary tree of strings
            BinTree testTree = new BinTree();
            testTree.InsertItem("hello");
            testTree.InsertItem("from");
            testTree.InsertItem("join");
            testTree.InsertItem("done");
            testTree.InsertItem("idea");
            testTree.InsertItem("waif");
            testTree.InsertItem("ants");
            testTree.InsertItem("lime");

            // test the Longest method
            string longest = testTree.Longest();
            Console.WriteLine($"The longest string in the tree is: {longest}");

            // test the Ancestor method
            string ancestor = testTree.Ancestor("idea", "waif");
            Console.WriteLine($"The common ancestor of 'idea' and 'waif' is: {ancestor}");

            Console.ReadLine();
        }
    }
}
