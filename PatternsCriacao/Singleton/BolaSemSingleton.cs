using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class BolaSemSingleton
    {
        public BolaSemSingleton()
        {
            Console.WriteLine("Bola em Jogo!");
        }
        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
