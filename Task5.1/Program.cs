using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int Min;
            int Max;
            int[] array = new int[n];
            Random random = new Random();

            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
            }
            
            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Min = array[1];
            Max = array[1];


            for (int i = 0; i < (n-1); i++)
            {
            
                if (array[i] < Min)
                {
                Min = array[i];
                }
                if (array[i] > Max)
                {
                    Max = array[i];
                }

            }

            Console.WriteLine();
            Console.WriteLine("Сумма минимального и максимального элементов массива - {0}", (Min+Max));
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
