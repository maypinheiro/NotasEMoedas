using System;
using System.Collections.Generic;
using System.Text;

namespace MoedasENotas
{
    public class Tela
    {
        public float RecebeValor()
        {
            float valor = float.Parse(Console.ReadLine());
            return valor;
        }

        public void Imprimir(NotasMoedas notasMoedas)
        {
            Console.WriteLine("NOTAS: ");
            Console.WriteLine(Math.Truncate(notasMoedas.Cem) + " nota(s) de R$ 100.00");
            Console.WriteLine(Math.Truncate(notasMoedas.Cinquenta) + " nota(s) de R$ 50.00");
            Console.WriteLine(Math.Truncate(notasMoedas.Vinte) + " nota(s) de R$ 20.00");
            Console.WriteLine(Math.Truncate(notasMoedas.Dez) + " nota(s) de R$ 10.00");
            Console.WriteLine(Math.Truncate(notasMoedas.Cinco) + " nota(s) de R$ 5.00");
            Console.WriteLine(Math.Truncate(notasMoedas.Dois) + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS: ");
            Console.WriteLine(Math.Truncate(notasMoedas.UmReal) + " moeda(s) de R$ 1.00");

            Console.WriteLine(Math.Truncate(notasMoedas.CinquentaCentavos) + " moeda(s) de R$ 0.50");
            Console.WriteLine(Math.Truncate(notasMoedas.VinteCincoCentavos)  + " moeda(s) de R$ 0.25");
            Console.WriteLine(Math.Truncate(notasMoedas.DezCentavos) + " moeda(s) de R$ 0.10");
            Console.WriteLine(Math.Truncate(notasMoedas.CincoCentavos)  + " moeda(s) de R$ 0.05");
            Console.WriteLine(Math.Truncate(notasMoedas.UmCentavo) + " moeda(s) de R$ 0.01");
 
        }

    }
}
