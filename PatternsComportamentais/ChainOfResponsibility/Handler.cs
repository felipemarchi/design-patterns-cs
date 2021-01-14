using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler sucessor { protected get; set; }

        public abstract void HandleRequest(int request);
    }
}
