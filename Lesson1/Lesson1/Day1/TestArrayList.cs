using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day1
{
    internal class TestArrayList
    {
        public static void ArrayList()
        {
            ArrayList alist = new ArrayList();
            int count = alist.Count;
            Console.Write("Count " + count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 0
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
                alist.Add(r1.Next(10));
            Console.Write("Count " + alist.Count);
            Console.WriteLine(" Capacity " + alist.Capacity);// 16
        }
    }
}
