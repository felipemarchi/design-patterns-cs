using System;

namespace Bridge
{
    public class Filme : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no Canal de Filmes";
        }

        public string Status()
        {
            return "Você está assitindo - Os Vingadores";
        }
    }
}
