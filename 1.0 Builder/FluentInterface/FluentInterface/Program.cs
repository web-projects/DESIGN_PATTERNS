using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new PersonBuilder()
                .Called("Sarah")
                .WorksAs("Developer")
                .Build();

            Console.WriteLine($"{person.Name} is a {person.Position}.");
        }
    }
}
