using System;
using BinaryTreeLibrary;
using static BinaryTreeLibrary.TreeNode;

namespace bst
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            int insertVal;
            Random r = new Random();
            for (int i = 0; i <= 10; i++) {
                insertVal = r.Next(100);
                t.InsertNode(insertVal);
            }

            Console.WriteLine("Preorder");
            t.PreorderTraversal();
            Console.WriteLine("\n");
            Console.WriteLine("Inorder");
            t.InorderTraversal();
            Console.WriteLine("\n");
            Console.WriteLine("Postorder");
            t.PostorderTraversal();
            Console.WriteLine("\n");
        }
    }
}
