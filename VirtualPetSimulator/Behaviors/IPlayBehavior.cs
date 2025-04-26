using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VirtualPetSimulator.Models;

namespace VirtualPetSimulator.Behaviors
{
    public interface IPlayBehavior
    {
        void Play(Pet pet);
    }
}
