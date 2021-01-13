using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som montarSom()
        {
            return new BluetoohPlayer();
        }
    }
}
