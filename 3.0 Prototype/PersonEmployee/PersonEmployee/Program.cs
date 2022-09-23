using System;

namespace DesignPatternsPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person()
            {
                FirstName = "John",
                LastName = "Smith",
                Address = new Address()
                {
                    StreetName = "London Road",
                    HouseNumber = 123
                }
            };

            Person jane = john.DeepCopyXml();
            jane.FirstName = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine($"{john}.");
            Console.WriteLine($"{jane}.");
        }
    }
}
