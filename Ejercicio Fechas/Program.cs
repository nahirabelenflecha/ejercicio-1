using System;
using System.Threading;
using System.Globalization;

namespace Ejercicio_Fechas
{
    class Program
    {
        public static void Main (string[] args)
        {
            DateTime f1, f2;
            TimeSpan Dif;
            Console.WriteLine("Ingrese primera fecha en formato AAAA/MM/DD");
            f1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese segunda fecha en formato AAAA/MM/DD");
            f2 =Convert.ToDateTime(Console.ReadLine());
            Dif = f2-f1;                    
            float DifDias = Dif.Days;       
            float DifSem = 0.0f;               
            DifSem = DifDias/7;      
            

            Console.WriteLine("La cantidad de días de diferencia es: {0}", DifDias);
            Console.WriteLine("La cantidad de semanas de diferenia es: {0}",DifSem);
        }
    }
}   
