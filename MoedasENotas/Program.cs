using System;
using System.Globalization;

namespace MoedasENotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela();
            NotasMoedas notasMoedas = new NotasMoedas();
            notasMoedas.valor = tela.RecebeValor();
            Calculo.Calcula100(notasMoedas);
            Calculo.Calcula50(notasMoedas);
            Calculo.Calcula20(notasMoedas);
            Calculo.Calcula10(notasMoedas);
            Calculo.Calcula5(notasMoedas);
            Calculo.Calcula2(notasMoedas);
            Calculo.Moeda1(notasMoedas);
            Calculo.Moeda50(notasMoedas);
            Calculo.Moeda25(notasMoedas);
            Calculo.Moeda10(notasMoedas);
            Calculo.Moeda5(notasMoedas);
            Calculo.Moeda1Centavo(notasMoedas);
            tela.Imprimir(notasMoedas);
 
        }
 
    }
}
