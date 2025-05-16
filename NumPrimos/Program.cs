using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace NumPrimos
{
    internal class Program
    {
        static int sumaTotal = 0;
        static object lockObject = new object();
        static void CalcularPrimos(object rango)
        {
            // Convierte el objeto en una tupla (inicio, fin)
            (int inicio, int fin) = ((int, int))rango;
            int suma = 0;
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    // Suma solo si es primo
                    suma += i;
                }
            }
            // Evita que varios hilos escriban en sumaTotal simultáneamente
            lock (lockObject)
            {
                sumaTotal += suma;
            }
        }
        static bool EsPrimo(int numero)
        {

            if (numero < 2) return false;
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número límite:");
            int N = int.Parse(Console.ReadLine());
            int M = 4; // Número de hilos
            int rango = N / M;
            Thread[] hilos = new Thread[M];
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < M; i++)
            {
                int inicio = i * rango + 1;
                int fin = (i == M - 1) ? N : inicio + rango - 1;
                hilos[i] = new Thread(CalcularPrimos);
                hilos[i].Start((inicio, fin));
            }
            foreach (var hilo in hilos)
            {
                hilo.Join();
            }
            stopwatch.Stop();
            Console.WriteLine($"Suma total de números primos hasta {N}: ");
            Console.WriteLine($"Es de: {sumaTotal}");
            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
        
    }
}
