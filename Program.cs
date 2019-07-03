using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet AllYouCanEat = new Buffet();
            SweetTooth Dave = new SweetTooth("Dave");
            SpiceHound Rick = new SpiceHound("Rick");
            IConsumable item = AllYouCanEat.Serve();
            Dave.Consume(item);
            Dave.Consume(item);
            Dave.Consume(item);
            Dave.Consume(item);
            Dave.Consume(item);
            Rick.Consume(item);
            Rick.Consume(item);
            Rick.Consume(item);
            Rick.Consume(item);
            Rick.Consume(item);
            if(Dave.ConsumptionHistory.Count > Rick.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Dave consumed {Dave.ConsumptionHistory.Count} items but Rick only had {Rick.ConsumptionHistory.Count}.");
            }
            else if(Rick.ConsumptionHistory.Count > Dave.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Rick consumed {Rick.ConsumptionHistory.Count} items but Dave only had {Dave.ConsumptionHistory.Count}.");
            }
        }
    }
}
