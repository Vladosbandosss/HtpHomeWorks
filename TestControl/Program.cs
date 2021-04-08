using System;
using System.Collections.Generic;
using System.Linq;

namespace TestControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 числа фибоначи
            Fibonacci(7);
            //Task2 обратный порядок
            Console.WriteLine("введите число ");
            string chislo = Console.ReadLine();
            
            for (int i =chislo.Length-1; i >=0; i--)
            {
                Console.Write(chislo[i] + "");
            }
            Console.WriteLine();
          
            //Task3 
            var mas = new List<int> { 1, 5, -6, 7, -9 };
            for (int i = 0; i < mas.Count; i++)
            {
                Console.Write(mas[i]*-1 + " ");
            }
            Console.WriteLine();
            //Task4 больше чем элем перед ними
            var list = new List<int> { 3, 9, 8, 4, 5, 1,7};
            int size = list.Count();
            for (int i = 0; i < list.Count; i++)
            {
                if (i < size-1)
                {
                    if (list[i + 1] > list[i])
                    {
                        Console.Write(list[i + 1] + " ");
                    }
                }
                
            }
            Console.WriteLine();
            //Task5 хз
            //Task6 
            var bigres = new List<int> { 1, 5, 8, 6, 3, 9, 20 };
            int midle = bigres.Sum() / bigres.Count();
            var firstList = new List<int>();
            var secondList = new List<int>();
            for (int i = 0; i < bigres.Count; i++)
            {
                if (bigres[i] <= midle)
                {
                    firstList.Add(bigres[i]);
                }
                else
                {
                    secondList.Add(bigres[i]);
                }

            }
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Task7 не понял 


        }
        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int res;
            Console.Write(0+ " ");

            for (int i = 0; i < n-1; i++)
            {
                res = a;
                a = b;
                b += res;
                Console.Write(b + " ");
            }
            Console.WriteLine();

           
        }
    }
}
