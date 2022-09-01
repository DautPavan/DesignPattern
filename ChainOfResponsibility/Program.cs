using Models;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionarItem(new Item("Caneta", 500));
            orcamento.AdicionarItem(new Item("lapis", 500));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);



            Orcamento orcamento2 = new Orcamento(500.0);
            orcamento2.AdicionarItem(new Item("Celular", 500));
            orcamento2.AdicionarItem(new Item("tesoura", 500));
            orcamento2.AdicionarItem(new Item("geladeira", 500));
            orcamento2.AdicionarItem(new Item("fogao", 500));
            orcamento2.AdicionarItem(new Item("taclado", 500));
            orcamento2.AdicionarItem(new Item("mouse", 500));

            double desconto2 = calculador.Calcula(orcamento2);
            Console.WriteLine(desconto2);



            Orcamento orcamento3 = new Orcamento(800.0);
            orcamento3.AdicionarItem(new Item("Caneta", 800));

            double desconto3 = calculador.Calcula(orcamento3);
            Console.WriteLine(desconto3);


            Orcamento orcamento4 = new Orcamento(500.0);
            orcamento4.AdicionarItem(new Item("CANETA", 500));
            orcamento4.AdicionarItem(new Item("LAPIS", 500));

            double desconto4 = calculador.Calcula(orcamento4);
            Console.WriteLine(desconto4);
        }
    }
}
