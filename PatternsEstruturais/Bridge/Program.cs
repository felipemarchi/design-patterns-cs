using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv minhaTv = new SmartTv();
            Console.WriteLine("SELECIONE UM CANAL");
            Console.WriteLine("1- Filmes\n2- Documentários\n3- Culunária");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    minhaTv.canal_atual = new Filme();
                    break;
                case '2':
                    minhaTv.canal_atual = new Documentario();
                    break;
                case '3':
                    minhaTv.canal_atual = new Culinaria();
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            minhaTv.ExibeCanalSintonizado();
            minhaTv.PlayTv();
        }
    }
}
