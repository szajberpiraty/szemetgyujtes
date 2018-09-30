using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispose_minta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            for (int i = 0; i < 100; i++)
            {
                using (var lista = new NagyLista()) { } ;
                //var lista = new NagyLista();
            }
            
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.ReadLine();


        }
        class NagyLista:IDisposable
        {
            private List<String> lista = new List<string>();


            public NagyLista()
            {
                for (int i = 0; i < 600; i++)
                {
                    lista.Add(new String('a',6000));
                    //Console.WriteLine(i);
                }
            }


            #region IDisposable Support
            private bool disposedValue = false; // To detect redundant calls

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: dispose managed state (managed objects).
                        Console.WriteLine("Takarítás");
                        lista.Clear();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
                }
            }

            // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
            // ~NagyLista() {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            //   Dispose(false);
            // }

            // This code added to correctly implement the disposable pattern.
            public void Dispose()
            {
                // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
                Dispose(true);
                // TODO: uncomment the following line if the finalizer is overridden above.
                GC.SuppressFinalize(this);
            }
            #endregion

        }
    }
}
