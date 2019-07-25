using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Node<T>
        {
            public T value;
            public Node<T> next;
            public Node(T nodeInput)
            {
                value = nodeInput;
                next = null;
            }
        }
        static class LinkedList<T>
        {
            public static Node<T> Head;

            public static void Prepend( T prependValue)
            {
                Node<T> PrependThis = new Node<T>(prependValue);
                PrependThis.next = Head;
                Head = PrependThis;
                
            }
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
