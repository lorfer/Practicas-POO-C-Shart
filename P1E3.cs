//P1E3.cs
/*
    3 - Que solicite la edad del usuario y diga si es un niño, un adolescente, un juven,
    o un adulto.
*/

using System;
class program
{
	public static void Main(string[] lorfe)
	{
		 System.Console.Write("Cual es tu edad -> ");
         int edad = Console.Read();

         if (edad <= 10 )
         {

            System.Console.WriteLine("Eres un niño!!"); 

         }
        else if (edad > 14 && edad < 17)
         {

            System.Console.WriteLine("Eres un adolecente, menol!! ");

         }
         else 
         {

             System.Console.WriteLine("Usted es un viejo ya, eres adulto :P");

         }
		
		
		Console.ReadKey();
	}
}