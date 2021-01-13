using System;

namespace Decorator
{
    //É o Decorador Abstrato
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca { get; set; }

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }

        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
