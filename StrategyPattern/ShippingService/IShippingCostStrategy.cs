namespace StrategyPattern.ShippingService
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
