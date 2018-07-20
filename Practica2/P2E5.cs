//P2E5.cs
/*
    5) Reciba un usuario y una contraseña. Si el usuario ingresa sus datos mal 3
    veces debe notificársele que ha intentado iniciar sesión 3 veces. Que
    contacte al administrador.
*/
using System;
class program
{
	public static void Main(string[] args)
	{
        string usuario  ;
        string contra;
        int control = 0;

        do{
            System.Console.Write("Ingresa tu Usuario -> ");
            usuario = Console.ReadLine();
            System.Console.Write("Ingresa tu Contraseña -> ");
            contra = Console.ReadLine(); 
            
            control +=1;
            
            if (control == 3)
            {
                System.Console.WriteLine("ha intentado iniciar sesión 3 veces. contacte al administrador.");                  
                break;
            } 
        } while (usuario != "lorfe" && contra != "lorfe");
        Console.ReadKey();
	}
}