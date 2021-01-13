using System;

namespace AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaSimples();
        }

        public override Som montarSom()
        {
            return new CDPlayer();
        }
    }
}
