using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree()
        {
            list = new List<Node>();
        }

        public BinarySearchTree(List<int> nodes)
        {
            foreach (int value in nodes)
            {
                Node node = new Node(value);
                if (list.Count() == 0)
                {
                    node.Root = null;
                    list.Add(node);
                }
                else
                {
                    AddNode(ref node);
                    list.Add(node);
                }
            }
        }

        public override void AddNode(ref Node el)
        {
            Node current = list[0];
            while (true) {
                if (current.Left != null)
                {
                    while (el.Value < current.Value && current.Left != null)
                        current = current.Left;
                }

                if (current.Right != null)
                {
                    while (el.Value > current.Value && current.Right != null)
                        current = current.Right;
                }

                if (el.Value < current.Value && current.Left == null)
                {
                    el.Root = current;
                    current.Left = el;
                    return;
                }
                else if (el.Value > current.Value && current.Right == null)
                {
                    el.Root = current;
                    current.Right = el;
                    return;
                }
            }
        }

        public override bool DeleteNode(int value)
        {
            Node current = GetNodeByValue(value);

            if (current.Left == null && current.Right == null)
            {
                current = current.Root;
                if (current.Left.Value == value)
                {
                    list.Remove(current.Left);
                    current.Left = null;
                }
                else
                {
                    list.Remove(current.Right);
                    current.Right = null;
                }
                return true;
            }

            Console.WriteLine(current.Right.ToString());
            Node successor = GetSuccessor(current);
            if(successor == null)
                Console.WriteLine("null");
            if (successor == null)
            {
                list.Remove(current);
                Node newRoot;
                if (current.Root == null)
                {
                    newRoot = null;
                }
                else
                {
                    newRoot = current.Root;
                }

                current = current.Left;
                current.Root = newRoot;

                return true;
            }

            current.Value = successor.Value;
            Node parent;
            if (current.Root == null)
            {
                parent = null;
            }
            else
            {
                parent = current.Root;
            }
            if (successor.Right == null)
            {
                list.Remove(parent.Left);
                parent.Left = null;
                return true;
            }
            else
            {
                list.Remove(parent.Left);
                parent.Left = successor.Right;
                current = successor;
                current.Root = parent;
                return true;
            }
        }

        public Node GetSuccessor(Node el)
        {
            if (el.Right == null)
            {
                return null;
            }

            Node current = el.Right;

            while (current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        public Node GetMin()
        {
            Node current = list[0];

            while(current.Left != null)
            {
                current = current.Left;
            }

            return current;
        }

        public Node GetMax()
        {
            Node current = list[0];

            while (current.Right != null)
            {
                current = current.Right;
            }

            return current;
        }

    }
}