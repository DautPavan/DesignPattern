using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Strategy
{
    public class ISS: IImposto
    {
        public ISS(IImposto imposto) : base(imposto) { }
        public ISS() : base() { }


        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }        
    }
}
