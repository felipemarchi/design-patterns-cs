using System;

namespace Command
{
    public class Invoker
    {
        public Command command { private get; set; }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}
