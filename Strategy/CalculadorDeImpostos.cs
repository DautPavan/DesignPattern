using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Strategy
{
    public class CalculadorDeImpostos
    {
        public CalculadorDeImpostos()
        {
        }

        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
