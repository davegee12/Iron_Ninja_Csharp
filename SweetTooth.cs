using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get { return calorieIntake >= 1500; }
        }
        public SweetTooth(string name) : base (name){}
        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                if(item.IsSweet == true)
                {
                    calorieIntake += (item.Calories + 10);
                    ConsumptionHistory.Add(item);
                    Console.WriteLine(item.GetInfo());
                }
                else
                {
                    calorieIntake += item.Calories;
                    ConsumptionHistory.Add(item);
                    Console.WriteLine(item.GetInfo());
                }
            }
            else
            {
                Console.WriteLine($"{Name} is too full! If they eat anymore they will explode!!!!!");
            }
        }
    }
}
