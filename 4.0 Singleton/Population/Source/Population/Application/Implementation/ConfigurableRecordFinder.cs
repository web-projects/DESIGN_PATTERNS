using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace Population.Implementation
{
    public class ConfigurableRecordFinder
    {
        private readonly IDatabase database;

        public ConfigurableRecordFinder(IDatabase db) 
            => (database) = (db);

        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["alpha"] = 1,
                ["beta"] = 2,
                ["gamma"] = 3
            }[name];
        }
    }
}
