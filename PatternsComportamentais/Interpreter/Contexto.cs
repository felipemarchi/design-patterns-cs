using System;

namespace Interpreter
{
    public class Contexto
    {
        public Contexto(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
        public int Output { get; set; }


    }
}
