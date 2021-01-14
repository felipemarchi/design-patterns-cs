using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private SubSistemaUm um;

        private SubSistemaDois dois;

        private SubSistemaTres tres;

        public Facade()
        {
            this.um = new SubSistemaUm();
            this.dois = new SubSistemaDois();
            this.tres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMétodoA() -----");
            this.dois.MetodoDois();
            this.tres.MetodoTres();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMétodoB() -----");
            this.um.MetodoUm();
            this.tres.MetodoTres();
        }
    }
}
