using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._3_19858939
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  instancia de la clase Ordenador
            Ordenador miOrdenador = new Ordenador("HP", "Intel i7", 16, 500);

            //  detalles del ordenador
            miOrdenador.MostrarDetalles();

            // aumentar la capacidad del disco duro
            miOrdenador.MayorCapacidad(); // Incrementa el disco duro en 100 GB
            miOrdenador.MayorCapacidad(); // Incrementa nuevamente el disco duro en 100 GB

            // reducir la capacidad del disco duro
            miOrdenador.MenorCapacidad(); // Reduce el disco duro en 100 GB
            miOrdenador.MenorCapacidad(); // Reduce nuevamente el disco duro en 100 GB
            miOrdenador.MenorCapacidad(); // Reduce nuevamente el disco duro en 100 GB

            // los detalles después de los cambios a mostrar
            miOrdenador.MostrarDetalles();

            Console.ReadKey();
        }
    }
}
