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


        // PREGUNTA 1 repechaeje sb

        public void Ejercicio1(int fi, int ff, int ci, int cf)
        {
            bool ban = true;int f1, f2, inicioF2;
            for (int c1 = ci; c1 <= cf; c1++)
            {
                if (ban == false)
                {
                    for (f1 = fi; f1 <= ff; f1++)
                    {
                        for (int c2 = c1; c2 <= cf; c2++)
                        {
                            if (c2 == c1)
                                inicioF2 = f1;
                            else
                                inicioF2 = fi;

                            for (f2 = inicioF2; f2 <= ff; f2++)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                    Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
                else
                {
                    for (f1 = ff; f1 >= fi; f1--)
                    {
                        for (int c2 = c1; c2 <= cf; c2++)
                        {
                            if (c2 == c1)
                                inicioF2 = f1;
                            else
                                inicioF2 = ff;

                            for (f2 = inicioF2; f2 >= fi; f2--)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                    Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
                ban = !ban;
            }
        }

        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }



     

        //PREGUNTA 2 
        public void Ejercicio2(ref int ele, ref int frec)
        {
            int cont;

            ele = x[1, 2];   // 
            frec = 0;

            for (int i = 1; i <= f; i++)
            {
                for (int j = i + 1; j <= c; j++)
                {
                    cont = 0;

                    for (int ii = 1; ii <= f; ii++)
                    {
                        for (int jj = ii + 1; jj <= c; jj++)
                        {
                            if (x[i, j] == x[ii, jj])
                            {
                                cont++;
                            }
                        }
                    }

                    if (cont > frec)
                    {
                        frec = cont;
                        ele = x[i, j];
                    }
                }
            }
        }

































































        //public int Frecuencia(int ele)
        //{
        //    int cont = 0;

        //    for (int i = 1; i <= f; i++)
        //    {
        //        for (int j = i + 1; j <= c; j++) 
        //        {
        //            if (x[i, j] == ele)
        //            {
        //                cont++;
        //            }
        //        }
        //    }

        //    return cont;
        //}

        //public void Ejercicio2(ref int ele, ref int frec)
        //{
        //    int cont;

        //    ele = x[1, 2];
        //    frec = 0;

        //    for (int i = 1; i <= f; i++)
        //    {
        //        for (int j = i + 1; j <= c; j++)
        //        {
        //            cont = Frecuencia(x[i, j]);

        //            if (cont > frec)
        //            {
        //                frec = cont;
        //                ele = x[i, j];
        //            }
        //        }
        //    }
        //}


    }
}
