using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator
            {
                State = "On"
            };

            Caretaker c = new Caretaker
            {
                Memento = o.CreateMemento()
            };

            o.State = "Off";

            o.SetMemento(c.Memento);
        }
    }
}
