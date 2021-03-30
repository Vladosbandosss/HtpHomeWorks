using System;
using System.Collections.Generic;
using System.Linq;

namespace delegat
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate int Average(List<double> list);
        delegate void Say();
        static void Main(string[] args)
        {
            
            Math math = new Math();
            Operation s = math.Sum;
            int res = s(4, 5);
            Console.WriteLine(res);
            Operation r = math.Raz;
            int res2 = r(5, 2);
            Console.WriteLine(res2);
            
            Say hello = math.SayHello;
            hello();
           
            Say buy = math.SayBuy;
            buy();
            Average aver = math.Av;
            List<double> l = new List<double> { 1.0, 5.0, 2.0 };
           Console.WriteLine(aver(l));
       
           
}
    }      
    class Math
    {
       
        public int Av(List<double> list)
        {
            double sum = 0;
            int res = list.Count + 1;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            int finres = (int)(sum / res);
            return finres;
        }
        public int Sum(int x, int y) { 
            return x + y; 
        }
        public int Raz(int x,int y)
        {
            return x - y;
        }
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
        public void SayBuy()
        {
            Console.WriteLine("GoodBuy");
        }
    }
}
