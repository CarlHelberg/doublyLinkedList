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

            public void Prepend(T _value)
            {
                Node<T> PrependThis = new Node<T>(_value);
                PrependThis.next = Head;
                Head = PrependThis;
                Length++;
  
            }
            public void Traverse()
            {
                var tempValue = Head;
                while(tempValue != null)
                {
                    
                    System.Console.WriteLine(tempValue.value);
                    tempValue = tempValue.next; 
                }
            }
        }
      
        static void Main(string[] args)
        {
           
        }
    }
}