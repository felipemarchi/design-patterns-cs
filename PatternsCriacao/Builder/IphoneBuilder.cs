using System;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;
        public IphoneBuilder()
        {
            celular = new Celular("Iphone");
        }

        public Celular Celular
        {
            get { return this.celular; }
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.celular.tela = "9";
        }
    }
}
