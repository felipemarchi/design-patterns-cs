using System;

namespace Singleton
{
    public sealed class BolaComSingleton
    {
        private static BolaComSingleton instancia = null;

        public static BolaComSingleton GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new BolaComSingleton();
                    Console.WriteLine("Bola em Jogo!");
                }

                return instancia;

            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
