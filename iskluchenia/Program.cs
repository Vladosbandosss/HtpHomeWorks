using System;

namespace iskluchenia
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                throw new MyOwnException();
            }
            catch(MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("деление на 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Какое то исключение");
            }
            finally
            {
                Console.WriteLine("Работа завершена");
            }
        }
    }
}
