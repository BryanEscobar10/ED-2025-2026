using System;

namespace FigurasGeometricas
{
    // Clase Circulo
    class Circulo
    {
        // Atributo privado: radio del círculo
        private double radio;

        // Constructor para inicializar el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            // Fórmula: π * radio^2
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro (circunferencia)
        public double CalcularPerimetro()
        {
            // Fórmula: 2 * π * radio
            return 2 * Math.PI * radio;
        }
    }

    // Clase Cuadrado
    class Cuadrado
    {
        // Atributo privado: longitud del lado
        private double lado;

        // Constructor para inicializar el lado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método para calcular el área del cuadrado
        public double CalcularArea()
        {
            // Fórmula: lado^2
            return Math.Pow(lado, 2);
        }

        // Método para calcular el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            // Fórmula: 4 * lado
            return 4 * lado;
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo c = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + c.CalcularArea());
            Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

            // Crear un cuadrado con lado 4
            Cuadrado q = new Cuadrado(4);
            Console.WriteLine("\nCuadrado:");
            Console.WriteLine("Área: " + q.CalcularArea());
            Console.WriteLine("Perímetro: " + q.CalcularPerimetro());

            // Esperar entrada para mantener la consola abierta
            Console.ReadLine();
        }
    }
}
