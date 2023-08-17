using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_Gauss_Jordan
{

    //CHOCOBAR MATIAS SEBASTIAN
    //LEGAJO 59234

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ==============================================");
            Console.WriteLine(" Calculo de Metodo de Gauss - Jordan Matriz 3x3");
            Console.WriteLine(" ==============================================");
            Console.WriteLine();
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            double aux1 = 0;
            double aux2 = 0;
            double suma1 = 0;
            double suma2 = 0;
            double suma3 = 0;
            int cont = 0;
            double cambio = 0;
            double[] b = new double[3];
            double[,] A = new double[3, 3];//Matriz del sistema
            int[,] B = new int[3, 1];//Matriz de terminos independientes
            int[,] X = new int[3, 1];//Matriz incognita
            double[,] AB = new double[3, 4];//Matriz ampliada

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
                }
                Console.Write(" Agregar termino independiente B = ");
                b[f] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para continuar ...");
            Console.ReadKey();
            Console.Clear();
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
                }
                else
                {
                    Console.WriteLine($" |  x    X = | y |  =  B = | {b[f]} |");
                }

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para continuar ...");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
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
                if (f == 0)
                {
                    if (AB[0, 0] != 0)
                    {
                        a1 = AB[0, 0];
                    }
                    else//prueba
                    {

                        if (AB[1, 0] != 0)
                        {
                            if (AB[1, 0] <= AB[2, 0])
                            {
                                do
                                {
                                    cambio = AB[0, cont];
                                    AB[0, cont] = AB[1, cont];
                                    AB[1, cont] = cambio;
                                    cont++;
                                } while (cont <= 3);
                                a1 = AB[0, 0];
                            }
                            else
                            {
                                do
                                {
                                    cambio = AB[0, cont];
                                    AB[0, cont] = AB[2, cont];
                                    AB[2, cont] = cambio;
                                    cont++;
                                } while (cont <= 3);
                                a1 = AB[0, 0];
                            }
                        }
                        else
                        {
                            
                          if (AB[1, 0] < AB[2, 0])
                                {
                                do{ 
                                    cambio = AB[0, cont];
                                    AB[0, cont] = AB[2, cont];
                                    AB[2, cont] = cambio;
                                    cont++;
                                   } while (cont <= 3) ;
                                a1 = AB[0, 0];
                                 }
                            else
                            {
                                do { 
                                cambio = AB[0, cont];
                                AB[0, cont] = AB[2, cont];
                                AB[2, cont] = cambio;
                                cont++;
                                } while (cont <= 3);
                                a1 = AB[0, 0];
                            }
                        }

                    }
                }
                if (AB[1, 1] != 0)
                {
                    b1 = AB[1, 1];
                }
                if (AB[2, 2] != 0)
                {
                    c1 = AB[2, 2];
                }

                for (int c = 0; c < 4; c++)
                {
                    if (f == 0)//Busco el 1° pivote y sus ceros
                    {
                        AB[0, c] = (AB[0, c] / a1);

                        if (AB[0, 0] == 1)
                        {
                            if (AB[1, 0] != 0)
                            {
                                aux1 = AB[1, 0];
                            }
                            AB[1, c] = AB[1, c] - ((AB[0, c]) * aux1);
                            if (AB[2, 0] != 0)
                            {
                                aux2 = AB[2, 0];
                            }
                            AB[2, c] = AB[2, c] - ((AB[0, c]) * aux2);
                        }
                    }
                    if (f == 1)//Busco el 2° pivote y sus ceros
                    {
                        AB[1, c] = (AB[1, c] / b1);
                        if (AB[1, 1] == 1)
                        {
                            if (AB[0, 1] != 0)
                            {
                                aux1 = AB[0, 1];
                            }
                            AB[0, c] = AB[0, c] - ((AB[1, c]) * aux1);
                            if (AB[2, 1] != 0)
                            {
                                aux2 = AB[2, 1];
                            }
                            AB[2, c] = AB[2, c] - ((AB[1, c]) * aux2);
                        }

                    }
                    if (f == 2)//Busco el 3° pivote y sus ceros
                    {
                        AB[2, c] = (AB[2, c] / c1);

                        if (AB[2, 2] == 1)
                        {
                            if (AB[0, 2] != 0)
                            {
                                aux1 = AB[0, 2];
                            }
                            AB[0, c] = AB[0, c] - ((AB[2, c]) * aux1);
                            if (AB[1, 2] != 0)
                            {
                                aux2 = AB[1, 2];
                            }
                            AB[1, c] = AB[1, c] - ((AB[2, c]) * aux2);
                            
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;//cmabia de color el fondo
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Solucion de Matriz ampliada");
            Console.WriteLine(" ----------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
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
                        Console.Write($" {AB[f, c]} ");
                    }
                    if (c == 3)
                    {
                        Console.WriteLine($" | {AB[f, c]} |");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Presionar una tecla para continuar ...");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Verificacion de Igualdad del sistema ");
            Console.WriteLine(" =====================================");
            Console.WriteLine();
            Console.WriteLine();

           suma1 = (AB[0, 3] * A[0, 0]) + (AB[1, 3] * A[0, 1]) + (AB[2, 3] * A[0, 2]);
           if (suma1 == b[0])
            {
                Console.WriteLine();
                Console.WriteLine($"   ({A[0, 0]} * {AB[0, 3]}) + ({A[0, 1]} * {AB[1, 3]} ) + ({A[0, 2]} * {AB[2, 3]}) = {b[0]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Error - Sistema de ecuaciones no se cumple la igualdad .");
                Console.WriteLine();
            }
                 
            suma2 = (AB[0, 3] * A[1, 0]) + (AB[1, 3] * A[1, 1]) + (AB[2, 3] * A[1, 2]);
            if (suma2 == b[1])
            {
                Console.WriteLine();
                Console.WriteLine($"   ({A[1, 0]} * {AB[0, 3]}) + ({A[1, 1]} * {AB[1, 3]}) + ({A[1, 2]} * {AB[2, 3]}) = {b[1]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Error - Sistema de ecuaciones no se cumple la igualdad .");
                Console.WriteLine();
            }

            suma3 = (AB[0, 3] * A[2, 0]) + (AB[1, 3] * A[2, 1]) + (AB[2, 3] * A[2, 2]);
            if (suma3 == b[2])
            {
                Console.WriteLine();
                Console.WriteLine($"   ({A[2, 0]} * {AB[0, 3]}) + ({A[2, 1]} * {AB[1, 3]}) + ({A[2, 2]} * {AB[2, 3]}) = {b[2]}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Error - Sistema de ecuaciones no se cumple la igualdad .");
                Console.WriteLine();
            }
            if ((suma1==b[0]) && (suma2==b[1]) && (suma3==b[2]))
            {
                Console.WriteLine();
                Console.WriteLine($"  Solucion del Sistema x = {AB[0, 3]},  y = {AB[1, 3]},  z = {AB[2, 3]} ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" No se cumplen las igualdades por lo tanto el Sistemas Incompatible sin solucion ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" ===============");
            Console.WriteLine(" Fin del Proceso");
            Console.WriteLine(" ===============");
            Console.ReadKey();
        }
    }
}
