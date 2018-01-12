using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Animals;

namespace Zoo.Tests
{
    [TestClass]
    public class AnimalsTests
    {
        [TestMethod]
        public void DogCanBark()
        {
            // assign
            Animal animal = new Dog(3);

            // act
            var sound = animal.SpreadTheSound();

            // assert
            Assert.AreEqual("bark bark", sound);
        }

        [TestMethod]
        public void HorseCanIhaha()
        {
            // assign
            Animal animal = new Horse(3);
            
            // act
            var sound = animal.SpreadTheSound();

            // assert
            Assert.AreEqual("I ma horse IHAHA!", sound);
        }

        [TestMethod]
        public void LizardCanLizzz()
        {
            // assign
            Animal animal = new Lizard(3);

            // act
            var sound = animal.SpreadTheSound();

            // assert
            Assert.AreEqual("I am Lizzzard... ", sound);
        }

        [TestMethod]
        public void SnakeCanSsssss()
        {
            // assign
            Animal animal = new Snake(3);

            // act
            var sound = animal.SpreadTheSound();

            // assert
            Assert.AreEqual("I am ssssssnakee... sssss...", sound);
        }
    }
}
