using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите размер массива N");
            N = Convert.ToInt32(Console.ReadLine());

            int [,] array = new int[N,N];

            /* пробовал на массиве с элементами типа bool выполнить задачу, получилось, но false и true при выводе на печате не похожи на требуемый результат
            array[0, 0] = true;
            for (int i = 0; i < N; i++)
            {
                if (i > 0)
                {
                    array[i, 0] = !array[i - 1, 0];
                }
                for (int j = 1; j < N; j++)
                {
                    array[i, j] = !array[i,j-1] ;
                }
            }
            */
            for (int i = 0; i < N; i++)
            {
               for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j)%2;
                }
            }

            Console.WriteLine("Массив");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine();
            }        

            Console.WriteLine();

            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
