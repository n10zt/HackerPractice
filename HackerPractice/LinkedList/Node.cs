﻿namespace HackerPractice.LinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T d)
        {
            data = d;
            next = null;
        }
    }
}
