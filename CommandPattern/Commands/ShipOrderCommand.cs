using System;

namespace CommandPattern.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        #region Properties
        public string Name { get; set; }
        public string CommandName
        {
            get { return "ShipOrder"; }
        }

        public string Description
        {
            get { return "ShipOrder number"; }
        }
        #endregion

        #region Methods
        public void Execute()
        {
            // apparently not doing anything
        }

        public ICommand MakeCommand(string[] args)
        {
            return new ShipOrderCommand { Name = "Shipped success!" };
        }
        #endregion
    }
}
