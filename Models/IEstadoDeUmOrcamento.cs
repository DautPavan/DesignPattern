using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IEstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);

        void Aprova(Orcamento orcamento);
        void ReProva(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
