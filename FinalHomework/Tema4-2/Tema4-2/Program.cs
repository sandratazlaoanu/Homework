using System;
using System.Collections.Generic;
using System.IO;


namespace Tema3Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"C:\Users\ST073494\Learning\C#\Workspace\Tema4-2\Tema4-2\Input.txt");
            int i = 0;
            string[] firstString = input[0].Split();
            string[] secondString = input[1].Split();

            int[] firstArray = new int[firstString.Length];
            foreach (string nr in firstString)
            {
                firstArray[i] = Int32.Parse(nr);
                i++;
            }

            i = 0;
            int[] secondArray = new int[secondString.Length];
            foreach (string nr in secondString)
            {
                secondArray[i] = Int32.Parse(nr);
                i++;
            }

            i = 0;
            int j = 0, k = 0;
            int[] res = new int[firstString.Length + secondString.Length];
            while (i < firstString.Length && j < secondString.Length)
            {
                if (firstArray[i] <= secondArray[j])
                {
                    res[k++] = firstArray[i++];
                }
                else
                {
                    res[k++] = secondArray[j++];
                }


            }
            while (i < firstString.Length)
            {
                res[k++] = firstArray[i++];
            }
            while (j < secondString.Length)
            {
                res[k++] = secondArray[j++];
            }

            foreach (int number in res)
            {
                Console.Write(number + " ");

            }
        }

    }

}

