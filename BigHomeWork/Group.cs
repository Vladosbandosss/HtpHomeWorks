using System;
using System.Collections.Generic;
using System.Text;

namespace BigHomeWork
{
    class Group
    {
        public int number;
        public List<Student> student;
        public Group(int number,List<Student>person)
        {
            this.number = number;
            student = person;
        }
    }
}
