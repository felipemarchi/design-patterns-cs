using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class Command
    {
        protected Receiver receiver;

        protected Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
