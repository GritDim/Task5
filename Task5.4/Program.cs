using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;

            int[] array = new int[n];
            Random random = new Random();

            Console.WriteLine("Изначальный массив");

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);

            }

            Console.WriteLine("Массив");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            int count = 0;


            for (int i = 1; i < n;)
            {
                             
                if ((array[i]>0) && (array[i]%2 != 0))
                {
                    count += 1;
                }

                 i += 2;
            }


            Console.WriteLine();
            Console.WriteLine("Колличество нечетных положительных элементов, стоящих на четных местах - {0}", count);
           
            Console.WriteLine();

            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
