using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublyLinkedList
{
    class Program
    {
        class Node<T>
        {
            public object value;
            public Node<T> next;
            public Node<T> previous;
            private static object tempPrevious;

            public Node (T _value)
            {
                value = _value;
                next = null;
                
                if (LinkedList<T>.Length <= 1)
                {
                    previous = null;
                    tempPrevious = this;
                }
                else if(LinkedList<T>.Length > 1)
                {
                    previous = tempPrevious as Node<T>;
                    tempPrevious = this;
                }
            }
        }

        class LinkedList<T>
        {
            public static Node<T> Head;
            public static int Length = 0;
            
            public void Append(T _value)
            {
                Node<T> AppendThis = new Node<T>(_value);
                var tempValue = Head;
                if (LinkedList<T>.Length == 0)
                {
                    Head = AppendThis;
                    Length++;
                }
                if (Length > 0)
                {
                    while (tempValue != null)
                    {

                        if (tempValue.next == null)
                        {
                            tempValue.next = AppendThis;
                            Length++;
                            break;
                        }
                        tempValue = tempValue.next;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}