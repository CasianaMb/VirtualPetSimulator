using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualPetSimulator; // Asigură-te că acest namespace corespunde cu cel al proiectului tău principal
using VirtualPetSimulator.Behaviors;
using VirtualPetSimulator.Models;



namespace TestVirtualPetSimulator
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void TestPlayIncreasesHappiness()
        {
            var pet = new Dog("Rex");
            pet.PlayBehavior = new PlayGentle(); // <-- Adăugat

            int initialHappiness = pet.Happiness;

            pet.Play();

            Assert.IsTrue(pet.Happiness > initialHappiness); // verifici că a crescut
        }


        [TestMethod]
        public void TestFeedDecreasesHunger()
        {
            var pet = new Dog("Rex");
            int initialHunger = pet.Hunger;

            pet.Feed();

            Assert.AreEqual(initialHunger - 10, pet.Hunger); // scade cu 10
        }

        [TestMethod]
        public void TestSleepRestoresEnergy()
        {
            var pet = new Dog("Rex");
            int initialEnergy = pet.Energy;

            pet.Sleep();

            Assert.IsTrue(pet.Energy > initialEnergy); // verifici că a crescut energia
        }

    }

}
