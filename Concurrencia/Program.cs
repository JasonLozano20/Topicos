using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrencia
{
    internal class Program
    {
        // Método que será ejecutado por los hilos
        static void Proceso(object id)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Hilo {id}: Iteración {i}");
                Thread.Sleep(1000); // Simula un proceso que toma tiempo
            }
        }
            static void Main(string[] args)
            {

                Console.WriteLine("Inicio del programa...");
                Stopwatch watch = Stopwatch.StartNew();
                Proceso(1);
                Proceso(2);
                Proceso(3);

                watch.Stop();
                Console.WriteLine("Tiempo de ejecucion proceso unico: " + $"{watch.ElapsedMilliseconds} ms");
                Console.WriteLine("Multiproceso");
                Stopwatch watch1 = Stopwatch.StartNew();
                Thread hilo1 = new Thread(Proceso);
                Thread hilo2 = new Thread(Proceso);
                Thread hilo3 = new Thread(Proceso);

                // Iniciar los hilos con diferentes identificadores
                hilo1.Start(1);
                hilo2.Start(2);
                hilo3.Start(3);
                // Esperar a que los hilos terminen
                hilo1.Join();
                hilo2.Join();
                hilo3.Join();
                watch1.Stop();

                Console.WriteLine("Tiempo de ejecucion proceso unico: " + $"{watch1.ElapsedMilliseconds} ms");
                Console.WriteLine("Fin del programa...");
                Console.ReadLine();
            }

        
     }

}   