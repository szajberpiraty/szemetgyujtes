using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_minta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> idomok = new List<ISikidom>();
            Kor kor = new Kor(5);
            Teglalap teglalap = new Teglalap(20,5);

            idomok.Add(kor);
            idomok.Add(teglalap);

            foreach (ISikidom i in idomok)
            {
                Console.WriteLine(i.Kerulet());
                Console.WriteLine(i.Terulet());
            }


            Console.ReadLine();
        }
        interface ISikidom
        {
            int Kerulet();

            int Terulet();
            
        }
        class Teglalap:ISikidom
        {
            public int Szelesseg { get; set; }
            public int Magassag { get; set; }

            public Teglalap(int sz,int m)
            {
                Szelesseg = sz;
                Magassag = m;
            }

            public int Kerulet()
            {
                return (Szelesseg + Magassag) * 2;
            }
            public int Terulet()
            {
                return Szelesseg * Magassag;
            }
        }
        class Kor:ISikidom
        {
            public int Sugar { get; set; }
            public Kor(int s)
            {
                Sugar = s;
            }

            public int Kerulet()
            {
                return (int)(2 * Sugar * Math.PI);
            }
            public int Terulet()
            {
                return (int)(Sugar * Sugar * Math.PI);
            }
            

        }


    }
}
