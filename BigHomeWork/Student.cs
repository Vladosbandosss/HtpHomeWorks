using System;
using System.Collections.Generic;
using System.Text;

namespace BigHomeWork
{
    class Student
    {
        public string name;
        public List<int> marks;
        
        public Student(string name, List<int> mark)
        {
            this.name = name;
            marks = mark;
        }
        public void Info()
        {
            Console.WriteLine("имя "  + name );
            Console.WriteLine("оценки ");
            for (int i = 0; i < marks.Count; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
