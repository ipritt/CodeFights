using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsListPalindrome
{
    class Program
    {
        public class ListNode<T>
        {
            public ListNode() { }
            public ListNode(int i) { Value = i; }
            public int Value { get; set; }
            public ListNode<T> Next { get; set; }
        }

        public class LinkedList
        {
            public ListNode<int> Head { get; private set; }
            private ListNode<int> Last;

            public void Add(int i)
            {
                ListNode<int> n = new ListNode<int>(i);
                n.Value = i;
                n.Next = null;
                if (Last == null)
                {
                    Head = n;
                    Last = n;
                }
                else
                {
                    Last.Next = n;
                    Last = n;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 2, 3 };
            LinkedList list = new LinkedList();
            foreach (int item in ints)
            {
                ListNode<int> j = new ListNode<int>(item);
                list.Add(j.Value);
            }
            Console.WriteLine(IsListPalindrome(list.Head));
            Console.ReadLine();
        }

        static bool IsListPalindrome(ListNode<int> l)
        {
            bool isPali = true;
            List<int> list = new List<int>();
            while(l != null)
            {
                list.Add(l.Value);
                l = l.Next;
            }
            int a = 0;
            int b = list.Count - 1;
            while(a < b)
            {
                if (list[a] != list[b])
                    isPali = false;
                a++;
                b--;
            }
            return isPali;
        }
    }
}
