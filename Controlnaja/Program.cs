﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlnaja
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 3
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
            list.Sort();
            list.Reverse();
            List <int> result = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result[i]);
            }
            //task 2
            string name = "валентин";
            string test = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i % 2 != 0)
                {
                    test += name[i];
                }
            }
            Console.WriteLine(test);


            //task1
            int[,,] mas = { { { 1,2}, {3,4 } }  ,
                { { 4,5}, {6,7 } }  ,
                { { 7,8}, {9,10 } }  ,
                { { 10,11}, {12,13 } }  ,
                                    };

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{" + " ");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{" + " ");

                    for (int k = 0; k < mas.GetLength(2); k++)
                    {
                       

                       Console.Write( mas[i,j,k] + " ," );

                      
                    }
                    Console.Write("}" + " ");


                    Console.Write("}" + " ");


                }
               

            }
            

            

        }
    }
}
