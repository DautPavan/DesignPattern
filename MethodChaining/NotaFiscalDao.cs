using MethodChaining;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodChaining
{
    public class NotaFiscalDao: IAcoesAposGeracao
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("Nf Salava BD!");

        }
    }
}
