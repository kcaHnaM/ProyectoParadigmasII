/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumaEREW
{
    internal class sumaEREW
    {
        int[] A = { 0, 5, 2, 10, 1, 8, 12, 7, 3 };
        int n = 8; 
        int i, j = 1, x;

        static async Task Main(String[] args)
        {
            sumaEREW suma = new sumaEREW();
            
            Console.Clear();
            Console.WriteLine("\t\tSUMA EREW\n\n"
                                +"\tEquipo No Me Acuerdo xd\n");

            Console.WriteLine("Espera un segundo...");
            await suma.Suma();
        }

        public async Task Suma() {
            await Task.Run(
                async ()=>{
                    Thread.Sleep(1000);
                    x = (int)(Math.Log(n, 2));

                    Console.Clear();
                    Console.WriteLine("\t\tSUMA EREW\n\n"
                                        +"\tEquipo No Me Acuerdo xd\n");

                    Console.Write("Valores Iniciales: ");
                    await printVector();

                    for (i = 1; i < x + 1; i++)
                    {
                        for (j = 1; j <= (n / 2); j++)
                        {
                            Parallel.For(0, 1, index => {  
                                if (((2 * j) % ((int)(Math.Pow(2, i)))) == 0)
                                {
                                    A[j * 2] = A[j * 2] + A[(j * 2) - (int)(Math.Pow(2, i - 1))];
                                }
                            });
                        }
                    }

                    Console.Write("\nValores Finales: ");
                    await printVector();

                    Console.WriteLine("\nSuma Total: " + A[n]);
                    Console.Write("\nPresione cualquier tecla para salir...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            );
        }
        public async Task printVector()
        {
            await Task.Run(
                ()=>{
                    Console.Write("[");
                    foreach (int z in A){
                        Console.Write("{0} ", z);
                    }
                    Console.Write("]\n");
                }
            );
        }
    }
}*/