using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1_19858939
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase CocheDeCarrera
            CocheDeCarrera miCocheDeCarrera = new CocheDeCarrera("Ferrari", "F8 Tributo", 340);

            // Mostrar los detalles del coche de carrera
            miCocheDeCarrera.MostrarDetalles();

            // Probar acelerar, desacelerar y frenar
            miCocheDeCarrera.Acelerar();  // Acelera
            miCocheDeCarrera.Acelerar();  // Acelera de 5 en 5
            miCocheDeCarrera.Decelerar(); // Desacelera
            miCocheDeCarrera.Frenar();    // Frenar en 0
            miCocheDeCarrera.MostrarDetalles(); // Ver los detalles después de frenar

            Console.ReadKey();
        }
    }
}
