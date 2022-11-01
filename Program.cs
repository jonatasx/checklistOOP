using System;
using Treinamento.Cadastros;


namespace Competencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoa1 = new PessoaFisica();
            pessoa1.Codigo = 123;
            pessoa1.Nome = "Jônatas Santos Pessôa";
            pessoa1.CPF = "3453534543";
            

            pessoa1.Mostrar();

            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++");


            PessoaJuridica pessoa2 = new PessoaJuridica();
            pessoa2.Codigo = 123;
            pessoa2.Nome = "Edka";
            pessoa2.CNPJ = "41954876-5";

            pessoa2.Mostrar();

            

            Console.ReadLine();

        }

    }
}
