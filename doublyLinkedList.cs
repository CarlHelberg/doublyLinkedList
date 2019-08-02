using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublyLinkedList
{
    class Program
    {
        class DoublyLinkedList<T>
        {
            public class Node<T>
            {
                public object value;
                public Node<T> next;
                public Node<T> previous;

                public Node (T _value)
                {
                    value = _value;
                    next = null;
                    previous = null;
                }
            }

            public Node<T> Head;
            public int Length = 0;

        }    
        static void Main(string[] args)
        {
           
        }
    }
}