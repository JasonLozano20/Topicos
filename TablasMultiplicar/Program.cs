using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TablasMultiplicar
{
    internal class Program
    {
        static object bloqueo = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando tablas de multiplicar");

            Thread[] hilos = new Thread[10];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 1; i <=10; i++)
            {
                hilos[i - 1] = new Thread(CalcularTabla);
                hilos[i - 1].Start(i);
                hilos[i - 1].Join();
            }
            Console.WriteLine("La ejecucion finalizo");
            sw.Stop();
            Console.WriteLine($"El tiempo de ejecucion fue de: {sw.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
        static void CalcularTabla(object numero)
        {
            int n = (int)numero;

            lock (bloqueo)
            {
                Console.WriteLine($"La tabla del: {n}\n");
                for(int i =1; i<=10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
        }
    }
}
