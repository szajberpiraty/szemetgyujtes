using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemetgyujtes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Szemétgyűjtés: a .NET automatikusan felszabadítja azon objektumok helyét, amelyekre már nem mutat referencia
            //Az osztályokban definiált destruktorok is ilyenkor futnak le.
            //A destruktor/finalizer lefutása automatikus.

            for (int i = 0; i < 100; i++)
            {
                var dest = new Destroyable();
                //GC.Collect(); //kézzel híjuk a szemétgyűjtő algoritmust-nem feltétlenül javasolt megoldás

            }
            Console.ReadLine();

        }
        class Destroyable
        {
            public Destroyable()
            {
                Console.WriteLine("Konstruktor");
            }
            ~Destroyable()
            {
                Console.WriteLine("Finalizer");
            }
        }
    }
}
