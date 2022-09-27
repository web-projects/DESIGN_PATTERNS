using DesignPatterns.Implementation;
using DesignPatterns.Interfaces;
using Moq;
using Population.Implementation;
using System.Collections.Generic;
using TestHelper;
using Xunit;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace PopulationTests
{
    public class SingletonRecordFinderTests
    {
        private readonly Mock<IDatabase> mockDatabase;
        private readonly SingletonRecordFinder subject;

        public SingletonRecordFinderTests()
        {
            mockDatabase = new Mock<IDatabase>();
            subject = new SingletonRecordFinder();
        }

        [Fact]
        public void GetTotalPopulation_Adds_AllPopulation_Count_AsExpected()
        {
            var rf = new SingletonRecordFinder();
            string[] names = new[] { "Seoul", "Mexico City" };
            int tp = rf.GetTotalPopulation(names);

            Assert.Equal(tp, (175 + 174));

        }

        [Theory]
        [InlineData("alpha", 1)]
        [InlineData("beta", 2)]
        [InlineData("gamma", 3)]
        public void ConfigurableRecordFinder_GetPopulationFromDummyDB(string capitalName, int expectedCount)
        {
            Dictionary<string, int> capitals = new Dictionary<string, int>()
            {
                { capitalName, expectedCount }
            };

            Helper.SetFieldValueToInstance<Dictionary<string, int>>("Capitals", false, false, SingletonDatabase.Instance, capitals);
            Dictionary<string, int> validator = Helper.GetFieldValueFromInstance<Dictionary<string, int>>("Capitals", false, false, SingletonDatabase.Instance);
            Assert.Equal(capitals, validator);

            var rf = new ConfigurableRecordFinder(mockDatabase.Object);
            int tp = rf.GetPopulation(capitalName);
       
            Assert.Equal(tp, expectedCount);
        }
    }
}
