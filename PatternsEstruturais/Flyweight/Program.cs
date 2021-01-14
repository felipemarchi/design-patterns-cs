using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---# DESIGN PATTERN FLYWEIGHT #---");

            var fabrica = new Fabrica_Flyweight();

            string cor = string.Empty;

            Tartaruga tartaruga;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para tela: ");

                cor = Console.ReadLine();

                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("--------------");
            }
        }
    }
}
