using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_gauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler valor de vetor até o número determinado
            int[] Vetor = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(Vetor[i] + " ");
            }
            Console.WriteLine();
            // sequencia de fibonacci amarzenada no vetor os 10 primeiros números
            int[] Fibonacci = {1, 1, 2, 3, 5, 8, 13, 21, 35, 56};
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(Fibonacci[i] + " ");
            }
            Console.WriteLine();
            // multiplicação entre as matrizes
            int[] M = new int[3] { 5, 2, 4 };
            int[] A = new int[3] { 5, 6, 9 };
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(M[i] * A[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
