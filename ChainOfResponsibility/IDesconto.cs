using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);

        IDesconto Proximo { get; set; }
    }
}
