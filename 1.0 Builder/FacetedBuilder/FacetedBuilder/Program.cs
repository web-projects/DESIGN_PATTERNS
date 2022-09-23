using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBuilder pb = new PersonBuilder();
            Person person = pb
                .Lives.At("123 London Road")
                    .In("London")
                    .WithPostCode("SW12AC")
                .Works.At("Fabrikm")
                    .AsA("Engineer")
                    .Earnings(123000);

            Console.WriteLine(person);
        }
    }
}
