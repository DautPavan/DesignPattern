using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MethodChaining
{
    public class NotaFiscal
    {
        private string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private DateTime DataDeEmissao { get; set; }
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao,
                      double valorBruto, double impostos, IList<ItemDaNota> itens,
                      string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(String.Format("---Razao Social: {0}", this.RazaoSocial));
            str.AppendLine(String.Format("---Cnpj: {0}", this.Cnpj));
            str.AppendLine(String.Format("---Data De Emissao: {0}", this.DataDeEmissao));
            str.AppendLine(String.Format("---Valor Bruto: {0}", this.ValorBruto));
            str.AppendLine(String.Format("---Impostos: {0}", this.Impostos));
            str.AppendLine("---Itens: ");
            foreach (var item in this.Itens.Select((value, i) => new { i, value }))
            {
                str.AppendLine(String.Format("-{0}º Item: {1} Valor: {2}",
                    (item.i + 1),
                    item.value.Nome,
                    item.value.Valor
                ));
            }

            str.AppendLine(String.Format("---Observacoes: {0}", this.Observacoes));

            return str.ToString();
        }
    }
}
