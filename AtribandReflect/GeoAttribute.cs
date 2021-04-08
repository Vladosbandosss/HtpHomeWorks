
using System;
using System.Text;

namespace AtribandReflect
{
    
    class GeoAttribute : Attribute//наслед  ///рефлексия основа работа с атрибутами
    {
        public int X { get; set; }
        public int Y { get; set; }
        public GeoAttribute()
        {

        }
        public GeoAttribute(int x,int y)
        {
            X = x;
            Y = y;
        }//создалши прост атрибьут

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
}
