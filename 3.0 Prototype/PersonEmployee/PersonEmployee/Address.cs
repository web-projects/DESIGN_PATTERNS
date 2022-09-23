namespace DesignPatternsPrototype
{
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address()
        {

        }

        public override string ToString()
        {
            return $"[{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}]";
        }
    }
}
