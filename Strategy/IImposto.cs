using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Strategy
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }

        public IImposto (IImposto imposto)
        {
            this.OutroImposto = imposto;
        }

        public IImposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
