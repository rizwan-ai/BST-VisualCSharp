using System;
using static System.Console;
using static System.Convert;

namespace BST_Traversing
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();

            Write("Enter Total Values : ");
            int length = ToInt32(ReadLine());
            for (int i = 0; i < length; i++)
            {
                Write($"Enter Value {i + 1} : ");
                int val = ToInt32(ReadLine());
                bst.InsertNode(val);
            }

            WriteLine("InOrder Traversal");
            bst.InOrder();
            WriteLine("\nPreOrder Traversal");
            bst.PreOrder();
            WriteLine("\nInOrder Traversal");
            bst.PostOrder();


            ReadKey();
        }
    }
}
