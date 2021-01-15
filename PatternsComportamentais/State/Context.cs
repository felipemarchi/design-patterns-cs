using System;

namespace State
{
    public class Context
    {
        private State _state;
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"Estado: {_state.GetType().Name}");
            }
        }

        public Context(State state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
