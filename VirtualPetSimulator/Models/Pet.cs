using System;
using System.Collections.Generic;
using VirtualPetSimulator.Behaviors;
using VirtualPetSimulator.Observers;

namespace VirtualPetSimulator.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Energy { get; private set; }

        public IPlayBehavior PlayBehavior { get; set; }

        private readonly List<IPetObserver> observers = new List<IPetObserver>();

        public Pet(string name)
        {
            Name = name;
            Hunger = 50;
            Happiness = 50;
            Energy = 50;
        }

        private int ClampValue(int value)
        {
            if (value < 0) return 0;
            if (value > 100) return 100;
            return value;
        }

        public void ChangeHunger(int amount)
        {
            Hunger = ClampValue(Hunger + amount);
            NotifyObservers();
        }

        public void ChangeHappiness(int amount)
        {
            Happiness = ClampValue(Happiness + amount);
            NotifyObservers();
        }

        public void ChangeEnergy(int amount)
        {
            Energy = ClampValue(Energy + amount);
            NotifyObservers();
        }



        public void PerformPlay()
        {
            if (PlayBehavior == null) throw new InvalidOperationException("PlayBehavior not set.");
            PlayBehavior.Play(this);
        }

        public abstract void Feed();
        public abstract void Sleep();

        public void AddObserver(IPetObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IPetObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnPetStateChanged(this);
            }
        }
    }
}
