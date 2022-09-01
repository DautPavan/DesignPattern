using Models;
using Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public TemplateDeImpostoCondicional(IImposto imposto): base(imposto) { }
        public TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }

            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
