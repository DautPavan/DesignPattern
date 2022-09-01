using System;
using System.Collections.Generic;
using System.Text;

namespace MethodChaining
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal;
        public double Impostos;
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public IList<IAcoesAposGeracao> TodasAcoesASeremExecutadas = new List<IAcoesAposGeracao>();


        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            this.Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder AdionarAcao(IAcoesAposGeracao novaacao)
        {
            this.TodasAcoesASeremExecutadas.Add(novaacao);
            return this;
        }

        public NotaFiscal Constroi() {
            NotaFiscal nf = new NotaFiscal(
                this.RazaoSocial,
                this.Cnpj,
                this.Data,
                this.ValorTotal,
                this.Impostos,
                this.todosItens,
                this.Observacoes
            );

            foreach (var item in TodasAcoesASeremExecutadas)
            {
                item.Executar(nf);
            }

            return nf;
        }


    }
}
