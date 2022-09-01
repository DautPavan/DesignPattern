using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Strategy
{
    public class ICCC : IImposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;
            if (orcamento.Valor < 1000)
                valor = valor * 0.05;
            else if (orcamento.Valor <= 3000)
                valor = valor * 0.07;
            else
            {
                valor = valor * 0.05;
                valor += 30;
            }

            return valor;
        }
    }
}
