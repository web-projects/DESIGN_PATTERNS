using DesignPatterns.Implementation;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDatabase db = SingletonDatabase.Instance;
            string city = "Tokyo";

            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }
}
