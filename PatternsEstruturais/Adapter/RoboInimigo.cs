using System;

namespace Adapter
{
    // é o nosso Adaptee -> ele é o objeto que será adaptado
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsgamarComMaos()
        {
            int danoAataque = this.gerador.Next(10) + 1;

            Console.WriteLine($"O Robo inimigo causou {danoAataque} de dano com o ataque Esmgar com as Mãoes!");
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;

            Console.WriteLine($"O Robo inimigo andou {movimento} passos para frente!");
        }

        public void ReagirContraHumano(String piloto)
        {
            Console.WriteLine($"O robo inimigo vai contra {piloto}!");
        }
    }
}
