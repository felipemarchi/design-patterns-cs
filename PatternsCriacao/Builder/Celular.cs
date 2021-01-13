using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Celular
    {
        public Celular(String nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera { get; set; }

        public override string ToString()
        {
            return $"\t{this.Nome} \nBateria:\t{this.bateria}\nTela:\t\t{this.tela}\nSistema:\t{this.sistema}\nCamera:\t\t{this.camera}";
        }
    }
}
