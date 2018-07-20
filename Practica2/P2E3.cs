//P2E3.cs

/*
    3) Reciba 3 números y confirme si el tercero resulta de multiplicar los dos
    primeros.
 */


 using System;
class program
{
	public static void Main(string[] args)
	{
       
        int mult = 0;
        int[] num = new int[3];
        
         System.Console.Write("*Entra numero ->");
        
        for (int i = 0; i < 3; i++)
        {
            num[i] = int.Parse(Console.ReadLine());

        }
            mult = num[0] * num[1];
            
            
            if (mult == num[2])
            {
                System.Console.WriteLine("Yes Resulta al multiplicarlo :D ");
            }
            else
            {
                System.Console.WriteLine("Por mala suerte no resulto :( ");
            }

        
        

        

        Console.ReadKey();
	}
}