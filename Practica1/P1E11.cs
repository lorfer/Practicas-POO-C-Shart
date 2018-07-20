
//P1E11.cs

/*
    11- Que reciba un numero y muestre su tabla de multiplicar.
*/
 using System;


 class Program
 {
     public static void Main(string[] lorfe)
    {
        int num;
        int acum = 0;
        System.Console.Write("\t\n*TABLA DE MULTIPLICAR DEL NUMERO->");
         num = Convert.ToInt32(Console.ReadLine());
         
         for (int i = 0; i < 12; i++)
         {
             
             acum = num * i;
                 System.Console.WriteLine(num + " * " + i + "= " + acum);
             
             
         }
        Console.ReadKey();
    }
}