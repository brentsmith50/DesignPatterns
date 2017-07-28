namespace StrategyPatternVariation.Models
{
    public static class InitializeOrders
    {
        #region Orders
        public static Order CreateOrder()
        {
            return new Order
            {
                Destination = InitializeOrders.CreateDestinationAddress(),
                Origin = InitializeOrders.CreateOriginAddress()
            };
        }
        #endregion

        #region Addresses
        public static Address CreateOriginAddress()
        {
            return new Address()
            {
                ContactName = "David Starr",

                AddressLine1 = "185 Lincoln St.",
                AddressLine2 = "Suite 305",
                AddressLine3 = null,
                City = "Hingham",
                Country = "U.S.",
                Region = "MA",
                PostalCode = "02043-1741"
            };
        }

        public static Address CreateDestinationAddress()
        {
            return new Address()
            {
                ContactName = "Homer Simpson",

                AddressLine1 = "123 Elm",
                AddressLine2 = null,
                AddressLine3 = null,
                City = "Springfield",
                Country = "U.S.",
                Region = "Iowa",
                PostalCode = "11111"
            };
        }
        #endregion
    }
}
