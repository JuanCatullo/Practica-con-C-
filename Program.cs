using System;

namespace Practica 
{
    class Program
    {
        static void Main(string[] args)
        {
            string Linea;
            int tam, i, num, band, Max;
            band = 0;
            Max = 0;

            Console.WriteLine("Ingrese el tamanio del lote a evaluar");  
            Linea=Console.ReadLine();
            tam = int.Parse (Linea);
            for (i = 0 ; i < tam; i ++)
            {
                Console.WriteLine("Ingrese un numero");
                Linea = Console.ReadLine();
                num = int.Parse(Linea);
                if (band == 0)
                {
                    Max = num;
                    band++;

                }
                else
                    if (num > Max);
                {
                    Max = num;


                }
                Console.WriteLine("El mayor numero del Lote es" + Max); 





            }
        } 
    }
}
