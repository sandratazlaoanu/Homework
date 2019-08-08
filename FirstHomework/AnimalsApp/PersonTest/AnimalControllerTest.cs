using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalDemo;
using Moq;
using System.Linq;

namespace PersonTest
{
    /// <summary>
    /// Summary description for PersonControllerTest
    /// </summary>
    [TestClass]
    public class AnimalControllerTest
    {
        [TestMethod]
        public void GetData_Test()
        {
            Mock<IAnimalRepository> repoMock = new Mock<IAnimalRepository>();

            Animal firstAnimal = new Animal
            {
                Id = 1,
                Name = "Bobita",
                Description = "Cat"
            };
            
            AnimalController controller = new AnimalController(repoMock.Object);

            Animal first = controller.GetById(1);

            repoMock.Setup(x => x.Add(firstAnimal));

            repoMock.Setup(x => x.GetById(1)).Returns(firstAnimal);

            Assert.AreEqual("Bobita", first.Name);
            Assert.AreEqual("Cat", first.Description);
            Assert.AreEqual(1, first.Id);

        }

        [TestMethod]
        public void GetAllData_Test()
        {
            Mock<IAnimalRepository> repoMock = new Mock<IAnimalRepository>();


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

            List<Animal> personList = new List<Animal>
            {
                firstAnimal,
                secondAnimal
            };

            repoMock.Setup(x => x.GetAll()).Returns(personList);

            AnimalController animalController = new AnimalController(repoMock.Object);
            List<Animal> result = animalController.GetAll().ToList();

            Assert.AreEqual(2, result.Count);
        }
    }
}
