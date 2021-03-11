using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson5
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

            Console.WriteLine("\n");

            Tuple<int>[] standartBFS;
            var listBFS = new List<Tuple<int>>(); // эталонный кортеж
            listBFS.Add(Tuple.Create(50));
            listBFS.Add(Tuple.Create(45));
            listBFS.Add(Tuple.Create(58));
            listBFS.Add(Tuple.Create(1));
            listBFS.Add(Tuple.Create(49));
            listBFS.Add(Tuple.Create(55));
            listBFS.Add(Tuple.Create(90));
            listBFS.Add(Tuple.Create(80));
            listBFS.Add(Tuple.Create(95));
            standartBFS = listBFS.ToArray();

            NodeInfo[] binaryArrayBFS;
            binaryArrayBFS = TreeHelperBFS.GetTreeInLine(binaryTree);

            var validateBFS = new Tuple<int>[binaryArrayBFS.Length]; // кортеж дя проверки

            Console.WriteLine("Обход в ширину(BFS):\n");

            binaryTree.BFS();

            Console.WriteLine("\n\nBFS тест вывод:\n");
            for (int i = 0; i < binaryArrayBFS.Length; i++)
            {
                int depth = binaryArrayBFS[i].Depth;
                int value = binaryArrayBFS[i].Node.Value;
                validateBFS[i] = new Tuple<int>(value);
                validateBFS.ToArray();
            }

            for (int i = 0; i < validateBFS.Length; i++)
            {
                if (i == validateBFS.Length - 1)
                {
                    Console.Write($"№{i + 1} -> {validateBFS[i]}");
                }
                else
                {
                    Console.Write($"№{i + 1} -> {validateBFS[i]}, ");
                }
            }

            Console.WriteLine("\n");

            Tuple<int>[] standartDFS;
            var listDFS = new List<Tuple<int>>(); // эталонный кортеж
            listDFS.Add(Tuple.Create(50));
            listDFS.Add(Tuple.Create(45));
            listDFS.Add(Tuple.Create(1));
            listDFS.Add(Tuple.Create(49));
            listDFS.Add(Tuple.Create(58));
            listDFS.Add(Tuple.Create(55));
            listDFS.Add(Tuple.Create(80));
            listDFS.Add(Tuple.Create(90));
            listDFS.Add(Tuple.Create(95));
            standartDFS = listDFS.ToArray();

            NodeInfo[] binaryArrayDFS;
            binaryArrayDFS = TreeHelperDFS.GetTreeInLine(binaryTree);

            var validateDFS = new Tuple<int>[binaryArrayDFS.Length]; // кортеж дя проверки

            Console.WriteLine("\nОбход в глубину(DFS):\n");

            binaryTree.DFS();

            Console.WriteLine("\n\nDFS тест на соответсвие:\n");
            for (int i = 0; i < binaryArrayDFS.Length; i++)
            {
                int value = binaryArrayDFS[i].Node.Value;
                listDFS.Add(Tuple.Create(value));
                validateDFS[i] = new Tuple<int>(value);
                validateDFS.ToArray();
            }

            for (int i = 0; i < validateDFS.Length; i++)
            {
                if (i == validateDFS.Length - 1)
                {
                    Console.Write($"№{i + 1} -> {validateDFS[i]}");
                }
                else
                {
                    Console.Write($"№{i + 1} -> {validateDFS[i]}, ");
                }

            }

            Console.Write("\n");
        }
    }
}
