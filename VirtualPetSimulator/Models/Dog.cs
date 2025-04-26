using System;

namespace VirtualPetSimulator.Models
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name) { }

        public override void Feed()
        {
            ChangeHunger(-10);
            ChangeEnergy(2); 
        }

        public override void Sleep()
        {
            ChangeEnergy(10);
        }

        // Use strategy
        public void Play() => PerformPlay();

        
    }
}
