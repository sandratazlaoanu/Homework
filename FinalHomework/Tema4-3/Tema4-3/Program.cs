using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"C:\Users\ST073494\Learning\C#\Workspace\Tema4-3\Tema4-3\Input.txt");
            string[] inputStringVect = input.Split(' ');
            int[] vector = new int[inputStringVect.Length];
            int i = 0, count = 0;
            foreach (string number in inputStringVect)
            {
                vector[i++] = Int32.Parse(number);
            }
            for (i = 0; i < vector.Length; i++)
            {
                if (vector[i] != 0)
                {
                    vector[count++] = vector[i];
                }
            }
            while (count < vector.Length)
            {
                vector[count++] = 0;
            }

            foreach (int number in vector)
            {
                Console.Write(number + " ");
            }
        }
    }
}
