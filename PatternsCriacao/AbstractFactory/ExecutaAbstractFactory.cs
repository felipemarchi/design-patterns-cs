using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montarCarro(string tipo)
        {
            CarroFactory cf = null;

            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
                default:
                    break;
            }

            Carro carro = new Carro();
            carro.roda = cf.montarRoda();
            carro.som = cf.montarSom();

            return carro;
        }
    }
}
