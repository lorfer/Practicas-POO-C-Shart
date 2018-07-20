
//P1E7.cs

/*
    7 - Pida al usuario dos números reales (que se guardarán en las variables dato1 y dato2).
    Si dato2 es cero, deberá mostrar un mensaje de error, y en caso contrario mostrará en pantalla
     el resultado de dividir dato1 entre dato2. 
*/

using System;


 class Program
 {
     public static void Main(string[] lorfe)
    {
         decimal dato1;
         decimal dato2;
           
    
            System.Console.Write("Ingresa numero 1 -> ");
            dato1 = Convert.ToDecimal(Console.ReadLine());

            System.Console.Write("Ingresa numero 2 -> ");
            dato2 = Convert.ToDecimal(Console.ReadLine());

            if (dato2 == 0)
            {
                System.Console.WriteLine("Error el dividir por cero!");
            }
            else
            {
                decimal div = dato1 / dato2;
                System.Console.WriteLine("El resultado de la divicion es => " + Math.Round(div, 4));
            }
        Console.ReadKey();
        
     }
    
 }