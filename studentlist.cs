// Name: Menna Ahmed Ali
// Student ID: 225110098

using System;
using System.Text;

namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void AddFront(int id)
        {
            Student node = new Student(id);
            node.Next = First;
            First = node;
            if (Last == null)
            {
                Last = node;
            }
            Count++;
        }

        public void AddEnd(int id)
        {
            Student node = new Student(id);
            if (Last == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
            Count++;
        }

        public bool Remove(int id)
        {
            if (First == null)
            {
                return false;
            }

            if (First.Id == id)
            {
                First = First.Next;
                if (First == null)
                {
                    Last = null;
                }
                Count--;
                return true;
            }

            Student prev = First;
            Student? cur = First.Next;
            while (cur != null)
            {
                if (cur.Id == id)
                {
                    prev.Next = cur.Next;
                    if (cur == Last)
                    {
                        Last = prev;
                    }
                    Count--;
                    return true;
                }
                prev = cur;
                cur = cur.Next;
            }

            return false;
        }

        public void Reverse()
        {
            Student? prev = null;
            Student? cur = First;
            Last = First;

            while (cur != null)
            {
                Student? next = cur.Next;
                cur.Next = prev;
                prev = cur;
                cur = next;
            }

            First = prev;
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            Student? cur = First;
            while (cur != null)
            {
                if (sb.Length > 0)
                {
                    sb.Append(' ');
                }
                sb.Append(cur.Id);
                cur = cur.Next;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}