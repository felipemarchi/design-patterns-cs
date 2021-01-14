using System;

namespace Flyweight
{
    class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = "Tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }
        public override void Mostra(string cor)
        {
            this.Cor = cor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
