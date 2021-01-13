using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class CarroFactory
    {
        public abstract Roda montarRoda();
        public abstract Som montarSom();
    }
}
