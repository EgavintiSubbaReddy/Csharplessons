using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Day6
{
    internal class DictSort
    {

  public static void TestSortedListA()

        {

            SortedList<int, int> slist = new SortedList<int, int>();

            int count = slist.Count;

            Console.WriteLine("Count " + count);

            Console.WriteLine(" Capacity " + slist.Capacity);

            Random r1 = new Random();

            for (int i = 0; i < 10; i++)

            {

                int x = r1.Next(100);

                if (!slist.ContainsKey(x))

                    slist.Add(x, x * 55);

                Console.Write(x + " ");

            }

            Console.WriteLine();

            Console.WriteLine("Count " + slist.Count);

            Console.WriteLine(" Capacity " + slist.Capacity);



            foreach (var i in slist)

            {

                Console.WriteLine(i.Key + "," + i.Value);

            }

        }
    }
}
