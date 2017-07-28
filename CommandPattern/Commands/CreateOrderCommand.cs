using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        #region Properties

        public string CommandName
        {
            get { return "Create Order"; }
        }

        public string Description
        {
            get { return CommandName + " description"; }
        }
        #endregion

        #region Methods
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public ICommand MakeCommand(string[] args)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
