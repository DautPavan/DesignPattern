using Models;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class IKCV: TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }

        public IKCV(IImposto outroImposto) : base(outroImposto) { }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(i => i.Valor > 100);
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
