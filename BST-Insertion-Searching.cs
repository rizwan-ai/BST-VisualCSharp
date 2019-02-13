using System;

namespace BST_Operations
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
            // Create node and assign data to it ...
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
                    Console.WriteLine($"Value {value} is already exist");
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
        // Searching Operation in BST (Simple-Logic ... Not Recursively)
        public void SearchNode(int value)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is Empty");
                return;
            }
            else
            {
                // search value ...
                current = root;
                while (current != null)
                {
                    if (value == current.data)
                    {
                        Console.WriteLine($"Value {value} is found");
                        return;
                    }
                    if (value < current.data)
                        current = current.left;
                    else
                        current = current.right;
                }
            }
            if (current == null)
                Console.WriteLine("Value not found");
        }
    }
}
