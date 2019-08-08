using System;
using System.Linq;

namespace SecondOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string cities = "ROME,LONDON,NAIROBI,CALIFORNIA,ZURICH,NEW DELHI,AMSTERDAM,ABU DHABI,PARIS";
            string [] tempList = cities.Split(',');
            Console.WriteLine("First letter: ");
            string firstLetter = Console.ReadLine();
            Console.WriteLine("Last letter: ");
            string lastLetter = Console.ReadLine();
            var result = from element in tempList where (element.StartsWith(firstLetter) && element.EndsWith(lastLetter)) select element;
            Console.WriteLine($"The city starting with {firstLetter} and ending with {lastLetter} is {result.First().ToString()}");
        }
    }
}
