//P1E1.cs

/*
    2 - Que reciba un numero por teclado y diga si el numero es par o impar.
 */

 using System;
class program
{
	public static void Main(string[] lorfe)
	{
		 int miNumero;
		 
		 System.Console.Write("Entra un numero -> ");
         miNumero = Convert.ToInt32(Console.ReadLine());

         if ((miNumero % 2) == 0)
         {
            System.Console.WriteLine("El numero que ingresaste es par");
             
         }
         else
         {
            		System.Console.WriteLine("El numero que ingresaste es impar!");
         }
		
		
		Console.ReadKey();
	}
}