using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Animals;
using Zoo.Cells;

namespace Zoo.Tests
{
    [TestClass]
    public class CageTests
    {
        [TestMethod]
        public void CanCreateSteelCage()
        {
            Cage cage = new SteelCage();
            Assert.IsNotNull(cage);
        }

        [TestMethod]
        public void CanCreateAquarium()
        {
            Cage cage = new Aquarium();
            Assert.IsNotNull(cage);
        }

        [TestMethod]
        public void CanAndAddMammalToSteelCage()
        {
            Cage cage = new SteelCage();
            Animal animal = new Dog(1)
            {
                Name = "Ciucia",

            };

            cage.PutAnimal(animal);

            Assert.IsNotNull(cage);
            Assert.IsTrue(cage.IsAnimal);
        }

        [TestMethod]
        public void CanFreeAddAndFreeMammalFromStealCage()
        {
            Cage cage = new SteelCage();
            Animal animal = new Dog(1)
            {
                Name = "Ciucia",                
            };

            cage.PutAnimal(animal);     
            cage.OpenDoor();

            Assert.IsNotNull(cage);
            Assert.IsFalse(cage.IsAnimal);
        }

        [TestMethod]
        public void CanSeeMammalsInCage()
        {
            Cage cage = new SteelCage();
            Animal animal = new Dog(1)
            {
                Name = "Ciucia",
                Coat = CoatType.Long
            };

            cage.PutAnimal(animal);
            var animalDetails = cage.ShowAnimal();

            Assert.IsFalse(string.IsNullOrEmpty(animalDetails));
        }

        [TestMethod]
        public void CanSeeReptilesInCage()
        {
            Cage cage = new SteelCage();
            Animal animal = new Lizard(1)
            {
                Name = "Lizzy",
                SkinColor = Color.AliceBlue
            };

            cage.PutAnimal(animal);
            var animalDetails = cage.ShowAnimal();

            Assert.IsFalse(string.IsNullOrEmpty(animalDetails));
        }
    }
}
