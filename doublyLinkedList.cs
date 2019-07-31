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

            public Node (T _value)
            {
                value = _value;
                next = null;
                previous = null;
            }
        }

        class DoublyLinkedList<T>
        {
            public Node<T> Head;
            public int Length = 0;
            
            public bool InsertAfterIndex(int _index , T _value)
            {
                var current = Head;
                var tempNext = current.next;
                if(_index >= Length)
                {
                    System.Console.WriteLine("The index specified does not exist.\n Please try again with InsertAfterIndex(index, value)!");
                    return false;
                }
                Node <T> insertThis = new Node<T>(_value);
                if(_index == 0)
                {
                    tempNext = current.next;
                    insertThis.next = current.next;
                    Head.next = insertThis;
                    insertThis.previous = Head;
                    return true;
                }
                current = Head.next;
                tempNext = current.next;
                for(int i = 1; i < Length; i++)
                {
                    if( i == _index)
                    {
                        current.next = insertThis;
                        insertThis.next = tempNext;
                        insertThis.previous = current;
                        return true;
                    }
                    current = current.next;
                    tempNext = current.next;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}