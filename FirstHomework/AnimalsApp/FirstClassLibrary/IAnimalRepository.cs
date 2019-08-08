using System.Collections.Generic;

namespace AnimalDemo
{
    public interface IAnimalRepository
    {
        void Add(Animal a);

        void Delete(int id);

        void Update(int id, string newName, string newDescription);

        Animal GetById(int id);

        List<Animal> GetAll();
    }
}
