using System;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoObservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assunto, string nome)
        {
            _assunto = assunto;
            _nome = nome;
        }

        public override void Update()
        {
            this._estadoObservador = this._assunto.EstadoAssunto;
            Console.WriteLine($"Observador {this._nome}, seu novo estado é: {this._estadoObservador}");
        }

        public AssuntoConcreto Assunto { get; set; }
    }
}
