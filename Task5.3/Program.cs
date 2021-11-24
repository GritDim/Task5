using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
 
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

            int temp = 0;


            for (int i = 0; i < 4; i++)
            {
                for (int j = (i + 1); j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp; 
                    }
                }
            }

            for (int i = 5; i < 9; i++)
            {
                for (int j = (i + 1); j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }




            Console.WriteLine();
            Console.WriteLine("Массив упорядоченный");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }


            Console.WriteLine();
            
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
