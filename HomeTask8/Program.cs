using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Stack<Student> liststut = Generate();
            foreach (var item in liststut)
            {
                item.isTaskDan();
            }
            var cupOfCoffe = liststut.Where(x => x.task == 0);
            foreach (var item in cupOfCoffe)
            {
                item.GetCoffe();

            }
            Queue<Student> liststud = GenerateS();
            foreach (var item in liststud)
            {
                item.isTaskDan();
            }
            var cupOfCoffes = liststud.Where(x => x.task == 0);
            foreach (var item in cupOfCoffes)
            {
                item.GetCoffe();

            }
        }

        public static Queue<Student> GenerateS()
        {
            Queue<Student> list = new Queue<Student>();
            list.Enqueue(new Student("Влад", Task.Done));
            list.Enqueue(new Student("Джон", Task.Fail));
            list.Enqueue(new Student("Марта", Task.Done));
            list.Enqueue(new Student("Рома", Task.Fail));
            list.Enqueue(new Student("Моника", Task.Done));

            return list;

        }

        public static Stack<Student> Generate()
        {
            Stack<Student> list=new Stack<Student>();
            list.Push(new Student("Vlad", Task.Done));
            list.Push(new Student("John", Task.Fail));
            list.Push(new Student("Marta", Task.Done));
            list.Push(new Student("Roma", Task.Fail));
            list.Push(new Student("Monica", Task.Done));
            
            return list;
        }
        
    }
}
