using Models;
using Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ICPP: TemplateDeImpostoCondicional
    {
        public ICPP() : base() { }

        public ICPP(IImposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500.0;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
