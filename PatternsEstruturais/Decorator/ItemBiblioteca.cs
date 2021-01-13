using System;

namespace Decorator
{
    public abstract class ItemBiblioteca
    {
        public int NumeroCopias { get; set; }

        public abstract void Exibe();
    }
}
