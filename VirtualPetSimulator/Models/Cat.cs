using System;

namespace VirtualPetSimulator.Models
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name) { }

        public override void Feed()
        {
            ChangeHunger(-15);
        }

        public override void Sleep()
        {
            ChangeEnergy(10);
        }

        public void Play() => PerformPlay();

    }
}
