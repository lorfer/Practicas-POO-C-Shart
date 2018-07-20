//P2E2.cs
/*
    2) Reciba 3 números por teclado y los imprima de menor a mayor
*/

 using System;
class program
{
	public static void Main(string[] args)
	{
     
       int[] cant = new int[3];

        System.Console.WriteLine("Ingresa 3 numero y te lo ordeno");
        for (int i = 0; i < cant.Length; i++)
        {
                cant[i] = int.Parse(Console.ReadLine());
        }
        
        //Metodo de la clase ARRAY para imprimir de mayor a menor.
        Array.Sort(cant);
        for (int i = 0; i < cant.Length; i++)
        {
            System.Console.Write(cant[i]);
        }
        
        Console.ReadKey();
	}
}