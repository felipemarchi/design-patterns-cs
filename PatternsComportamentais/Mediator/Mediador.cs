using System;
namespace Mediator
{
    public abstract class Mediador
    {
        public abstract void Enviar(string mensagem, Colega colega);
    }
}
