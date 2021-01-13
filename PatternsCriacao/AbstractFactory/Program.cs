using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.montarCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.montarCarro("popular");
        }
    }
}
