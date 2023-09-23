using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class DateTime

    {
        public static void FirstMethod()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2020, 10, 10); //yyyy, mm, dd

            System.Console.WriteLine(d1.ToLongDateString()); //Month in words

            System.Console.WriteLine(d1.ToShortDateString()); //Month in numbers

            System.Console.WriteLine(d1.ToLongTimeString());  //Time with seconds  

            System.Console.WriteLine(d1.ToShortTimeString());//Time without second
        }
    }
}
