using Models;
using Strategy;
using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var IKCV = new IKCV();
            var ICPP = new ICPP();

            Orcamento orcamentoIKCV = new Orcamento(500.0);

            Orcamento orcamento2IKCV = new Orcamento(1000.0);
            orcamento2IKCV.AdicionarItem(new Item("Celular", 100));
            orcamento2IKCV.AdicionarItem(new Item("tesoura", 100));
            orcamento2IKCV.AdicionarItem(new Item("geladeira", 100));
            orcamento2IKCV.AdicionarItem(new Item("fogao", 100));
            orcamento2IKCV.AdicionarItem(new Item("taclado", 100));
            orcamento2IKCV.AdicionarItem(new Item("mouse", 500));


            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            Console.WriteLine("------IKCV------");
            Console.WriteLine("---Maxima");
            calculador.RealizaCalculo(orcamento2IKCV, IKCV);
            Console.WriteLine("---Minina");
            calculador.RealizaCalculo(orcamentoIKCV, IKCV);

            Console.WriteLine();
            Console.WriteLine();


            Orcamento orcamentoICPP = new Orcamento(400.0);
            Orcamento orcamento2ICPP = new Orcamento(500.0);

            Console.WriteLine("------ICPP------");
            Console.WriteLine("---Maxima");
            calculador.RealizaCalculo(orcamento2ICPP, ICPP);
            Console.WriteLine("---Minina");
            calculador.RealizaCalculo(orcamentoICPP, ICPP);

        }
    }
}
