using System;
using System.Collections.Generic;
using System.Text;

namespace AtribandReflect
{
    
   public class Photo
    {
        [Geo(10, 20)]//прикрепили атрибут будут прикреплены к кажлому экз клдасса

        public string Name { get; set; }
        public string Path { get; set; }
        public Photo(string name)
        {
            Name = name;
        }
    }
}
