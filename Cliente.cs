using System;


namespace Treinamento.Cadastros
{
    public class Cliente
    {
        //atributos
        public int Codigo;
        public string Nome;

        //métodos
        public void Mostrar()
        {
            Console.WriteLine("Dados do Cliente:{0}---{1}\n", Codigo, Nome);

        }
    }

    class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CPF:{0}\n", CPF);
        }
    }
    class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ:{0}\n", CNPJ);
        }
    }
}
