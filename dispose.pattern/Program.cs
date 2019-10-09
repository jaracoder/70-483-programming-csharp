using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispose.pattern
{
    class Program
    {
        class Recurso : IDisposable
        {
            bool liberado = false;

            public void Dispose()
            {
                // Llama a Dispose y le envía la marca
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            public virtual void Dispose(bool disposing)
            {
                if (liberado) return;

                if (disposing)
                {
                    // libera cualquier objeto gestionado aquí
                }

                // libera cualquier objeto no gestionado aquí
            }
            ~Recurso()
            {
                // libera solo los objetos no gestionados
                Dispose(false);
            }
        }

        static void Main(string[] args)
        {
            Recurso r = new Recurso();
            r.Dispose();
        }
    }
}
