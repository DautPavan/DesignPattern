using Models;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine("------ Orcamento Inicial: " + reforma.Valor.ToString());

            reforma.AplicaDescontoExtra();
            Console.WriteLine("--- Orcamento com desconto em aprovacao: " + reforma.Valor.ToString());

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine("--- Orcamento com desconto aprovado: " + reforma.Valor.ToString());

            reforma.Finaliza();
            Console.WriteLine("--- Orcamento finalizado");

            try
            {
                reforma.AplicaDescontoExtra();
            } catch (Exception ex) 
            {
                Console.WriteLine("--- Erro: " + ex.Message.ToString());
            }
        }
    }
}
