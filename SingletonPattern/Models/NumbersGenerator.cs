using System.Collections.Generic;

namespace SingletonPattern.Models
{
    internal class NumbersGenerator
    {
        public IEnumerable<long> Integers()
        {
            long currentValue = 1;
            while (true)
            {
                yield return currentValue++;
            }
        }
    }
}