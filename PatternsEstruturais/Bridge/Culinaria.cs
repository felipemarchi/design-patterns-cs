using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no Canal de Culinária";
        }

        public string Status()
        {
            return "Você está assitindo - Receita de Bolo de Chocolate";
        }
    }
}
