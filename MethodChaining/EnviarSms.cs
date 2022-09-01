using MethodChaining;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodChaining
{
    public class EnviarSms: IAcoesAposGeracao
    {
        public void Executar(NotaFiscal nf)
        {
            Console.WriteLine("SMS da NF Enviado!");

        }
    }
}
