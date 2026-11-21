using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EXAMENSG
{
    class Matriz
    {

        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;
        private int f, c;

        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }

        public void CargarRandom(int nf, int nc, int a, int b)
        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b + 1);
                }
            }
        }

        public void Dim(int f1, int c1)
        {
            f = f1;
            c = c1;
        }

        public string Descargar()
        {
            int f1, c1;
            string s = "";

            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x9";
                }
                s = s + "\xd" + "\xa";
            }
            return s;
        }


        //EXAMEN


        //PREGUNTA 1

      
        public void Ejercicio1()
        {
            int c1, c2, f1, aux;

            
            for (c1 = 1; c1 <= c; c1++)
            {
                x[f + 1, c1] = MayorFrecuencia(c1);
            }

            f++;

            
            for (c1 = 1; c1 < c; c1++)
            {
                for (c2 = c1 + 1; c2 <= c; c2++)
                {
                    if (x[f, c1] > x[f, c2])
                    {
                        for (f1 = 1; f1 <= f; f1++)
                        {
                            aux = x[f1, c1];
                            x[f1, c1] = x[f1, c2];
                            x[f1, c2] = aux;
                        }
                    }
                }
            }
        }

        
        private int MayorFrecuencia(int col)
        {
            int f1, f2, cont, mayor, elem;

            mayor = 0;
            elem = x[1, col];

            for (f1 = 1; f1 <= f; f1++)
            {
                cont = 0;

                for (f2 = 1; f2 <= f; f2++)
                {
                    if (x[f1, col] == x[f2, col])
                    {
                        cont++;
                    }
                }

                if (cont > mayor)
                {
                    mayor = cont;
                    elem = x[f1, col];
                }
            }

            return elem;
        }


        //PREGUNTA 2 






    }
}
