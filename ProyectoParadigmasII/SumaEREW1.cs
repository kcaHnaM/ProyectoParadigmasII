/*using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoParadigmas
{
    internal class SumaEREW
    {
        static async Task Main(String[] args)
        {
            int[] A = new int[] {5,2,10,1,8,12,7,3};
            int n = A.Length;

            var task = new Task(
                ()=>
                {
                    for(int i = 1; i <= Convert.ToInt32(Math.Log(n,2)) + 1; i++)
                    {
                        Console.Write("["+A[i-1]+"]");
                        Parallel.For(1, n/2,
                            j => {
                                if(((j *2) % Convert.ToInt32(Math.Pow(2,i))) == 0){
                                    A[2*j] = A[2*j] + A[2*j + Convert.ToInt32(Math.Pow(2,(i-1)))];
                                    Console.Write("["+A[i]+"]");
                                }
                                Console.Write("["+A[i]+"]");
                            });
                            Console.Write("["+A[i]+"]");
                            Console.Write("\n");
                    }
                    Console.WriteLine("Suma: "+A[8]);
                }
            );
            task.Start();
            await task;
        }
    }
}*/