using System;

namespace Mediator
{
    public class ColegaConcreto1 : Colega
    {
        public ColegaConcreto1(Mediador mediador) : base(mediador)
        {
        }

        public void Enviar(string mensagem)
        {
            mediador.Enviar(mensagem, this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine($"Mnesagem do Colega 1: {mensagem}");
        }
    }
}
