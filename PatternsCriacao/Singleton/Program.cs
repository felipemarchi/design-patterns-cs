using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UsandoSingleton();
            Console.WriteLine("\n");
            UsandoMetodoTradicional();
        }

        public static void UsandoSingleton()
        {
            BolaComSingleton jogador_1 = BolaComSingleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio de campo");

            BolaComSingleton jogador_2 = BolaComSingleton.GetInstancia;
            jogador_2.Mensagem("Jogador2: recebeu a bola");

            BolaComSingleton jogador_3 = BolaComSingleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo");
        }

        public static void UsandoMetodoTradicional()
        {
            BolaSemSingleton jogador_1 = new BolaSemSingleton();
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio de campo");

            BolaSemSingleton jogador_2 = new BolaSemSingleton();
            jogador_2.Mensagem("Jogador2: recebeu a bola");

            BolaSemSingleton jogador_3 = new BolaSemSingleton();
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo");
        }
    }
}
