 //lab05

	using System;
     interface IGeometrica
    {
         double perimetro();
         double area();
    }

    class Circulo : IGeometrica
    {

        const double PI = 3.14;
        private double radio;

        public  Circulo(double radio)
        {
            this.radio = radio;
        }

        public double perimetro()
        {
            double perimetro = Math.Pow((2 * PI * radio), 2);
            return perimetro;
        }
        public double area()
        {
            double area = Math.Pow((PI * radio), 2);
            return area;

        }
    }

    class Cuadrado : IGeometrica
    {
        private double lado;
        private const double PI = 3.14;

        public Cuadrado(double longitud) 
        {

            lado = longitud;
        }

        public  double perimetro()
        {
            double perimetro = 4 * lado;
            return lado;
        }
        public double area()
        {
            return lado * lado;

        }
    }



    class Program
    {
       
        static void Main(string[] args)
        {
			string resp;
			do {
				
				Console.WriteLine("Entre el perimetro del circulo");		
				double m = Convert.ToDouble(Console.ReadLine());
				IGeometrica miCirculo = new Circulo(m);
				Console.WriteLine("El perimetro del circulo = " + miCirculo.perimetro());
				Console.WriteLine("El area del circulo = " + miCirculo.area());
				
				Console.Write("***********************\n");	
				
				Console.WriteLine("Entre el perimetro del Cuadrado");
				double f = Convert.ToDouble(Console.ReadLine());
				IGeometrica miCuadrado = new Cuadrado(f);
				Console.WriteLine("El perimetro del cuadrado = " + miCuadrado.perimetro());
				Console.WriteLine("El area del cuadrado = " + miCuadrado.area());
			
				Console.Write("Quiere calcular nuevamente = si -> ");
				resp = Console.ReadLine();
			}while(resp == "si");



            Console.ReadKey();
        }
    }