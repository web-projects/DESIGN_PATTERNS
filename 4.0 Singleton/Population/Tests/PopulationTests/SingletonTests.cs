using DesignPatterns.Implementation;
using Xunit;

namespace PopulationTests
{
    public class SingletonTests
    {
        [Fact]
        public void IsSingleTonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;

            Assert.Equal(db, db2);
            Assert.Equal(1, SingletonDatabase.Count);
        }
    }
}