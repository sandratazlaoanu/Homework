using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    public class Traversal
    {
        public static void RSD(List<Node> list, Node current)
        {
            Console.Write($"{current.Value}, ");
            if (current.Left != null)
                RSD(list, current.Left);
            if (current.Right != null)
                RSD(list, current.Right);
        }

        public static void SRD(List<Node> list, Node current)
        {
            if (current.Left != null)
                SRD(list, current.Left);
            Console.Write($"{current.Value}, ");
            if (current.Right != null)
                SRD(list, current.Right);
        }

        public static void SDR(List<Node> list, Node current)
        {
            if (current.Left != null)
                SDR(list, current.Left);
            if (current.Right != null)
                SDR(list, current.Right);
            Console.Write($"{current.Value}, ");
        }
    }
}
