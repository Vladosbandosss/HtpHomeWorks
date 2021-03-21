using System;
using System.Collections.Generic;

namespace BigHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Влад", new List<int> { 1, 2, 3 });
            Student student2 = new Student("Рома", new List<int> { 2, 2, 2 });
            List<Student> all = new List<Student> { student, student2 };
            Group group = new Group(1,all);
            bool isOpen = true;
            var allmark = new List<int>();
            while (isOpen)
            {
                Console.WriteLine("Управление процессом");
               for (int i = 0; i <all.Count; i++)
                {
                    Console.Write(i + " ");
                    all[i].Info();
                }
                Console.WriteLine("Выберите номер студента");
               int userStud = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("что хотите сделать");
                Console.WriteLine("нажмите 1 для добаки оценки");
                Console.WriteLine("нажмите 2 что б полностью удалить оценки и записать новые");
                Console.WriteLine("нажмите 3 что б удалить студента");
                Console.WriteLine("нажмите 4 что б добавить студента");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("введите сколько оценок");
                        int howmuchmarks1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Заполните оценки");
                        for (int i = 0; i < howmuchmarks1; i++)
                        {
                            int marks = Convert.ToInt32(Console.ReadLine());
                            all[userStud].marks.Add(marks);
                        }
                        for (int i = 0; i < all.Count; i++)
                        {
                            Console.Write(i + " ");
                            all[i].Info();
                        }





                        break;
                    case 2:

                        Console.WriteLine("введите сколько оценок");
                        int howmuchmarks = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Заполните оценки");
                        all[userStud].marks.Clear();
                        for (int i = 0; i < howmuchmarks; i++)
                        {
                            int marks = Convert.ToInt32(Console.ReadLine());
                            all[userStud].marks.Add(marks);
                        }

                        for (int i = 0; i < all.Count; i++)
                        {
                            Console.Write(i + " ");
                            all[i].Info();
                        }



                        break;
                    case 3:
                        Console.WriteLine("введите номер студента которого хотите удалить");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        all.Remove(all[numb]);
                        for (int i = 0; i < all.Count; i++)
                        {
                            Console.Write(i + " ");
                            all[i].Info();
                        }





                        break;
                    case 4:
                        Console.WriteLine("Давайте добавим студента");
                        Console.WriteLine("Введите емя студента");
                        string names = Console.ReadLine();
                        Console.WriteLine("сколько оценок добавим?");
                        int how = Convert.ToInt32(Console.ReadLine());
                        List<int> mark = new List<int>();
                        Console.WriteLine("вводи");
                        for (int i = 0; i < how; i++)
                        {
                            int vvod = Convert.ToInt32(Console.ReadLine());
                            mark.Add(vvod);
                        }
                        Student s = new Student(names, mark);
                        all.Add(s);
                        for (int i = 0; i < all.Count; i++)
                        {
                            Console.Write(i + " ");
                            all[i].Info();
                        }







                        break;
                    default:
                        Console.WriteLine("ошибка");
                        break;
                }



                Console.WriteLine("нажмите любую клавишу для продолжения");

                Console.ReadKey();
               // Console.Clear();
            }
        }
    }
}
