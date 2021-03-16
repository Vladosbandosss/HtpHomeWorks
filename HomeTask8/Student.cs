using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8
{
    class Student
    {
        public string name; 
        public Task task;
      public  Student(string name,Task task)
        {
            this.name = name;
            this.task = task;

        }
        public void GetCoffe()
        {
            Console.WriteLine(name + " получит кофе ");
        }
        public void isTaskDan()
        {
            if (task==0)
            {
                Console.WriteLine(name + " работа сдана");
            }
            else
            {
                Console.WriteLine(name + " работа не сдана");
                
            }
            
           
        }
        


    }
    enum Task
    {
        Done,
        Fail
    }
}
