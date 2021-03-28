using System;
using System.Collections.Generic;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int res = random.Next(0, 20);
                list.Add(res);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
   
}
