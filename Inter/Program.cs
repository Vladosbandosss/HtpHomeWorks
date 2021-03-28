using System;
using System.Collections.Generic;

namespace Inter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());
            foreach (var car in cars)
            {
                Console.WriteLine(car.Move(200)); 
            }
            Cyborg cyborg = new Cyborg();
            //метод Move мы не увидим даже что имплем 2 интера
            ((ICar)cyborg).Move(100);
            ((IPerson)cyborg).Move(100);
            //теперь все работает тк преобразовали,данные будут разные!
            
            

        }
    }
}
