using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace korositas
{
    class Program
    {

        //A heap alján kezdődik az objektum példányok tárolása, minden tárolással egyre feljebb kerül az a mutató, ami a verem legelső szabad pozícióját mutatja.
        //Mindig itt jön létre a következő objektum példány,mindig a verem tetején vannak a legfiatalabb objektumok
        //Generációkat kezel
        //0:(gyerek):a heap tetején vannak, rájuk még nem futott le
        //1:(szülő):rájuk már lefutott, de nem takarította őket
        //2:rájuk már kétszer lefutott, de még mindig állnak

        static void Main(string[] args)
        {
            var lista = new List<String>();


            //Memória foglaltság kiírása
            Console.WriteLine(GC.GetTotalMemory(false)); 
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
                lista.Add(new string('a', 6000));
                Console.Write(GC.GetGeneration(lista));
            }
            Console.WriteLine();
            Console.WriteLine(GC.GetTotalMemory(false));

            Console.ReadLine();
        }
    }
}
