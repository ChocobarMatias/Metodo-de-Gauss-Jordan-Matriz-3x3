using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ===================================");
            Console.WriteLine(" Calculo de Metodo de Gauss - Jordan");
            Console.WriteLine(" ===================================");
            Console.WriteLine();
            int a1 = 0;
            int b1 = 0;
            int c1 = 0;
            int aux1 = 0;
            int aux2 = 0;
            int cont = 0;
            int cambio2 = 0;
            int[] x = new int[3];
            int[] y = new int[3];
            int[] z = new int[3];
            int[] b = new int[3];
            int[,] A = new int[3, 3];//Matriz del sistema
            int[,] B = new int[3, 1];//Matriz de terminos independientes
            int[,] X = new int[3, 1];//Matriz incognita
            int[,] AB = new int[3, 4];//Matriz ampliada

            // Console.WriteLine(" Agregar el numero de Ecuaciones = ");

            //Console.WriteLine(" A");
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                Console.WriteLine($" Agregar los coeficientes de las variables y el termino independiente de la {f + 1}° ecuacion");
                Console.WriteLine();

                for (int c = 0; c < 3; c++)
                {

                    if (c == 0)
                    {
                        Console.Write(" Agregar coeficiente de X = ");
                        A[f, c] = Int32.Parse(Console.ReadLine());
                    }
                    if (c == 1)
                    {
                        Console.Write(" Agregar coeficiente de Y = ");
                        A[f, c] = Int32.Parse(Console.ReadLine());
                    }
                    if (c == 2)
                    {
                        Console.Write(" Agregar coeficiente de Z = ");
                        A[f, c] = Int32.Parse(Console.ReadLine());
                    }
                    /*Console.Write(" Agregar termino independiente B = ");
                    b[i] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(" Presionar una tecla para continuar ....");
                     Console.ReadKey();
                    Console.Clear();*/
                }


                Console.Write(" Agregar termino independiente B = ");
                b[f] = Int32.Parse(Console.ReadLine());

            }

            /*Console.WriteLine(" Agregar los coeficientes de las variables y el termino independiente de la primera ecuacion");
            Console.WriteLine();
            Console.Write(" Agregar coeficiente de X = ");
            x1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Y = ");
            y1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Z = ");
            z1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar termino independiente B = ");
            b1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Presionar una tecla para continuar ....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" Agregar los coeficientes de las variables y el termino independiente de la segunda ecuacion"); ;
            Console.WriteLine();
            Console.Write(" Agregar coeficiente de X = ");
            x2 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Y = ");
            y2 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Z = ");
            z2 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar termino independiente B = ");
            b2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Presionar una tecla para continuar ....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" Agregar los coeficientes de las variables y el termino independiente de la tercera ecuacion");
            Console.WriteLine();
            Console.Write(" Agregar coeficiente de X = ");
            x3 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Y = ");
            y3 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar coeficiente de Z = ");
            z3 = Int32.Parse(Console.ReadLine());
            Console.Write(" Agregar termino independiente B = ");
            b3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Presionar una tecla para continuar ....");
            Console.ReadKey();
            Console.Clear();*/
            Console.WriteLine();
            Console.WriteLine(" Sistemas de Ecuaciones ");
            Console.WriteLine(" ------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     __");
            Console.WriteLine("    /");
            Console.WriteLine($"   |  {A[0, 0]}X + {A[0, 1]}Y + {A[0, 2]}Z = {b[0]}");
            Console.WriteLine("   |");
            Console.WriteLine($"  <|  {A[1, 0]}X + {A[1, 1]}Y + {A[1, 2]}Z = {b[1]}     ---->  A x X = B");
            Console.WriteLine("   |");
            Console.WriteLine($"   |  {A[2, 0]}X + {A[2, 1]}Y + {A[2, 2]}Z = {b[2]}");
            Console.WriteLine("     __");
            Console.WriteLine();
            Console.WriteLine(" . A es la Matriz del sistema ");
            Console.WriteLine(" . X es la Matriz de las incognitas");
            Console.WriteLine(" . B es la Matriz de los terminos independientes");
            Console.WriteLine();
            Console.WriteLine();
            //Console.Write(" A = ");
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                if (f == 1)
                {
                    Console.Write(" A = |");
                }
                else
                {
                    Console.Write("     |");
                }

                for (int c = 0; c < 3; c++)
                {
                    /* if (c==0)
                     {
                         A[f,c]=x[c];
                         Console.Write($"| {A[f, c]} ");
                     }
                     if (c==1)
                     {
                         A[f, c] = y[c];
                         Console.Write($" {A[f, c]}  ");
                     }
                     if (c==2)
                     {
                         A[f, c] = z[c];
                         Console.Write($" {A[f, c]} |");
                     }
                    /* if (c==3)
                     {
                         A[f, c] = b[f];
                     */
                    if (f == 1)
                    {
                        Console.Write($" {A[f, c]} ");
                    }
                    else
                    {
                        if (c != 0)
                        {
                            Console.Write($" {A[f, c]} ");
                        }
                        else
                        {
                            Console.Write($" {A[f, c]} ");
                        }
                    }
                }
                if (f != 1)
                {
                    if (f == 0)
                    {
                        Console.WriteLine($" |           | x |         | {b[f]} |");
                    }
                    if (f == 2)
                    {
                        Console.WriteLine($" |           | z |         | {b[f]} |");
                    }
                    // Console.WriteLine(" |            | x |");
                }
                else
                {
                    Console.WriteLine($" |  x    X = | y |  =  B = | {b[f]} |");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Armado de la Matriz ampliada  ----> ( A | B )");
            Console.WriteLine(" ---------------------------------------------  ");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                if (f == 1)
                {
                    Console.Write(" (A | B) = |");
                }
                else
                {
                    Console.Write("           |");
                }
                for (int c = 0; c < 4; c++)
                {
                    if ((c >= 0) && (c < 3))
                    {
                        AB[f, c] = A[f, c];
                        Console.Write($" {AB[f, c]} ");
                    }
                    if (c == 3)
                    {
                        AB[f, c] = b[f];
                        Console.WriteLine($" | {AB[f, c]} |");
                    }
                }
            }

            //solucion del sistema
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                aux1 = 0;
                aux2 = 0;
                cont = 0;
                for (int c = 0; c < 4; c++)
                {
                    if (f == 0)
                    {
                        if (AB[0, 0] != 0)
                        {
                            aux1 = (AB[1, 0] / AB[0,0]);
                            aux2 = (AB[2, 0] / AB[0, 0]);
                        }
                        AB[1, c] = AB[1, c] - ((AB[0, c]) * aux1);
                        AB[2, c] = AB[2, c] - ((AB[0, c]) * aux2);
                        Console.Write($" {AB[1,c]} - {AB[2, c]} ");
                        if (f == 1)
                        {
                            if (AB[1, 1] != 0)
                            {
                                b1 = AB[1, 1];
                                Console.Write($" b1 {b1} ");
                            }
                            AB[1, c] = (AB[1, c] / b1);


                            if (f == 2)
                            {
                                if (AB[2, 2] != 0)
                                {
                                    c1 = AB[2, 2];
                                }
                                AB[2, c] = (AB[2, c] / c1);

                            }
                        }
                    }
                }
            }
                        
         



            // Console.Write($" {AB[f,c]} | f = {f} -- c = {c} |");
            //aux1 = 0;
            //aux2 = 0;

            // aux1 = 0;
            // aux2 = 0;

            Console.WriteLine();
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($" {AB[f, c]} | ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"  x = {AB[0, 3]} y = {AB[1, 3]} z = {AB[2, 3]}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
