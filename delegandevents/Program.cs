using System;
//делагат это указатель на метод(проще для понимания)
namespace delegandevents
{
    //public delegate типвозвр имя (типаргумента аргумент);    объяв делегата
    

    class Program
    {
        public delegate int ValueDelegate(int i);//дел с агрум
        public delegate void MyDelegate();//задали сигнатуру делагат мож содержать набор метод один сигнатуры!                                       
        //шаблон делегаты 
      
      



        static void Main(string[] args)
        {
            #region delegate
            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate();//один раз вызвав делегат обра к 2 методам
            Console.WriteLine();
            MyDelegate myDelegate2 = new MyDelegate(Method1);
            myDelegate2 += Method1;//добавили метод
            myDelegate2 -= Method1;//удалили
            myDelegate2.Invoke();//другой способ но первый лучше и проще
            Console.WriteLine();
            MyDelegate myDelegate3 = myDelegate + myDelegate2;//создали нов делег с объуд 1 и 2
            myDelegate3.Invoke();
            Console.WriteLine();
            ValueDelegate valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate((new Random()).Next(10,50));//перед случ знач от 10 до 50 но перед во все методы!
            Console.WriteLine();

            Action action = Method1;//когда void и пуст скобки это action (это заготовка делагата)это синт сахар
            //может быть перегруж мож прин от 0 до 16 аргум!!!указ можем любые типы
            action += Method1;
            action();
            Console.WriteLine();
            Action<int> action2 = Method3;
            action2(5);
            Console.WriteLine();
            Predicate<int> predicate = Pred;//возвр bool и прин аргумент!мож задавать динамич
            predicate(5);
            Predicate<string> pred=PredS;
            pred("test");
            Console.WriteLine();
            Func<string,string,int> func;//от 1 до 16 типов тип возвр знач послед задается
            func = fun;
            func("hello", "world");//но надо проверять что б небыло null!!!!
            #endregion

            #region event

            Person person = new Person();
            person.Name = "Вася";
            person.DoWork += Person_DoWork;
            person.GoToSleep += Person_GoToSleep;
            person.TakeTime(10);
            person.TakeTime(2);
            #endregion

        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if(sender is Person)
            {
                Console.WriteLine(((Person)sender).Name + " работает");
            }
           
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("человек пошел спать");
           
        }

        public static int fun(string s,string ss)
        {
            Console.WriteLine(s + " " + ss);
            return 0;
        }
        public static bool Pred(int i)
        {
            Console.WriteLine(i);
            return true;
        }
        public static bool PredS(string i)
        {
            Console.WriteLine(i);
            return true;
        }
        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("Method1");

        }

        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }



    }
}
