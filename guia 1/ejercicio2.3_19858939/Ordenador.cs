using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._3_19858939
{

    public class Ordenador
    {
        // vari del ordenador
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; } // GB
        public int DiscoDuro { get; set; } //  GB

        // Constructor
        public Ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }

        // aumento de capacidad en disco duro
        public void MayorCapacidad()
        {
            DiscoDuro += 100; // Incrementa el disco duro en 100 GB
            Console.WriteLine($"La capacidad del disco duro ha sido aumentada. Ahora tiene {DiscoDuro} GB.");
        }

        // reducir la capacidad del disco duro
        public void MenorCapacidad()
        {
            if (DiscoDuro - 100 >= 0)
            {
                DiscoDuro -= 100; // Reduce el disco duro en 100 GB
                Console.WriteLine($"La capacidad del disco duro ha sido reducida. Ahora tiene {DiscoDuro} GB.");
            }
            else
            {
                Console.WriteLine("No se puede reducir más la capacidad del disco duro, ya está en 0 GB.");
            }
        }

        // Moatrar los detalles
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Procesador: {Procesador}");
            Console.WriteLine($"Memoria: {Memoria} GB");
            Console.WriteLine($"Disco Duro: {DiscoDuro} GB");
        }
    }
}