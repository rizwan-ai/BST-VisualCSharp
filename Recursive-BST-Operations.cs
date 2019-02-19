using static System.Console;

namespace Recursive_BST_Operations
{
    public class Node
    {
        public int data;
        public Node left, right;
    }
    public class BST
    {
        private Node r, temp;
        public BST() => r = null;

        // Insertion Operation in BST (Recursively)
        public void InsertNode(int v) => r = Insert(r, v);
        private Node Insert(Node root, int value)
        {
            // Create node and assign data to it ...
            temp = new Node();
            temp.data = value;
            temp.left = temp.right = null;

            if (root == null)
                root = temp;
            else if(value == root.data)
            {
                WriteLine($"Value {value} is already exist");
                return root;
            }
            else if (value < root.data)
                root.left = Insert(root.left, value);
            else
                root.right = Insert(root.right, value);
            return root;
        }

        // Searching Operation in BST (Recursively)
        public void SearchNode(int v)
        {
            // Self-Try ...
        }

        // Traversing Operations in BST (Recursively)
        // 1) InOrder Traversal 
        public void InOrder() => InOrd(r);
        private void InOrd(Node root)
        {
            if (root == null) return;
            InOrd(root.left);
            Write($"{root.data} ");
            InOrd(root.right);
        }
        // 2) PreOrder Traversal 
        public void PreOrder() => PreOrd(r);
        private void PreOrd(Node root)
        {
            if (root == null) return;
            Write($"{root.data} ");
            PreOrd(root.left);
            PreOrd(root.right);
        }
        // 3) PostOrder Traversal 
        public void PostOrder() => PostOrd(r);
        private void PostOrd(Node root)
        {
            if (root == null) return;
            PostOrd(root.left);
            PostOrd(root.right);
            Write($"{root.data} ");
        }
    }
}