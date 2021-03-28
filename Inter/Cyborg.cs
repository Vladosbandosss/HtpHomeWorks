using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Cyborg : ICar, IPerson
    {
        //реализ явно интерфейсы
        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distanse)
        {
            return distanse / 5;
        }
    }
}
