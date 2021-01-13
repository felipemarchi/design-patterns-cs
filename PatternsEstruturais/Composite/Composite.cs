using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Componente
    {
        private List<Componente> filhos = new List<Componente>();
        public Composite(string nome)
            : base(nome)
        {

        }

        public override void Adicionar(Componente c)
        {
            this.filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (Componente item in this.filhos)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(Componente c)
        {
            this.filhos.Remove(c);
        }
    }
}
