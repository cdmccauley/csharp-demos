using System;
using BinaryTreeLibrary4_7_02556;

namespace TreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree varTree = new Tree();

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Enter a value: ");
                var userInput = Console.ReadLine();
                varTree.InsertNode(userInput);
            }

            TraverseTree(varTree, "varTree");

            // hold
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }

        private static void TraverseTree(Tree tree, string treeType)
        {
            Console.WriteLine("\n\nPreorder traversal of " + treeType);
            tree.PreorderTraversal();

            Console.WriteLine("\n\nInorder traversal of " + treeType);
            tree.InorderTraversal();

            Console.WriteLine("\n\nPostorder traversal of " + treeType);
            tree.PostOrderTraversal();
        }
    }
}
