using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            List<Person> sortedByFirstName = new List<Person>();
            List<Person> sortedByLastName = new List<Person>();

            Person p1 = new Person("Filip", "Cezar", "Tudor Arghezi 12");
            Person p2 = new Person("Tazlaoanu", "Sandra", "Nicolae Titulescu 38A");
            Person p3 = new Person("Dordea", "Dragos", "Gloriei 20");
            Person p4 = new Person("Huma", "Horatiu", "Alexandru Sahia 20");
            Person p5 = new Person("Marcu", "Sanziana", "Minerva 17" );
            Person s1 = new Student("Rusen", "Andrei", "Scriitorilor 18", "1", 9.1);
            Person s2 = new Student("Stanciu", "Vlad", "Alexandru Vlahuta 43", "2", 7.8);
            Person s3 = new Student("Dorel", "Mirel", "Irelevant", "3", 5.9);


            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);
            personList.Add(p5);
            personList.Add(s1);
            personList.Add(s2);
            personList.Add(s3);

            sortedByFirstName = personList.OrderBy(x => x.FirstName).ToList();
            sortedByLastName = personList.OrderBy(x => x.LastName).ToList();

            Console.WriteLine("The alphabetically sorted list after first name: ");
            sortedByFirstName.ForEach(Console.WriteLine);


            Console.WriteLine();
            Console.WriteLine("The alphabetically sorted list after last name: ");
            sortedByLastName.ForEach(Console.WriteLine);
        }
    }
}
