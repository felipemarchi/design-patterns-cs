using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstrata_a = new ConcreteClassA();

            abstrata_a.TemplateMethod();

            AbstractClass abstrata_b = new ConcreteClassB();

            abstrata_b.TemplateMethod();
        }
    }
}
