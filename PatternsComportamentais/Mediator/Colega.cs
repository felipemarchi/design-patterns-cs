using System;

namespace Mediator
{
    public abstract class Colega
    {
        protected Mediador mediador;

        public Colega(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}
