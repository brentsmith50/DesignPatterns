using StrategyPatternVariation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Order, double> fedExStrategy = CalculateFedExCost;
            Func<Order, double> upsStrategy = delegate (Order order) { return 7.25d; };
            Func<Order, double> uspsStrategy = order => 6.33d;

            Order anOrderThatDoesNothing = InitializeOrders.CreateOrder();

            var calculatorService = new ShippingService.ShippingCostCalculatorService();

            Console.WriteLine("FedEx shipping cost: " +
                calculatorService.CalculateShippingCost(anOrderThatDoesNothing, fedExStrategy));

            Console.WriteLine("UPS shipping cost: " +
                calculatorService.CalculateShippingCost(anOrderThatDoesNothing, upsStrategy));

            Console.WriteLine("USPS shipping cost: " +
                calculatorService.CalculateShippingCost(anOrderThatDoesNothing, uspsStrategy));

            Console.ReadKey();
        }

        private static double CalculateFedExCost(Order fedexOrder)
        {
            return 5.00d;
        }
    }
}
