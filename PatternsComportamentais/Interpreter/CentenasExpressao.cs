using System;

namespace Interpreter
{
    public class CentenasExpressao : Expressao
    {
        public override string Cinco()
        {
            return "D";
        }

        public override string Nove()
        {
            return "CM";
        }

        public override string Quatro()
        {
            return "CD";
        }

        public override string Um()
        {
            return "C";
        }

        public override int Multiplicar()
        {
            return 100;
        }
    }
}
