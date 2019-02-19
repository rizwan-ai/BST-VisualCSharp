using System;
using static System.Console;

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
        private Node[] stack;
        private int top;
        public BST(int size)
        {
            root = null;
            stack = new Node[size];
            top = -1;
        }
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
        // Searching Operation in BST (Simple-Logic ... Not Recursively)
        public void SearchNode(int value)
        {
            if (root == null)
            {
                WriteLine("Tree is Empty");
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
                        WriteLine($"Value {value} is found");
                        return;
                    }
                    if (value < current.data)
                        current = current.left;
                    else
                        current = current.right;
                }
            }
            if (current == null)
                WriteLine("Value not found");
        }
        // Traversing Operations in BST (Simple-Logic ... Not Recursively)
        // 1) Inorder Traversal 
        public void InOrder()
        {
            if (root == null)
            {
                WriteLine("Tree is Empty");
                return;
            }
            else
            {
                current = root;
                Push(current);
                while (top >= 0)
                {
                    current = stack[top];  // Pop value  
                    stack[top] = null;
                    top--;
                    Write($"{current.data} ");
                    if (current.right != null)
                        Push(current.right);
                }
            }
        }
        public void Push(Node temp)
        {
            while (temp != null)
            {
                top++;
                stack[top] = temp;
                temp = temp.left;
            }
        }
        // 2) Preorder Traversal
        public void PreOrder()
        {
            if (root == null)
            {
                WriteLine("Tree is Empty");
                return;
            }
            else
            {
                top++;
                stack[top] = root;
                while (top >= 0)
                {
                    current = stack[top];
                    top--;
                    while (current != null)
                    {
                        Write($"{current.data} ");
                        if(current.right != null)
                        {
                            top++;
                            stack[top] = current.right;
                        }
                        current = current.left;
                    }
                }
            }
        }
        // 3) Postorder Traversal
        public void PostOrder()
        {
            // Self-Try ...
        }
    }
}