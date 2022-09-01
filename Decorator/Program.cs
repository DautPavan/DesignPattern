using Models;
using Strategy;
using System;
using TemplateMethod;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS();
            Orcamento orcamento = new Orcamento(500);

            Console.WriteLine("------ Valor so do ISS");
            var valor = iss.Calcula(orcamento);
            Console.WriteLine(valor);

            var issIcms = new ISS(new ICMS());
            Console.WriteLine("------ Valor so do ISS + ICMS");
            var valor2 =  issIcms.Calcula(orcamento);
            Console.WriteLine(valor2);


            var issIcmsIKcvs = new ISS(new ICMS(new IKCV()));
            Console.WriteLine("------ Valor so do ISS + ICMS + IKCV");
            var valor3 = issIcmsIKcvs.Calcula(orcamento);
            Console.WriteLine(valor3);
        }
    }
}
