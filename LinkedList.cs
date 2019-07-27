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
         class  LinkedList<T>
        {
            public   Node<T> Head;
            public   int Length = 0;

            public  void Prepend( T prependValue)
            {
                Node<T> PrependThis = new Node<T>(prependValue);
                PrependThis.next = Head;
                Head = PrependThis;
                Length++;
            }

            public override string ToString()
            {
                string toReturn = "(";
                var tempValue = Head;
                var tempNext = tempValue.next;
                while(tempValue != null)
                {
                    tempNext = tempValue.next;
                    toReturn += tempValue.value;
                    if(tempNext != null)
                    {
                        toReturn += ", ";
                    }
                    tempValue = tempValue.next; 
                }
                toReturn += ")";
                System.Console.WriteLine(toReturn);
                return toReturn;
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
        
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> thisDamnList = new LinkedList<int>();
            thisDamnList.Prepend(2);
            thisDamnList.Prepend(456);
            thisDamnList.Prepend(56);
            thisDamnList.Prepend(5);
            thisDamnList.Prepend(564);
            thisDamnList.Prepend(34);
            thisDamnList.Prepend(76);
            System.Console.WriteLine("Done appending");
            thisDamnList.ToString();
            Console.Read();
        }
    }
}
