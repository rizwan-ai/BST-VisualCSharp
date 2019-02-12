using System;
using static System.Console;

namespace BST_Traversing
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }
    public class BST
    {
        private Node root, temp, current, parent;
        public BST() => root = null;
        // Insertion Operation in BST (Simple-Logic ... Not Recursively)
        public void InsertNode(int value)
        {
            // Create node and assign to it ...
            temp = new Node();
            temp.data = value;
            temp.left = temp.right = null;
            if (root == null)
            {
                root = temp;
                return;
            }
            // Go to proper position to insert node ...
            current = root;
            while (current != null)
            {
                if (value == current.data)
                {
                    WriteLine($"Value {value} is already exist");
                    return;
                }
                if (value < current.data)
                {
                    parent = current;
                    current = current.left;
                }
                else
                {
                    parent = current;
                    current = current.right;
                }
            }

            if (value < parent.data)
                parent.left = temp;
            else
                parent.right = temp;
        }
        // Traversing Operation in BST (Recursively)
        // 1) InOrder Traversal 
        public void InOrder() => InOrd(root);
        private void InOrd(Node r)
        {
            if (r == null) return;
            InOrd(r.left);
            Write($"{r.data} ");
            InOrd(r.right);
        }
        // 2) PreOrder Traversal 
        public void PreOrder() => PreOrd(root);
        private void PreOrd(Node r)
        {
            if (r == null) return;
            Write($"{r.data} ");
            PreOrd(r.left);
            PreOrd(r.right);
        }
        // 3) PostOrder Traversal 
        public void PostOrder() => PostOrd(root);
        private void PostOrd(Node r)
        {
            if (r == null) return;
            PostOrd(r.left);
            PostOrd(r.right);
            Write($"{r.data} ");
        }
    }
}