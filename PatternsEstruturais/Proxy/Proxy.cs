using System;

namespace Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Requisicao()
        {
            if(this.realSubject == null)
            {
                this.realSubject = new RealSubject();
            }

            this.realSubject.Requisicao();
        }
    }
}
