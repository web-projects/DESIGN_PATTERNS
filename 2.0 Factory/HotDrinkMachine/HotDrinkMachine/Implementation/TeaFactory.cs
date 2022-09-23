using HotDrinkMachine.Interfaces;
using System;

namespace HotDrinkMachine.Implementation
{
    class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
            return new Tea();
        }
    }
}
