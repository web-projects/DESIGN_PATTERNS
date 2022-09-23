using HotDrinkMachine.Interfaces;
using System;

namespace HotDrinkMachine.Implementation
{
    class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
