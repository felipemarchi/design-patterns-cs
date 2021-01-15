using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new ObjectStruture();
            o.Anexar(new ConcreteElementA());
            o.Anexar(new ConcreteElementB());

            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);
        }
    }
}
