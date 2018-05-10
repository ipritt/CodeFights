using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFromList
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
        private ListNode<int> head;
        private ListNode<int> last;

        public ListNode<int> First
        {
            get { return head; }
        }

        public void Add(int i)
        {
            ListNode<int> n = new ListNode<int>(i);
            n.Value = i;
            n.Next = null;
            if(last == null)
            {
                head = n;
                last = n;
            }
            else
            {
                last.Next = n;
                last = n;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int k = 1000;
            int[] ints = { 1000, 1000 };
            LinkedList list = new LinkedList();
            foreach (int item in ints)
            {
                ListNode<int> j = new ListNode<int>(item);
                list.Add(j.Value);
            }
            RemoveKFromList(list.First, k);
            Console.ReadLine();
        }
        
        static ListNode<int> RemoveKFromList(ListNode<int> l, int k)
        {
            ListNode<int> temp = new ListNode<int>();
            temp.Next = l;
            ListNode<int> current = temp;
            while(current.Next != null)
            {
                if(current.Next.Value == k)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
            return temp.Next;
        }
    }
}
