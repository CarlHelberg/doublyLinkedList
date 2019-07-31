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

            public bool DeleteAtIndex(uint _index)
            {
                var current = Head;
                var beforeDeleted = current.previous;
                var afterDeleted = current.next;

                if (_index < Length)
                {
                    if (_index == 0)
                    {
                        Head = current.next;
                        return true;
                    }
                    else 
                    {
                        beforeDeleted = current;
                        current = current.next;
                        afterDeleted = current.next;
                        for (int i = 0; i < Length; i++)
                        {

                            if (i + 1 == _index)
                            {
                                beforeDeleted = current;
                                current = current.next;
                                afterDeleted = current.next;
                                current.next = null;
                                current.previous = null;
                                beforeDeleted.next = afterDeleted;
                                afterDeleted.previous = beforeDeleted;
                                Length--;
                                return true;
                            }
                            beforeDeleted = current;
                            current = current.next;
                            afterDeleted = current.next;
                        }
                        return true;
                    }
                }
                else
                {
                    System.Console.WriteLine("The index you are trying to delete does not exist!");
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}