using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;     
        }

        internal ICommand ParseCommand(string[] args)
        {
            string requestedCommandName = args[0];
            ICommandFactory command = FindRequestedCommand(requestedCommandName);
            if (command == null)
            {
                return new NotFoundCommand { Name = requestedCommandName };
            }
            return command.MakeCommand(args);
        } 

        ICommandFactory FindRequestedCommand(string commandName)
        {
            return availableCommands.FirstOrDefault(c => c.CommandName == commandName);
        }
    }
}
