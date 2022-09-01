using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void ReProva(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta em aprovacao. não pode ser reprovado agora");
        }
    }
}
