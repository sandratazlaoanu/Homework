using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalDemo
{

    public class AnimalRepository : IAnimalRepository
    {
        readonly List<Animal> _animals = new List<Animal>();
        public void Add(Animal a)
        {
            _animals.Add(a);
        }

        public Animal GetById(int id)
        {
            return _animals.SingleOrDefault(x => x.Id == id);
        }

        public List<Animal> GetAll() => _animals;

        public void Delete(int id)
        {
            _animals.RemoveAll(x => x.Id == id);
        }

        public void Update(int id, string newName, string newDescription)
        {
            (from x in _animals
             where x.Id == id
             select x).ToList().ForEach(a =>
             {
                 a.Name = newName;
                 a.Description = newDescription;
             });
        }
        public void ShowAll()
        {
          
                Console.WriteLine(_animals);
 
        }

    }
}
