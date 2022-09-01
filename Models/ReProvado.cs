using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ReProvado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void ReProva(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado");
        }
    }
}
