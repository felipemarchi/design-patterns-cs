using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        public RoboInimigo Robo { get; set; }

        public RoboInimigoAdapter(RoboInimigo robo)
        {
            Robo = robo;
        }

        public void ArmaFogo()
        {
            this.Robo.EsgamarComMaos();
        }

        public void Movimenta()
        {
            this.Robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.Robo.ReagirContraHumano(piloto);
        }
    }
}
