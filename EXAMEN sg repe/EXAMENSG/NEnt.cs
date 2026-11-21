using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENSG
{
    class NEnt
    {
        private int n;
        public NEnt()
        {
            n = 0;
        }

        public void Cargar(int dato)
        {
            n = dato;
        }
        public int Descargar()
        {
            return n;
        }
        public bool VerifPri()
        {
            int i, cont;
            cont = 0;
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            return (cont == 2);
        }
    }
}
