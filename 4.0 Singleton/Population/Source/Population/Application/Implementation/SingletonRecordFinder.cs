using DesignPatterns.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Population.Implementation
{
    public class SingletonRecordFinder
    {
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;

            foreach(string name in names)
            {
                result += SingletonDatabase.Instance.GetPopulation(name);
            }

            return result;
        }
    }
}
