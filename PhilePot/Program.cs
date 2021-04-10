using System;
using System.IO;

namespace PhilePot
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw=new StreamWriter("test.txt",false))//true будем пост добавлять езе кодировку можно добавить
            {
                sw.Write("Hello");
                sw.WriteLine();
                sw.Write("i am tom");
            }
            using(var sr=new StreamReader("test.txt"))//все считали
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            using (var sr = new StreamReader("test.txt"))//счит по строкам
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine()+ " конец строки");
                }
               
            }

        }
    }
}
