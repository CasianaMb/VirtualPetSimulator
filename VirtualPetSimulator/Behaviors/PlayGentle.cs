using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetSimulator.Models;


namespace VirtualPetSimulator.Behaviors
{
    public class PlayGentle : IPlayBehavior
    {
        public void Play(Pet pet)
        {
            pet.ChangeEnergy(-5);
            pet.ChangeHappiness(8);
            pet.ChangeHunger(5);
        }
    }
}
