using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTask
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("выберите цифру");
            //string chose = Console.ReadLine();
            //int res = Convert.ToInt32(chose);
            //var allmas = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            //var firs = allmas.Where(x => res % 5 == 0);
           // var second = allmas.Where(x => res%x == 0);


            var mas =new List<int> { 1,2,3,4,5,6,7,8,9 };
            var first = new List<int>();
            var second = new List<int>();

            for (int i = 0; i < mas.Count; i++)
            {
                Console.WriteLine("число " + mas[i]);

                for (int j = 0; j < mas.Count; j++)
                {
                    if (mas[i] % mas[j] == 0)
                    {
                        first.Add(mas[i]);
                        Console.WriteLine("делится на" + mas[i]);
                    }
                    if (mas[j] % mas[i] == 0)
                    {
                        second.Add(mas[i]);
                        Console.WriteLine("на него делится:" + mas[i]);
                    }
                }
                

            }
    }
}
