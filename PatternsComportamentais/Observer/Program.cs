using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObservadorConcreto(s, "X"));
            s.Anexar(new ObservadorConcreto(s, "Y"));
            s.Anexar(new ObservadorConcreto(s, "Z"));

            s.EstadoAssunto = "ABC";
            s.Notificar();
        }
    }
}
