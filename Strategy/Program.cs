using System;
using Models;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS();
            var icms = new ICMS();
            var iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
