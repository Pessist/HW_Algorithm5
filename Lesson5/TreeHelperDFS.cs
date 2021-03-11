using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class TreeHelperDFS
    {
        public static NodeInfo[] GetTreeInLine(ITree tree)
        {
            var bufer = new Stack<NodeInfo>();
            var returnArray = new List<NodeInfo>();
            var root = new NodeInfo() { Node = tree.GetRoot() };
            bufer.Push(root);

            while (bufer.Count != 0)
            {
                var element = bufer.Pop();
                returnArray.Add(element);

                var depth = element.Depth + 1;

                if (element.Node.RightChild != null)
                {
                    var left = new NodeInfo()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                    };
                    bufer.Push(left);
                }
                if (element.Node.LeftChild != null)
                {
                    var right = new NodeInfo()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                    };
                    bufer.Push(right);
                }
            }

            return returnArray.ToArray();
        }
    }
}
