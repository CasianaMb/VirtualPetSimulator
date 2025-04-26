using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetSimulator.Models;


namespace VirtualPetSimulator.Behaviors
{
    public class PlayIntense : IPlayBehavior
    {
        public void Play(Pet pet)
        {
            pet.ChangeEnergy(-20);
            pet.ChangeHappiness(15);
            pet.ChangeHunger(15);
        }
    }
}


