using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tema4_4
{
    class Program
    {
        public static int NumberOfOccurences(string inputString, Stream stream)

        {

            if (string.IsNullOrEmpty(inputString))

            {

                throw new ArgumentNullException(nameof(inputString));

            }

            if (stream == null)

            {

                throw new ArgumentNullException(nameof(stream));

            }



            if (!stream.CanRead)

            {

                throw new ArgumentException("Stream cannot be read");

            }

            StreamReader reader = new StreamReader(stream);
            var lines = new List<string>();
            int count = 0;
            while (!reader.EndOfStream)
            {
                string text = reader.ReadLine();
                lines.Add(text);
            }
            foreach (string line in lines)
            {
                count += Regex.Matches(line, inputString).Cast<Match>().Count();

            }
            return count;

        }

        static void Main(string[] args)
        {
            var inputTest = "abc";

            // Insert text here
            var text = "abcTeST\n this is abc a test\n abcyes";

            var stream = new StreamReader(new MemoryStream(Encoding.ASCII.GetBytes(text)));
            Console.WriteLine(NumberOfOccurences(inputTest, stream.BaseStream));
        }
    }
}
