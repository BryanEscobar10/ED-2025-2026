using System;

class Estudiante
{
    // Atributos del estudiante
    public int ID;                     // Identificador único
    public string Nombres;             // Nombres del estudiante
    public string Apellidos;           // Apellidos del estudiante
    public string Direccion;           // Dirección del estudiante
    public string[] Telefonos = new string[3]; // Array para almacenar 3 números de teléfono

    // Método para mostrar los datos ingresados
    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Datos del Estudiante Registrado ---");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Estudiante
        Estudiante est = new Estudiante();

        Console.WriteLine("=== Registro de Estudiante ===");

        // Solicitar datos del estudiante
        Console.Write("Ingrese el ID del estudiante: ");
        est.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");
        est.Direccion = Console.ReadLine();

        // Ingresar los tres números de teléfono usando un array
        Console.WriteLine("\nIngrese los 3 números de teléfono:");
        for (int i = 0; i < est.Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar la información ingresada
        est.MostrarDatos();
    }
}
