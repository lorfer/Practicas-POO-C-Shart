//P2E4.cs
/*
    Reciba el salario bruto de un empleado por teclado y aplique porcentaje
    de impuestos sobre la renta según corresponda, un cargo de 0.0287 de
    AFP y un cargo de 0.0304 de seguro familiar de salud, resultando el
    sueldo neto. La salida debe decir:
    Sueldo Bruto: 25,000.00
    ISR: Exento
    SFS: 760.00
    AFP: 717.50
    Sueldo Neto: 23,522.50
*/

using System;
class program
{
	public static void Main(string[] args)
	{
        
        double AFP;
        double SFS;
        double salario = 0.0;
        double sueldoNeto = 0.0;

        System.Console.Write("Ingresa el Sueldo bruto del Empleado -> ");
        salario = double.Parse(Console.ReadLine());

        System.Console.WriteLine("ISR-> Extenso");
        SFS = salario * 0.0304;
        System.Console.WriteLine("SFS-> " + SFS);
        AFP = salario * 0.0287;
        System.Console.WriteLine("AFP-> " + AFP);
        sueldoNeto = salario -(AFP + SFS);
        System.Console.WriteLine("Sueldo Neto-> " + sueldoNeto);

        Console.ReadKey();
	}
}