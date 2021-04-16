using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 найти 3 самых больших элемента в массива
            var first = new List<int> { 5, 9, 1, 0, 7 };
            var firstres = first.OrderByDescending(x => x).Take(3);
            //Task2 исключить из массива 2 наименьших
            var second = new List<int> { 5, 9, 1, 0, 7, 15 };
            var secondres = second.OrderBy(x => x).Skip(2);
            //Task3 верпнуть сумм четных и нечетных знач
            var third = new List<int> { 3, 4, 5, 6, 7 };
          var res3 =   fortafk3(third);
            //Task4 посчит ср знач искл макс и мин
            var four = new List<int>{ 4,3,5,1,2};
            var fourres = four.OrderBy(x => x).Skip(1).OrderByDescending(x => x).Skip(1).Average();
            //task5 из строки удалить все глассные
            var five = new List<string> { "lol" };
            var bukva = new HashSet<char>("aeiou"); 

            var fiveres = from test in five
                             select new string(test.Where(c => !bukva.Contains(c)).ToArray());

            //task6 из исходного списка возвести четные х2 нечет х3
            var six = new List<int> { 1, 2, 3, 4, 5 };
            var result6 = sixtask(six);
           
            

           






        }

        public static List<int> fortafk3(List<int> list)
        {
            var thirdresadd = list.Where(x => x % 2 == 0).Sum();
            var thirdresnoadd = list.Where(x => x % 2 != 0).Sum();
            var thirdalll = new List<int>();
            thirdalll.Add(thirdresnoadd);
            thirdalll.Add(thirdresadd);


            return thirdalll;
        }

        public static List<int> sixtask(List<int> list)
        {
            var bigsix = new List<int>();
            var sixres1 = list.Where(x => x % 2 == 0).Select(x => x * x);
            
            var sixres2 = list.Where(y => y % 2 != 0).Select(y => y * y * y);
            bigsix = sixres1.Union(sixres2).ToList();
            

            return bigsix;
        }
    }
}
