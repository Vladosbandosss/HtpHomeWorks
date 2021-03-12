using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTaskCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 44, 79, 5 };
            var res = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                res.Add(Convert.ToInt32(list[i].ToString().AsEnumerable().Last().ToString()));
            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("тест");

            var list2 = new List<int> { 1, 3, 6, 5, 4, 1, 3, 5, 6, 4, 2, 3, 3, 3 };
            list2.Sort();

            for (int i = 0; i < 10; i++)
            {
                var test = list2.Where(x => x == i).ToArray();
                int answer = test.Count();
                Console.WriteLine("Цифра " + i + " встречается " + answer + " раз");

            }
        }
    }
}
