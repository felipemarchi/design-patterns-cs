using System;

namespace Prototype
{
    public class FuncionarioPermanente : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }
        public IFuncionario Clone()
        {
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}
