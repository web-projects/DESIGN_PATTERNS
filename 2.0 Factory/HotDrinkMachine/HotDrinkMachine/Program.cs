using System;

namespace HotDrinkMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            HotDrinkMachine machine = new HotDrinkMachine();
            Interfaces.IHotDrink drink = machine.MakeDrink();
        }
    }
}
