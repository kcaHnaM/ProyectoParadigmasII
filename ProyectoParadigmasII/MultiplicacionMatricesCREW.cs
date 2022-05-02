/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace MultiMatiz
{
    class MultiMatiz
    {
        public static int n;
        public static int[,] A, B;
        public static int[,,] C;
        static async Task Main(String[] args)
        {
            n = 2;
            A = new int[n + 1, n + 1];
            B = new int[n + 1, n + 1];
            C = new int[n + 1, n + 1, n + 1];
            MultiMatiz mm = new MultiMatiz();

            Console.Clear();
            Console.WriteLine("\t\tSUMA EREW\n\n"
                                +"\tEquipo No Me Acuerdo xd\n");

            Console.WriteLine("Espera un segundo...");

            string linea;
            Console.Write("Ingrese valor 1,1 de la matriz A: ");
            linea = Console.ReadLine();
            A[1, 1] = int.Parse(linea);
            Console.Write("Ingrese valor 1,2 de la matriz A: ");
            linea = Console.ReadLine();
            A[1, 2] = int.Parse(linea);
            Console.Write("Ingrese valor 2,1 de la matriz A: ");
            linea = Console.ReadLine();
            A[2, 1] = int.Parse(linea);
            Console.Write("Ingrese valor 2,2 de la matriz A: ");
            linea = Console.ReadLine();
            A[2, 2] = int.Parse(linea);

            Console.Write("\nIngrese valor 1,1 de la matriz B: ");
            linea = Console.ReadLine();
            B[1, 1] = int.Parse(linea);
            Console.Write("Ingrese valor 1,2 de la matriz B: ");
            linea = Console.ReadLine();
            B[1, 2] = int.Parse(linea);
            Console.Write("Ingrese valor 2,1 de la matriz B: ");
            linea = Console.ReadLine();
            B[2, 1] = int.Parse(linea);
            Console.Write("Ingrese valor 2,2 de la matriz B: ");
            linea = Console.ReadLine();
            B[2, 2] = int.Parse(linea);


            Console.WriteLine("\nMatriz A: \n");
            await mm.MuestraMat(A);
            Console.WriteLine();
            Console.WriteLine("Matriz B: \n");
            await mm.MuestraMat(B);

            Parallel.For(1, n + 1, i =>
            {
                Parallel.For(1, n + 1, j =>
                {
                    Parallel.For(1, n + 1, k =>
                    {
                        C[i, j, k] = A[i, k] * B[k, j];
                    });
                });
            });

            for (int l = 1; l <= Math.Log(n, 2); l++)
            {
                Parallel.For(1, n + 1, i =>
                {
                    Parallel.For(1, n + 1, j =>
                    {
                        Parallel.For(1, (n / 2) + 1, k =>
                        {
                            if (((2 * k) % (int)Math.Pow(2, l)) == 0)
                            {

                                int r = C[i, j, 2 * k] + C[i, j, (2 * k) - (int)Math.Pow(2, l - 1)];

                                C[i, j, 2 * k] = C[i, j, 2 * k] + C[i, j, (2 * k) - (int)Math.Pow(2, l - 1)];
                            }
                        });
                    });
                });
            }
            
            await mm.resultado();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
            Console.Clear();
        }


        async Task MuestraMat(int[,] X)
        {
            await Task.Run(
                ()=>{
                    for (int i = 1; i <= 2; i++)
                    {
                        for (int j = 1; j <= 2; j++)
                        {
                            Console.Write(X[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            );
        }

        public async Task resultado()
        {
            await Task.Run(
                ()=>{
                    Console.WriteLine("RESULTADO: \n");
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            Console.Write(C[i, j, n] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            );
        }
    }
}*/