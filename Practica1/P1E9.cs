//P1E9.cs
/*
    9 - Pida al usuario un número entero, diga si es par o impar, 
    y repita todo lo anterior hasta que el número que se introduzca sea 0.
     (Nota: para saber si un número es par, se mira si el resto de su división entre 2 es 0).
*/
using System;


 class Program
 {
     public static void Main(string[] lorfe)
    {
         int num;
         int resp;
         do
         {
             System.Console.Write("Ingresa numero -> ");
             num = Convert.ToInt32(Console.ReadLine());

           
            if ((num % 2) == 0 )
            {
                System.Console.WriteLine("El numero es par!!");
            }
            else
            {
                System.Console.WriteLine("El numero es impar!!");
            }
             
             System.Console.Write("Quieres procesar Otro numero? si = 0 \n");
             resp = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
         } while (resp == 0);
        
        Console.ReadKey();
    }
}