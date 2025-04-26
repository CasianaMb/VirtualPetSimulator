using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetSimulator.Models;

namespace VirtualPetSimulator.Observers
{
    public class ConsolePetObserver : IPetObserver
    {
        public void OnPetStateChanged(Pet pet)
        {
            Console.WriteLine($"[{pet.Name}] Status updated -> Hunger: {pet.Hunger}, Energy: {pet.Energy}, Happiness: {pet.Happiness}");
        }
    }
}