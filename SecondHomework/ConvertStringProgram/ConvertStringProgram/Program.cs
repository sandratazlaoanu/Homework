using System;
using System.IO;
using System.Linq;

namespace ConvertStringProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFile = @"C:/Users/ST073494/Learning/C#/Workspace/ConvertStringProgram/ConvertStringProgram/input.txt";

            string[] content = File.ReadAllLines(myFile);
            var input = content.SelectMany(line => line.Split(' '));

            string output = string.Join(", ", content);
            Console.WriteLine(output);
        }
    }
}
