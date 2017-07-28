using System;

namespace CommandPattern.Commands
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("The command {0} could not be found.", Name);
        }
    }
}
