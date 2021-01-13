using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICelular
    {
        void BuildTela();
        void BuildBateria();
        void BuildSistema();
        void BuildCamera();

        Celular Celular { get; }
    }
}
