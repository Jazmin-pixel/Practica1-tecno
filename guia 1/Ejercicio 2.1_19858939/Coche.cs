using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_19858939
{
    public class Coche
    {
        // Atributos del coche
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadMaxima { get; set; }
        public int VelocidadActual { get; set; }

        // Constructor
        public Coche(string marca, string modelo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadMaxima = velocidadMaxima;
            VelocidadActual = 0;  // Inicializamos la velocidad actual en 0
        }

        // Método para acelerar
        public virtual void Acelerar()
        {
            if (VelocidadActual + 5 <= VelocidadMaxima)
            {
                VelocidadActual += 5;
                Console.WriteLine($"El coche ha acelerado. Velocidad actual: {VelocidadActual} km/h.");
            }
            else
            {
                VelocidadActual = VelocidadMaxima;
                Console.WriteLine($"El coche ha alcanzado su velocidad máxima de {VelocidadMaxima} km/h.");
            }
        }

        // Método para desacelerar
        public virtual void Decelerar()
        {
            if (VelocidadActual - 5 >= 0)
            {
                VelocidadActual -= 5;
                Console.WriteLine($"El coche ha desacelerado. Velocidad actual: {VelocidadActual} km/h.");
            }
            else
            {
                VelocidadActual = 0;
                Console.WriteLine("El coche se ha detenido.");
            }
        }

        // Método para mostrar los detalles del coche
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Velocidad máxima: {VelocidadMaxima} km/h");
            Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
        }
    }
}

