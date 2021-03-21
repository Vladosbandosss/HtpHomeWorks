using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlad = new HashVlad<int,string>(100);
            vlad.Add(5, "привет");
            vlad.Add(18, "мир");
            vlad.Add(777, "Здравствуйт");
            vlad.Add(7, "Прогер");
            Console.WriteLine(vlad.Search(6,"Вася"));
            Console.WriteLine(vlad.Search(18,"мир"));


        }
    }
}
