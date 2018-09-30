using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace dispose_pelda1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;

            while (!Console.KeyAvailable)
            {
                //Console.WriteLine(i);
                //var stream = new MemoryStream(100000); //Folyamatosan megy a szemétgyűjtő
                var bitmap = new Bitmap(1280, 1024);
                //Van véglegesítője, ezért nagyon könnyen elfogy a memória
                //using( var bitmap = new Bitmap(1280,1024)) {} //-Így nem lesz memória probléma
                Console.WriteLine(GC.GetTotalMemory(false));
                i++;
            }
        }
    }
}
