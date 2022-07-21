using System;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Boxing - Transforma tipo valor em tipo referencia
            int x = 20;
            Object y = x;
            Console.WriteLine(y + " - Boxing para Tipo Referência");

            //Boxing - Transforma tipo Referencia em tipo valor
            int w = (int) y;
            Console.WriteLine(w + " - Unboxing para Tipo Valor");




        }
    }
}
