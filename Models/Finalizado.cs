using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não recebem desconto extra");
        }


        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }

        public void ReProva(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
    }
}
