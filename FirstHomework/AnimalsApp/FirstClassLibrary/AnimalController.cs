using System;
using System.Collections.Generic;

namespace AnimalDemo
{
    public class AnimalController
    {
        readonly IAnimalRepository _animalRepository;

        public AnimalController(AnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public AnimalController()
        {
            _animalRepository = new AnimalRepository();
        }

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void Insert(Animal a)
        {
            _animalRepository.Add(a);
        }
        public Animal GetById(int id)
        {
            return _animalRepository.GetById(id);
        }

        public void Delete(Animal a)
        {
            _animalRepository.Delete(a.Id);
        }
        public void Update(Animal a, string newName, string newDescription)
        {
            _animalRepository.Update(a.Id, newName, newDescription);
        }
        public IEnumerable<Animal> GetAll()
        {
            return _animalRepository.GetAll();
        }
    }
}
