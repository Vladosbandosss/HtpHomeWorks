using System;
using System.Collections.Generic;
using System.Text;

namespace iskluchenia
{
    class MyOwnException : Exception
    {
        public MyOwnException():base("это мое исключение")
        {
            
        }
        public MyOwnException(string mes):base(mes)
        {
            
        }

    }
}
