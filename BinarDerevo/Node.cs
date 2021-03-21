using System;
using System.Collections.Generic;
using System.Text;

namespace BinarDerevo
{
    class Node<T> : IComparable
        where T:IComparable // позволяет реализ сравнения(влева вправо идти при поиске и тд)
    {
        public T Data { get; set; }
        public Node<T> Left { get;private  set; }
        public Node<T> Roght{ get; private set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Roght = right;
        }

        public int CompareTo(object obj)
        {
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new Exception("не совпадение типов");
            }
        }
    }
}
