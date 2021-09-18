using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
           string sobrenome;
           string nomeCompleto;
           string nomeCatalogo;
                      
           Console.Write("Digite seu primeiro nome: ");
           nome = Console.ReadLine();
           Console.Write("Digite seu sobrenome: ");
           sobrenome= Console.ReadLine();
           
           Console.WriteLine($"Nome completo: {nome} {sobrenome.ToUpper()}");
           Console.WriteLine($"Nome catalogo: {sobrenome.ToUpper()} {nome}");
        }
    }
}
