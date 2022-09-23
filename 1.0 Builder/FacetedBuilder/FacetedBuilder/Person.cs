using System.Text;

namespace DesignPatterns
{
    public class Person
    {
        public string Name;

        public string StreetAddress;
        public string PostCode;
        public string City;

        public string CompanyName;
        public string Position;
        public int AnnualIncome;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder()
                .Append($"{nameof(StreetAddress)}: {StreetAddress}, ")
                .Append($"{nameof(PostCode)}: {PostCode}, ")
                .Append($"{nameof(City)}: {City}\r\n")
                .Append($"{nameof(CompanyName)}:{CompanyName}, ")
                .Append($"{nameof(Position)}: {Position}, ")
                .Append($" {nameof(AnnualIncome)}: {AnnualIncome}");
            return sb.ToString();
        }
    }
}
