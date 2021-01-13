using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro(autor: "João", titulo: "João e o pé de Feijão", numeroCopias: 10);
            livro.Exibe();

            Video video = new Video(diretor: "Rodrigo", titulo: "Aulas avançadas", minutosDuracao: 25, numeroCopias: 3);
            video.Exibe();

            Console.WriteLine("\nEmprestando um Vídeo:");

            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

            emprestado.DevolverItem("Carlos");

            emprestado.Exibe();
        }
    }
}
