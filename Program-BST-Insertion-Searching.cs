using System;
using static System.Console;
using static System.Convert;

namespace BST_Operations
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

            Write("Enter value to search : ");
            int v = ToInt32(ReadLine());
            bst.SearchNode(v);


            ReadKey();
        }
    }
}
