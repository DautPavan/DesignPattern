using MethodChaining;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new ItemDaNota("Celular", 100.0))
                .ComItem(new ItemDaNota("Caneca", 200.0))
                .ComItem(new ItemDaNota("Cafeteria", 300.0))
                .NaDataAtual()
                .ComObservacoes("Uma obs qualquer")
                .AdionarAcao(new NotaFiscalDao())
                .AdionarAcao(new EnviarEmail())
                .AdionarAcao(new EnviarSms());



            Console.WriteLine("----- Criando Nota Fiscal");
            var nota = criador.Constroi();
            Console.WriteLine("----- Frim da criação da Nota Fiscal");
            Console.WriteLine("");
            Console.WriteLine("----- Sua Nota:");

            Console.WriteLine(nota.ToString());
        }
    }
}
