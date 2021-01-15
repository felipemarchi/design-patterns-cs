using System;

namespace TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitveOperation1()");
        }

        public override void PrimitveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitveOperation2()");
        }
    }
}
