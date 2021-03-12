using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //класс list
            var intlist = new List<int> { 1, 4, 6, 7, 5, 9 };
            intlist.Add(7);//добавил в массив в конец 7
            int[] array = { 1, 2, 3 };
            intlist.AddRange(array);//добавил массив в List
            intlist.Remove(2);//удаляет 1 двойку
            if (intlist.Remove(3))
            {

            }
            else
            {

            }
            intlist.RemoveAt(5);//УДАЛЯЕТ ЧЕИСЛО 5 ИНДЕКС
            intlist.Reverse();
            bool cont = intlist.Contains(3);
            int nim = intlist.Min();
            int max = intlist.Max();
            int indesof = intlist.IndexOf(2);
            int lastind = intlist.LastIndexOf(30);
            for (int i = 0; i < intlist.Count; i++)
            {
                Console.WriteLine(intlist[i]);
            }
            
            //Dictinory
            var people = new Dictionary<int, string>();
            people.Add(1, "Vlad");//ключ всегда должен быть разный 1 значение
            people.Add(2, "BOb");
            people.Add(3, "Alice");
            string name = people[1];//доступ по ключу
                                    //Console.WriteLine(name);//vlad
                                    // var keys = people.Keys;
            Dictionary<int, string>.KeyCollection keys = people.Keys;//по колючам
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            foreach (var pair in people)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
            Console.WriteLine(people.Count);
            bool cont = people.ContainsKey(2);//есть ли ключ 2
            bool value = people.ContainsValue("Vlad");//есть ли знач влад
            people.Remove(1);//удаляет 1 ключ и значение с ним
           
            if(people.TryAdd(2, "pjz"))
            {
                Console.WriteLine("add");
            }
            else
            {
                Console.WriteLine("fail");
            }
            if (people.TryGetValue(2,out string val))
            {
                Console.WriteLine("успешно нашел");
                Console.WriteLine(val);
            }
            else
            {
                Console.WriteLine("fail to get");
            }
            people.Clear();
            
            //стэк и очередь
            //стэк
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);//добавляем
            Console.WriteLine(stack.Peek());//прост показываем
            Console.WriteLine();
            stack.Pop();//показ и удаляет
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var que = new Queue<int>();
            que.Enqueue(1);
            que.Enqueue(1);
            que.Enqueue(1);
            Console.WriteLine(que.Peek());
            que.Dequeue();
            Console.WriteLine();
            foreach (var item in que)
            {
                Console.WriteLine( item);
            }
            */
           
           //int last = Convert.ToInt32(n.ToString().AsEnumerable().Last().ToString());
            
            
            var list = new List<int> { 1, 44, 79, 5 };
            var res = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                res.Add(Convert.ToInt32(list[i].ToString().AsEnumerable().Last().ToString()));
            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("тест");

            var list2 = new List<int> { 1, 3, 6, 5, 4, 1, 3, 5, 6 ,4,2,3,3,3};
            list2.Sort();
            
            var res2 = new Dictionary<int, int>();
         
            

        }
    }
}
