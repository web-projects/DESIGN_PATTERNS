namespace DesignPatternsPrototype
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public Address Address;

        public Person()
        {

        }

        public override string ToString()
        {
            return $"{nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Address)}: {Address}";
        }
    }
}
