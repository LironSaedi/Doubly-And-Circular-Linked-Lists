using System;
using System.Collections.Generic;
using System.Text;

namespace Doubly_And_Circular_Linked_Lists
{

    public class Node<T>
    {
        public T Value;
        public Node <T> Next;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value,  Node <T> next)
        {
            Value = value;
            Next = next;
        }


        int Count = 0;
        Node <T> Head;
        Node <T> Tail;


    }
}
