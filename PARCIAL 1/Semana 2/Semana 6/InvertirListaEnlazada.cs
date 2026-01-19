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
            // Se crea un objeto de la lista enlazada
            ListaEnlazada lista = new ListaEnlazada();

            // Inserción de datos en la lista
            lista.Insertar(5);
            lista.Insertar(3);
            lista.Insertar(8);
            lista.Insertar(7);
            lista.Insertar(1);

            // Mostrar la lista original
            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Invertir la lista enlazada
            lista.Invertir();

            // Mostrar la lista invertida
            Console.WriteLine("\nLista invertida:");
            lista.Mostrar();

            // Pausa para que la consola no se cierre
            Console.ReadKey();
        }
    }

    // Clase Nodo: representa cada elemento de la lista enlazada
    class Nodo
    {
        // Dato almacenado en el nodo
        public int Dato;

        // Referencia al siguiente nodo
        public Nodo Siguiente;

        // Constructor del nodo
        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada: administra la estructura de la lista
    class ListaEnlazada
    {
        // Referencia al primer nodo de la lista
        private Nodo cabeza;

        // Constructor de la lista enlazada
        public ListaEnlazada()
        {
            // Inicialmente la lista está vacía
            cabeza = null;
        }

        // Método para insertar un nodo al final de la lista
        public void Insertar(int dato)
        {
            // Se crea un nuevo nodo
            Nodo nuevo = new Nodo(dato);

            // Si la lista está vacía
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                // Se recorre la lista hasta el último nodo
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                // El último nodo apunta al nuevo nodo
                actual.Siguiente = nuevo;
            }
        }

        // Método para mostrar los datos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;

            // Recorre la lista y muestra cada dato
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }

            Console.WriteLine("null");
        }

        // Método que invierte el orden de los nodos de la lista enlazada
        public void Invertir()
        {
            Nodo anterior = null;   // Nodo previo
            Nodo actual = cabeza;   // Nodo actual
            Nodo siguiente = null;  // Nodo siguiente

            // Recorrido de la lista
            while (actual != null)
            {
                // Guardar el siguiente nodo
                siguiente = actual.Siguiente;

                // Invertir el enlace
                actual.Siguiente = anterior;

                // Avanzar los punteros
                anterior = actual;
                actual = siguiente;
            }

            // Actualizar la cabeza de la lista
            cabeza = anterior;
        }
    }
}
