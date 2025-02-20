using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_19858939
{
    public class CocheDeCarrera : Coche
    {
        // ejercicio 2.2 : clase heredada 
        public CocheDeCarrera(string marca, string modelo, int velocidadMaxima)
            : base(marca, modelo, velocidadMaxima) { }

        // freno deja la velocidad a 0
        public void Frenar()
        {
            VelocidadActual = 0;
            Console.WriteLine("El coche ha frenado y la velocidad es ahora 0 km/h.");
        }

        // Sobrescribir el método Acelerar 
        public override void Acelerar()
        {
            if (VelocidadActual + 10 <= VelocidadMaxima)  // Cambié el incremento a 10 para hacerlo más rápido
            {
                VelocidadActual += 10;
                Console.WriteLine($"El coche de carrera ha acelerado. Velocidad actual: {VelocidadActual} km/h.");
            }
            else
            {
                VelocidadActual = VelocidadMaxima;
                Console.WriteLine($"El coche de carrera ha alcanzado su velocidad máxima de {VelocidadMaxima} km/h.");
            }
        }
    
    }
}
