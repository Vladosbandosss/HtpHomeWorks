using System;

namespace Nasled
{
    
    class Program
    {
        static void PrinFull(Person p)
        {
            Console.WriteLine(p.FirstName + " " +  p.LastName);
        }
        static void Main(string[] args)
        {
            Person person = new Person("влад", "булахов");
            person.PrintName();
            Student student = new Student("рома", "бочкарев", 20);
            student.PrintName();
            student.Lern();
            PrinFull(student);
            
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string name,string lest)
        {
            FirstName = name;
            LastName = lest;
        }
        public void PrintName()
        {
            Console.WriteLine("меня зовут " + FirstName);
        }
    }
    class Student : Person
    {
        public int Age { get; set; }
        public Student(string name, string lest,int age) : base(name, lest)
        {
            Age = age;
        }

        public void Lern()
        {
            Console.WriteLine("я учусь");
        }

    }
  
    
}
