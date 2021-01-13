using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanqueRx2021 = new TanqueInimigo();

            RoboInimigo r2d2 = new RoboInimigo();

            IAtaqueInimigo r2d2Adaptado = new RoboInimigoAdapter(r2d2);

            Console.WriteLine(" ===== ROBO ===== ");
            r2d2.ReagirContraHumano("Rodrigo");
            r2d2.AndarFrente();
            r2d2.EsgamarComMaos();

            Console.WriteLine("\n");

            Console.WriteLine(" ===== TANQUE ===== ");
            tanqueRx2021.Pilotar("João");
            tanqueRx2021.Movimenta();
            tanqueRx2021.ArmaFogo();

            Console.WriteLine("\n");

            Console.WriteLine(" ===== ROBO ADAPATDO ===== ");
            r2d2Adaptado.Pilotar("Maria");
            r2d2Adaptado.Movimenta();
            r2d2Adaptado.ArmaFogo();

        }
    }
}
