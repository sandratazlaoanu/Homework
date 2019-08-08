using System;
using AnimalDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonTest
{
    [TestClass]
    public class AnimalDataTest
    {
        Animal firstAnimal = new Animal
        {
            Id = 1,
            Name = "Bobita",
            Description = "Cat"
        };
        Animal secondAnimal = new Animal
        {
            Id = 2,
            Name = "Rex",
            Description = "Dog"
        };
        [TestMethod]

        public void RetrieveCorrectData_Test()
        {
            AnimalRepository repo = new AnimalRepository();
            repo.Add(firstAnimal);
            repo.Add(secondAnimal);
            Animal first = repo.GetById(1);
            Animal second = repo.GetById(2);

            Assert.AreEqual("Bobita", first.Name);
            Assert.AreEqual("Cat", first.Description);
            Assert.AreEqual(1, first.Id);

        }

        [TestMethod]

        public void RetrieveInvalidData_Test()
        {
            AnimalRepository repo = new AnimalRepository();
            repo.Add(firstAnimal);
            repo.Add(secondAnimal);
            Animal first = repo.GetById(1);
            Animal second = repo.GetById(2);

            Assert.AreEqual("Bobita", first.Name);
            Assert.AreEqual("Cat", first.Description);
            Assert.AreEqual(3, first.Id);
        }
    }
}
