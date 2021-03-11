using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
        void DFS(); //Поиск в глубину
        void BFS(); //Поиск в ширину

    }
}
