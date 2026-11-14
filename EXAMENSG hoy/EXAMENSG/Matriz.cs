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
        //ejercicio 1
        public void Ejercicio1()
        {
            int f1, c1, f2, cont;
            bool ban;

            for (c1 = 1; c1 <= c; c1++)
            {
                cont = 0;

                for (f1 = 1; f1 <= f; f1++)
                {
                    ban = false;

                    for (f2 = 1; f2 < f1; f2++)
                    {
                        if (x[f1, c1] == x[f2, c1])
                        {
                            ban = true;
                        }
                    }

                    if (!ban)
                    {
                        cont++;
                    }
                }

                x[f + 1, c1] = cont;
            }

            f++;
        }




        //PREGUNTA 2 


        //ejercicio 2
        public void SegmentarTriangular()
        {
            int f1, c1, f2, c2;

            for (c1 = 1; c1 <= c - 1; c1++)
            {
                for (f1 = f - c1; f1 >= 1; f1--)
                {
                    for (c2 = c1; c2 <= c - 1; c2++)
                    {
                        if (c2 == c1)
                        {
                            f2 = f1 - 1;
                        }
                        else
                        {
                            f2 = f - c2;
                        }

                        for (; f2 >= 1; f2--)
                        {
                            if (x[f1, c1] % 2 != 0 && x[f2, c2] % 2 == 0)
                            {
                                intercambiar(f1, c1, f2, c2);
                            }
                            else if (x[f1, c1] % 2 == x[f2, c2] % 2)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                {
                                    intercambiar(f1, c1, f2, c2);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void intercambiar(int fil1, int col1, int fil2, int col2)
        {
            int aux;

            aux = x[fil1, col1];
            x[fil1, col1] = x[fil2, col2];
            x[fil2, col2] = aux;
        }

    }
}
