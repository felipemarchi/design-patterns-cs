using System;
namespace Interpreter
{
    public abstract class Expressao
    {
        public abstract string Um();
        public abstract string Quatro();
        public abstract string Cinco();
        public abstract string Nove();
        public abstract int Multiplicar();

        public void Interpertador(Contexto contexto)
        {
            if (contexto.Input.Length == 0)
            {
                return;
            }

            if (contexto.Input.StartsWith(Nove()))
            {
                contexto.Output += (9 * Multiplicar());
                contexto.Input = contexto.Input[2..];
            }
            else if (contexto.Input.StartsWith(Quatro()))
            {
                contexto.Output += (4 * Multiplicar());
                contexto.Input = contexto.Input[2..];
            }
            else if (contexto.Input.StartsWith(Cinco()))
            {
                contexto.Output += (5 * Multiplicar());
                contexto.Input = contexto.Input[1..];
            }

            while (contexto.Input.StartsWith(Um()))
            {
                contexto.Output += (1 * Multiplicar());
                contexto.Input = contexto.Input[1..];
            }
        }
    }
}
