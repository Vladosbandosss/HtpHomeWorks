using System;
using System.Linq;

namespace AtribandReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            //что б получить атр надо получ тип
            var type = typeof(Photo);//пол опис типа
            var attributes = type.GetCustomAttributes(false);
            foreach (var atrribute in attributes)
            {
                Console.WriteLine(atrribute);//получ знач атрибуда
            }
            Console.WriteLine();
            //получ наб свойств
            var properties = type.GetProperties();//возвр кол свойств класса
            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);
                 if(attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name + " " + prop.Attributes);//вывел свойства кот отмеч атрибутом
                }
                
               
              //  foreach (var a in attrs)
              //  {
               //     Console.WriteLine(a);
               // }
                
            }
            
        }
    }
}
