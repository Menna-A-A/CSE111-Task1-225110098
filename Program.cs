using System;

namespace Cse111Task1
{
    public class Programh
    {
        private static void Show(string step, StudentList list)
        {
            Console.Write(step + ": ");
            list.Print();
            Console.WriteLine("   first=" + (list.First == null ? "null" : list.First.Id.ToString())
                + " last=" + (list.Last == null ? "null" : list.Last.Id.ToString())
                + " count=" + list.Count);
        }

        public static void Main(string[] args)
        {
            StudentList list = new StudentList();
            Show("0 start       ", list);

            list.AddFront(20);
            Show("1 AddFront(20)", list);

            list.AddFront(10);
            Show("2 AddFront(10)", list);

            list.AddEnd(30);
            Show("3 AddEnd(30)  ", list);

            list.AddEnd(40);
            Show("4 AddEnd(40)  ", list);

            list.Reverse();
            Show("5 Reverse()   ", list);

            list.Remove(20);
            Show("6 Remove(20)  ", list);
        }
    }
}