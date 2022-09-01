using MethodChaining;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodChaining
{
    public class EnviarEmail: IAcoesAposGeracao
    {
        public void Executar(NotaFiscal nf) 
        {
            Console.WriteLine("Email enviado!");
        
        }

    }
}
