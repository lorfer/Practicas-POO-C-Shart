//P2E1.cs

/*
    1) Reciba un numero de mes y muestre en pantalla el nombre del mes
 */


 using System;
class program
{
	public static void Main(string[] args)
	{
       int mes = 1;
       string[] meses = new string[13]  { " ","Enero", "Febrero", "Marzo","Abril", "Mayo", "Junio","julio","Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		 
         System.Console.WriteLine("\t\n*Introduce un mes en numero ->");
         mes = Convert.ToInt32(Console.ReadLine());

             System.Console.WriteLine("El numero "+ mes + " Corresponde a: " + meses[mes]);     
         
        
        Console.ReadKey();
	}
}