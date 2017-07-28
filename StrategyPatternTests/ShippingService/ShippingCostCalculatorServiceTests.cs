using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPatternTests.ShippingService;

namespace StrategyPattern.ShippingService.Tests
{
    [TestClass()]
    public class ShippingCostCalculatorServiceTests
    {
        [TestMethod()]
        public void CalculateShippingCostForFedExTest()
        {
            var strategy = new FedExShippingCostStrategy();
            // This is the core to this design pattern:
            // The service accepts any concrete type that implements IShippingCostStrategy
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = InitializeOrders.CreateFedExOrder();
            // this Encapsulates the IShippingCostStrategy by passing it into the method doing the work
            // and returning the value via this method
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(5.00d, cost);
        }

        [TestMethod()]
        public void CalculateShippingCostForUSPSTest()
        {
            var strategy = new USPSShippingCostStrategy();
            // This is the core to this design pattern:
            // The service accepts any concrete type that implements IShippingCostStrategy
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = InitializeOrders.CreateUSPSOrder();
            // this Encapsulates the IShippingCostStrategy by passing it into the method doing the work
            // and returning the value via this method
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(3.00d, cost);
        }

        [TestMethod()]
        public void CalculateShippingCostForUPSTest()
        {
            var strategy = new UPSShippingCostStrategy();
            // This is the core to this design pattern:
            // The service accepts any concrete type that implements IShippingCostStrategy
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = InitializeOrders.CreateUPSOrder();
            // this Encapsulates the IShippingCostStrategy by passing it into the method doing the work
            // and returning the value via this method
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(4.25d, cost);
        }
    }
}