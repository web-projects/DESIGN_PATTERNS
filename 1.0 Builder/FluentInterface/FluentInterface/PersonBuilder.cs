using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentInterface
{
    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name)
            => Do(p => p.Name = name);

        //private readonly List<Func<Person, Person>> actions
        //    = new List<Func<Person, Person>>();

        //private PersonBuilder AddAction(Action<Person> action)
        //{
        //    actions.Add(p =>
        //    {
        //        action(p);
        //        return p;
        //    });

        //    return this;
        //}

        //public PersonBuilder Called(string name)
        //    => Do(p => p.Name = name);

        //public PersonBuilder Do(Action<Person> action)
        //    => AddAction(action);

        //public Person Build()
        //    => actions.Aggregate(new Person(), (p, f) => f(p));
    }
}
