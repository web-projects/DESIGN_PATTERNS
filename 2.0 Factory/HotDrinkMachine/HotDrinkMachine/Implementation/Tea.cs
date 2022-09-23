﻿using HotDrinkMachine.Interfaces;
using System;

namespace HotDrinkMachine.Implementation
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}
