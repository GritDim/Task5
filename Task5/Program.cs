using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int Summ = 0;
            int[] array = new int[n];
           
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());                                 
            }
            Console.WriteLine();
            Console.WriteLine("Введённый массив");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
                Summ += array[i]; 
            }

            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива {0}", (Summ / n));
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
