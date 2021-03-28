using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class LadaSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
