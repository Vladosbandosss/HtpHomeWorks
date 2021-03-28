using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class BMWSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
