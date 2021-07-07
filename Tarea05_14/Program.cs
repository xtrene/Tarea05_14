using System;

namespace Tarea05_14
{
    class Program
    {

        static Random alea = new Random();
        static public int generaNumero(int n1, int n2)
        {
            int resultado = alea.Next(n1, n2);
            return resultado;
        }


        static void Main(string[] args)
        {
            int busqueda = 0;
            int dimension = 0;
            Boolean encontrado = false;
            Console.Write("Dimensión del array: ");
            dimension = Convert.ToInt32(Console.ReadLine());

            int[] lista = new int[dimension];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = generaNumero(1, 10);
            }
            Console.WriteLine("Introduce número para buscar: ");
            busqueda = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == busqueda)
                {
                    Console.WriteLine("Número encontrado en la posición: {0}", i + 1);
                    encontrado = true;
                }
                
            }

            if (!encontrado)
            {
                Console.WriteLine("Número no encontrado!!!");
            }


            Console.ReadKey();

        }
    }
}
