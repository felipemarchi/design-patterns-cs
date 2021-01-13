using System;

namespace Composite
{
    public abstract class Componente
    {
        protected string nome { get; set; }
        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente c);

        public abstract void Remover(Componente c);

        public abstract void Mostrar(int profundidade);
    }
}
