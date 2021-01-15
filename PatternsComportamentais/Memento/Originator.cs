using System;

namespace Memento
{
    public class Originator
    {
        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"State = {value}");
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            State = memento.State;
        }
    }
}
