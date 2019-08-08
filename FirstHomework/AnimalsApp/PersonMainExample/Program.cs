using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalDemo;

namespace PersonMainExample
{
    class Program
    {
        static void Main(string[] args)
        {
             Animal first = new Animal
            {
                Id = 1,
                Name = "Bobita",
                Description = "Cat"
            };
            Animal second = new Animal
            {
                Id = 2,
                Name = "Rex",
                Description = "Dog"
            };
            Animal third = new Animal
            {
                Id = 3,
                Name = "Kitty",
                Description = "Cat"
            };
            Animal fourth = new Animal
            {
                Id = 4,
                Name = "Daisy",
                Description = "Parrot"
            };
            Animal fifth = new Animal
            {
                Id = 5,
                Name = "Max",
                Description = "Dog"
            };


            AnimalRepository repo = new AnimalRepository();

            repo.Add(first);
            repo.Add(second);
            repo.Add(third);
            repo.Add(fourth);
            repo.Add(fifth);

            Animal firstAnimal = repo.GetById(1);
            Animal secondAnimal = repo.GetById(2);

            IEnumerable<Animal> animalList = repo.GetAll();

            Console.WriteLine(first);
            Console.WriteLine(second);

            Console.WriteLine("Before update: ");
            foreach (var a in animalList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("After update: ");

            repo.Update(1, "Mickey", "Mouse");

            foreach (var a in animalList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("After removing nr. 4 : ");

            repo.Delete(4);

            foreach (var a in animalList)
            {
                Console.WriteLine(a);
            }

            Tiger tiger = new Tiger();
        }
    }
}


