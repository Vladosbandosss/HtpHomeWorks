using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class HashVlad<Tkey,Tvalue>
    {
        private List<Tvalue>[] items;
        public HashVlad(int size)
        {
            items = new List<Tvalue>[size];
        }
        public void Add(Tkey key,Tvalue value)
        {
            var k = GetHash(key);
            if (items[k] == null)
            {
                items[k] = new List<Tvalue>{ value};
            }
            else
            {
                items[k].Add(value);

            }
           

        }
        public bool Search(Tkey key,Tvalue item)
        {
            var k = GetHash(key);
            return items[k]?.Contains(item)??false;

        }
        private int GetHash(Tkey key)
        {
            return Convert.ToInt32( key.ToString().Substring(0,1));
        }
    }
}
