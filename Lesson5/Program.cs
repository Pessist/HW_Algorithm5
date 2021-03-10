using System;

namespace ALesson5_Test
{
    class Program
    {
        static void Main(string[] args)
        {            
            var binaryTree = new MyBinaryTree(); 
            binaryTree.AddItem(50);
            binaryTree.AddItem(45);
            binaryTree.AddItem(58);
            binaryTree.AddItem(55);
            binaryTree.AddItem(90);
            binaryTree.AddItem(95);
            binaryTree.AddItem(80);
            binaryTree.AddItem(1);
            binaryTree.AddItem(49);

            Console.WriteLine("Бинароное дерево(Binary Tree):");

            binaryTree.PrintTree();

            Console.WriteLine("\n\nОбход в ширину(BFS):\n");

            binaryTree.BFS();

            Console.WriteLine("\n\nОбход в глубину(DFS):\n");

            binaryTree.DFS();

            Console.WriteLine("\n");
        }
    }
}
