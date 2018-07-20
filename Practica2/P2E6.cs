//P2E6.cs

/*
    6) Que reciba un numero y genere todas las tablas de multiplicar desde el 1
    a ese número.
*/

using System;
class program
{
	public static void Main(string[] args)
	{
        int num ;
        System.Console.Write("Ingresa un numero => ");
        num = int.Parse(Console.ReadLine());

        for (int n = 0; n < num; n++)
        {
            for (int i = 1; i < 13; i++)
            {
                      System.Console.WriteLine( "\t"+ n + " * "+ i + "= "+ i * n  + " \n" );
            }
            
        }
        Console.ReadKey();
	}
}