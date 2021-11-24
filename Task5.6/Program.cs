using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите размер массива N");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }           

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            int[] Magic = new int[(2 * N + 2)];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Magic[i] += array[i, j];
                    Magic[i + N] += array[j, i];
                }
            }
            for (int j = 0; j < N; j++)
            {
                Magic[0 + 2 * N] += array[j, j];
                Magic[1 + 2 * N] += array[j, (N - j - 1)];
            }
            bool proverka = true;
            for (int i = 1; i < Magic.Length; i++)
            {
                if (Magic[0] != Magic[i])
                {
                    proverka = false;
                    break;
                }
            }

            if (proverka == false)
            {
                Console.WriteLine("Введённая матрица не является магическим квадратом.");
            }

            else
            {
                Console.WriteLine("Это магический квадрат!");
            }

            Console.WriteLine();

            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            
        }
    }
}
