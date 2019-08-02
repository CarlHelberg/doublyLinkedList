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

            private object GetIndex(int _index)
            {
                var IndexReturn = Head;
                for(int i = 0; i < Length; i++)
                {
                    if (i == _index)
                    {
                        return IndexReturn.value;
                    }
                    IndexReturn = IndexReturn.next;
                }
                throw new Exception(" The index you are looking for does not exist");

            }
            
            public object this[int _index]
            {
                get
                {
                    return (GetIndex(_index));
                }
            }
        }    
        static void Main(string[] args)
        {
           
        }
    }
}