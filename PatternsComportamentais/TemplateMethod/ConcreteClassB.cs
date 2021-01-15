using System;

namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitveOperation1()");
        }

        public override void PrimitveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitveOperation2()");
        }
    }
}
