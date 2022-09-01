using System;

namespace MethodChaining
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
                .ComObservacoes("Uma obs qualquer");



            var nota = criador.Constroi();


            Console.WriteLine(nota.ToString());

        }
    }
}
