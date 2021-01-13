using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente func_permanente = new FuncionarioPermanente
            {
                Nome = "João",
                Idade = 30,
                Tipo = "Permanente"
            };

            FuncionarioPermanente clone_func_permanente = (FuncionarioPermanente)func_permanente.Clone();
            clone_func_permanente.Nome = "Carlos";
            clone_func_permanente.Idade = 40;

            Console.WriteLine("Detalhes do funcionário Permanente:");
            Console.WriteLine($"Nome: {func_permanente.Nome} \nIdade: {func_permanente.Idade} \nTipo: {func_permanente.Tipo}");

            Console.WriteLine("\nDetalhes do funcionário Permanente Clonado:");
            Console.WriteLine($"Nome: {clone_func_permanente.Nome} \nIdade: {clone_func_permanente.Idade} \nTipo: {clone_func_permanente.Tipo}");
        }
    }
}
