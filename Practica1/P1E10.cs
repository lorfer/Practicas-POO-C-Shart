//P1E10.cs

/*
    10- Pida al usuario un número indefinido de números (mientras se tecleen números que no sea cero). 
    Después de la introducción de cada número aparecerá en pantalla información sobre el número de datos
     introducidos y la suma hasta el momento, así: "Has introducido 5 números y su suma es 38".
 */

 using System;


 class Program
 {
     public static void Main(string[] lorfe)
    {
        
        
        int num;
        int sum = 0;
        int cantidad = 0;
        System.Console.Write("Introduce N numeros seguido de ENTER diferentes 0 \n\t* -> ");
           
           do{
               
                    num = Convert.ToInt32(Console.ReadLine()); 
                        
               sum += num;
               cantidad +=1;
               System.Console.WriteLine("has introducido " + cantidad + " numeros y una suma de " + sum); 
                
           }while (num != 0);
           
       
        
            
        Console.ReadKey();
    }
}