using System;
using System.Collections.Generic;
using System.Text;

namespace MoedasENotas
{
   public static class Calculo
    {
        public static NotasMoedas Calcula100( NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor/100);
            float nota = (float)Math.Round(nota1,2);
            float resto = notasMoedas.valor % 100;
            notasMoedas.Cem = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Calcula50(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 50);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 50;
            notasMoedas.Cinquenta = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }

        public static NotasMoedas Calcula20(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 20);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 20;
            notasMoedas.Vinte = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Calcula10(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 10);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 10;
            notasMoedas.Dez = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Calcula5(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 5);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 5;
            notasMoedas.Cinco = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Calcula2(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 2);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 2;
            notasMoedas.Dois = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }

        public static NotasMoedas Moeda1(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 1);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 1;
            notasMoedas.UmReal = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Moeda50(NotasMoedas notasMoedas)
        {
           
            float nota1 = (notasMoedas.valor / 0.50F);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 0.50F;
            notasMoedas.CinquentaCentavos = nota;
            notasMoedas.valor =  resto;
            return notasMoedas;
        }
        public static NotasMoedas Moeda25(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 0.25F);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 0.25F;
            notasMoedas.VinteCincoCentavos = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Moeda10(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 0.10F);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 0.10F;
            notasMoedas.DezCentavos = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Moeda5(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 0.05F);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 0.05F;
            notasMoedas.CincoCentavos = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }
        public static NotasMoedas Moeda1Centavo(NotasMoedas notasMoedas)
        {
            float nota1 = (notasMoedas.valor / 0.01F);
            float nota = (float)Math.Round(nota1, 2);
            float resto = notasMoedas.valor % 0.01F;
            notasMoedas.UmCentavo = nota;
            notasMoedas.valor = resto;
            return notasMoedas;
        }

    }
}
