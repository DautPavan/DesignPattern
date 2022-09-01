using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }

        public void ReProva(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new ReProvado();
        }
    }
}
