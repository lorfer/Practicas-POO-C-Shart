//P1E8

/*
    8 - Pida al usuario dos números enteros (que se guardarán en las variables num1 y num2).
    Si num2 es cero, deberá mostrar un mensaje de error, y en caso contrario mostrará en 
    pantalla el resto de la división de num1 entre num2.
*/

using System;


 class Program
 {
     public static void Main(string[] lorfe)
    {
         int num1;
         int num2;
           
    
            System.Console.Write("Ingresa numero 1 -> ");
            num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Ingresa numero 2 -> ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                System.Console.WriteLine("Error, papa el ~!@#$ cero!");
            }
            else
            {
                int div = num1 / num2;
                 int residuo = num1/num2;

                System.Console.WriteLine("El resto es => " + div/residuo);
            }
        Console.ReadKey();
        
     }
    
 }