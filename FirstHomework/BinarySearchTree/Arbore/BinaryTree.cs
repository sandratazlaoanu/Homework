using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    public class BinaryTree
    {
        public List<Node> list;

        public BinaryTree()
        {
            list = new List<Node>();
        }

        public BinaryTree(List<int> nodes)
        {
            list = new List<Node>();
            foreach(int value in nodes)
            {
                Node node = new Node(value);
                if(list.Count() == 0)
                {
                    node.Root = null;
                    list.Add(node);
                }
                else {
                    AddNode(ref node);
                    list.Add(node);
                }
            }
        }

        virtual public void AddNode(ref Node el)
        {
            Node current;
            List<Node> queue = new List<Node>();
            queue.Add(list[0]);
            while (queue.Count > 0)
            {
                current = queue[0];
                queue.RemoveAt(0);
                if (current.Left == null)
                {
                    current.Left = el;
                    el.Root = current;
                    return;
                }

                if (current.Right == null)
                {
                    current.Right = el;
                    el.Root = current;
                    return;
                }

                queue.Add(current.Left);
                queue.Add(current.Right);

            }
        }

        public virtual bool DeleteNode(int value)
        {
            return true;
        }

        public Node GetNodeByValue(int value)
        {
            foreach(Node node in list)
            {
                if (node.Value == value)
                    return node;
            }
            return null;
        }

        public void Print()
        {
            foreach(Node node in list)
            {
                Console.WriteLine(node.ToString());
            }
        }
    }
}
