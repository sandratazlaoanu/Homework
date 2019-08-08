using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 15, 6, 3, 4, 18, 2, 7, 17, 13, 20, 9 };
            BinarySearchTree BSTree = new BinarySearchTree(list);
            while (true)
            {
                Console.WriteLine("1.Add 2.Delete 3.Print 4.RSD 5.SRD 6.SDR");
                String option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Insert a value for the new node");
                        int value = int.Parse(Console.ReadLine());
                        Node node = new Node(value);
                        BSTree.AddNode(ref node);
                        BSTree.list.Add(node);
                        break;
                    case "2":
                        Console.WriteLine("Type a key to delete");
                        int key = int.Parse(Console.ReadLine());
                        BSTree.DeleteNode(key);
                        break;
                    case "3":
                        BSTree.Print();
                        break;
                    case "4":
                        Traversal.RSD(BSTree.list, BSTree.list[0]);
                        Console.WriteLine();
                        break;
                    case "5":
                        Traversal.SRD(BSTree.list, BSTree.list[0]);
                        Console.WriteLine();
                        break;
                    case "6":
                        Traversal.SDR(BSTree.list, BSTree.list[0]);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
