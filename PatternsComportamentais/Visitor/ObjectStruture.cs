using System;
using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> elementos = new List<Element>();

        public void Anexar(Element elemento)
        {
            this.elementos.Add(elemento);
        }

        public void Desanexar(Element elemento)
        {
            this.elementos.Remove(elemento);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element elemento in this.elementos)
            {
                elemento.Accept(visitor);
            }
        }
    }
}
