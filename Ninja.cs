using System;
using System.Collections.Generic;

namespace HungryNinja
{
    abstract class Ninja
    {
        public string Name;
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public abstract bool IsFull
        {
            get;
        }
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract void Consume(IConsumable item);
    }
}
