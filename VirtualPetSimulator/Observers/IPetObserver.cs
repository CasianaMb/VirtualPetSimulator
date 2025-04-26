using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetSimulator.Models;

namespace VirtualPetSimulator.Observers
{
    public interface IPetObserver
    {
        void OnPetStateChanged(Pet pet);
    }
}
