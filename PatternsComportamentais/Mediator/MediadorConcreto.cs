using System;

namespace Mediator
{
    public class MediadorConcreto : Mediador
    {
        public ColegaConcreto1 Colega1 { private get; set; }

        public ColegaConcreto2 Colega2 { private get; set; }


        public override void Enviar(string mensagem, Colega colega)
        {
            if(colega == Colega1)
            {
                Colega2.Notificar(mensagem);
            }
            else
            {
                Colega1.Notificar(mensagem);
            }
        }
    }
}
