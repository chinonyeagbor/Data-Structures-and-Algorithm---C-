using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
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
        public void insertItem(string item, ref Node tree)
        {

            // If the current node is null, a new node with the item as its data and set it as the current node
            if (tree == null)
                tree = new Node(item);

            // If the item is less than the current node's data, recursively insert it into the left subtree
            else if (string.Compare(item, tree.Data) < 0)
                insertItem(item, ref tree.Left);

            // If the item is greater than the current node's data, recursively insert it into the right subtree
            else if (string.Compare(item, tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(string item)
        {
            insertItem(item, ref root);
        }



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

        //contains method starts here
        public bool Contains(string item)
        {
            return contains(item, root);
        }

        private bool contains(string item, Node tree)
        {
            if (tree == null)
                return false;

            if (tree.Data == item)
                return true;

            if (string.Compare(item, tree.Data) < 0)
                return contains(item, tree.Left);

            else
                return contains(item, tree.Right);
        }


        //Longest method starts here
        public string Longest()
        {
            return longest(root);
        }

        private string longest(Node tree)
        {
            if (tree == null)
                return "";

            string left = longest(tree.Left);
            string right = longest(tree.Right);

            return MaxString(left, right, tree.Data);
        }

        //Maxstring Method starts here
        private string MaxString(string str1, string str2, string str3)
        {
            if (str1.Length >= str2.Length && str1.Length >= str3.Length)
                return str1;
            else if (str2.Length >= str1.Length && str2.Length >= str3.Length)
                return str2;
            else
                return str3;
        }
        //The Ancestor Method starts here
        public string Ancestor(string str1, string str2)
        {
            // Check if both strings are present in the tree and returns null if either not present
            if (!Contains(str1) || !Contains(str2))
            {
                return null;
            }

            // Finds the lowest common ancestor of the two strings
            Node ancestor = FindAncestor(root, str1, str2);


            // If no common ancestor is found it returns null otherwise, returns the string value
            if (ancestor == null)
            {
                return null;
            }
            else
            {
                return ancestor.Data;
            }
        }

        private Node FindAncestor(Node node, string str1, string str2)
        {
            // Base case: if the current node is null, return null
            if (node == null)
            {
                return null;
            }

            // If both strings are less than the current node's string, search the left subtree
            // then search the right subtree if both strings are greater than the current node's string,
            // otherwise return the node
            if (string.Compare(str1, node.Data) < 0 && string.Compare(str2, node.Data) < 0)
            {
                return FindAncestor(node.Left, str1, str2);
            }
            else if (string.Compare(str1, node.Data) > 0 && string.Compare(str2, node.Data) > 0)
            {
                return FindAncestor(node.Right, str1, str2);
            }
            else
            {
                return node;
            }
        }

    }
}
