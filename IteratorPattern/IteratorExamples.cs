using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class IteratorExamples
    {
        public void ArrayIteration()
        {
            var stocks = new[] { "MSFT", "GOOG", "AAPL" };
            for (int i = 0; i < stocks.Length; i++)
            {
                Console.WriteLine(stocks[i]);
            }
            Console.ReadLine();
        }
    }
}
