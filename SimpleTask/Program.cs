using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите цифру");
            string chose = Console.ReadLine();
            int res = Convert.ToInt32(chose);
            var allmas = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            var firs = allmas.Where(x => res % 5 == 0);
            var second = allmas.Where(x => res%x == 0);
           

        }
    }
}
