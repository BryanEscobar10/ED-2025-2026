using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Inserción de datos en la lista
            lista.Insertar(5);
            lista.Insertar(3);
            lista.Insertar(5);
            lista.Insertar(7);
            lista.Insertar(5);

            // Solicitar al usuario el valor a buscar
            Console.Write("Ingrese el valor que desea buscar en la lista: ");
            int valorBuscado = int.Parse(Console.ReadLine());
            int resultado = lista.Buscar(valorBuscado);

            // Mostrar el resultado
            Console.WriteLine("El dato se encuentra " + resultado + " veces en la lista.");

            // Pausa para visualizar el resultado
            Console.ReadKey();
        }
    }

    class Nodo
    {
        // Valor almacenado en el nodo
        public int Dato;

        // Referencia al siguiente nodo
        public Nodo Siguiente;

        // Constructor
        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada
    class ListaEnlazada
    {
        private Nodo cabeza;

        // Constructor
        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para insertar nodos
        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            // Si la lista está vacía
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;

                // Recorrer hasta el último nodo
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                // Enlazar el nuevo nodo al final
                actual.Siguiente = nuevo;
            }
        }

        // Método de búsqueda
        public int Buscar(int valor)
        {
            Nodo actual = cabeza;
            int contador = 0;

            // Recorrido de la lista
            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    contador++;
                }
                actual = actual.Siguiente;
            }

            // Mensaje si no se encuentra el dato
            if (contador == 0)
            {
                Console.WriteLine("El dato no fue encontrado en la lista.");
            }

            return contador;
        }
    }
}
