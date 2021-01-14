using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public abstract class Tartaruga
    {
        protected string condicao;
        protected string acao;
        public string Cor { get; set; }

        public abstract void Mostra(string cor);
    }
}
