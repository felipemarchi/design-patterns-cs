using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitveOperation1();

        public abstract void PrimitveOperation2();

        public void TemplateMethod()
        {
            PrimitveOperation1();
            PrimitveOperation2(); 
            Console.WriteLine();
        }
    }
}
