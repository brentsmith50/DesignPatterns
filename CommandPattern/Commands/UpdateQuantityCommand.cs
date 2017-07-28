using System;

namespace CommandPattern.Commands
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        #region Properties
        public int NewQuantity { get; set; }

        public string CommandName
        {
            get { return "Update Quantity"; }
        }

        public string Description
        {
           get { return "Update Quantity number"; }
        }
        #endregion

        #region Methods
        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            Console.WriteLine("LOG: Updated order quatity from {0} to {1}.", oldQuantity, NewQuantity);
        }

        public ICommand MakeCommand(string[] args)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(args[1]) };
        }
        #endregion
    }
}
