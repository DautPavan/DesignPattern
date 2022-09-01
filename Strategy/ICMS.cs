using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Strategy
{
    public class ICMS: IImposto
    {
        public ICMS (IImposto imposto): base(imposto) { }
        public ICMS(): base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
