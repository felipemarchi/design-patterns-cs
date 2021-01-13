using System;

namespace Bridge
{
    public class SmartTv
    {
        // Bridge
        public ICanal canal_atual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (canal_atual != null)
            {
                Console.WriteLine(canal_atual.Canal());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal!");
            }
        }

        public void PlayTv()
        {
            if (canal_atual != null)
            {
                Console.WriteLine(canal_atual.Status());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal, para assistir algo!");
            }
        }
    }
}
