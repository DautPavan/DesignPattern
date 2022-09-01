using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }

        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item) 
        {
            Itens.Add(item);            
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void ReProva(Orcamento orcamento)
        {
            EstadoAtual.ReProva(this);
        }

    }
}
