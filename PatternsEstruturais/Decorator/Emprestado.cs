using System;
using System.Collections.Generic;

namespace Decorator
{
    //É o Decorador Concreto
    public class Emprestado : Decorator
    {
        protected List<string> emprestados = new List<string>();

        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        public void EmprestarItem(string nome)
        {
            this.emprestados.Add(nome);
            this.itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            this.emprestados.Remove(nome);
            this.itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (string item in this.emprestados)
            {
                Console.WriteLine($"Emprestado: {item}");
            }
        }
    }
}
