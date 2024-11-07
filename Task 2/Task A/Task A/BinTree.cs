using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class BinTree
    {
        private Node root;    //Top/start of the tree...



        // initializes the root to null
        public BinTree()
        {
            root = null;
        }

        //variable to store the top/root of the tree
        public BinTree(Node node)
        {
            root = node;
        }

        //method to insert an integer item into the tree
        private void insertItem(int item, ref Node tree)
        {

            // If the current node is null, a new node with the item as its data and set it as the current node
            if (tree == null)
                tree = new Node(item);

            // If the item is less than the current node's data, recursively insert it into the left subtree
            else if (item < tree.Data)
                insertItem(item, ref tree.Left);

            // If the item is greater than the current node's data, recursively insert it into the right subtree
            else if (item > tree.Data)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(int item)
        { insertItem(item, ref root); }


        //prints the contents of the tree inorder
        public void InOrder()
        {
            inOrder(root);
        }


        private void inOrder(Node tree)
        {
            if (tree != null)
            {
                inOrder(tree.Left);
                Console.Write(tree.Data + ", ");
                inOrder(tree.Right);
                //Console.WriteLine(tree.Data.ToString() + );
            }
        }


        //prints the contents of the tree postorder
        public void PostOrder()
        {
            postOrder(root);
        }


        private void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write(tree.Data + ", ");

            }
        }


        //prints the contents of the tree preorder
        public void PreOrder()
        {
            preOrder(root);
        }
        private void preOrder(Node tree)
        {
            if (tree != null)
            {
                Console.Write(tree.Data + ", ");
                preOrder(tree.Left);
                preOrder(tree.Right);

            }
        }
    }
}

