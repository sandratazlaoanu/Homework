using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    public class Node
    {
        public Node()
        {
            Value = 0;
            Left = null;
            Right = null;
            Root = null;
        }

        public Node(int value)
        {
            this.Value = value;
            Left = null;
            Right = null;
        }
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Root { get; set; }

        public int TestNullable(Node el)
        {
            if(el == null)
            {
                return -1;
            }

            return el.Value;
        }
        
        public override string ToString()
        {
            return $"Node info: [val:{Value}, left:{TestNullable(Left)}, right:{TestNullable(Right)}, root:{TestNullable(Root)}]";
        }
    }
}
