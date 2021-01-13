using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();

            ICelular celularBuilder = new IphoneBuilder();

            fabricante.Construtor(celularBuilder);
            Console.WriteLine($"Celular Fabricado: \n\n{celularBuilder.Celular}");

        }
    }
}
