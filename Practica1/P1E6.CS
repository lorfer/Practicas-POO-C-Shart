//P1E6.cs

/*
    6 -  Pida al usuario dos números enteros (que se guardarán en las variables n1 y n2) y 
    muestre su producto en pantalla.
*/

using System;

 class Program
 {
     public static void Main(string[] lorfe)
    {
        int n1;
        int n2;
        
        System.Console.Write("Ingresa numero 1 ->");
        n1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Ingresa numero 2 ->");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        int pro =  n1 * n2;

        System.Console.WriteLine("El producto de los numeros es " + pro);

        Console.ReadKey();
        
     }
    
 }