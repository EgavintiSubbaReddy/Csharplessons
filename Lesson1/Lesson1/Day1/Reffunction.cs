using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson1.Day1
{
    internal class Reffunction
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DotaskA( int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);

        }
        public static void TestOne()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            DotaskA(v1);
            Console.WriteLine($"v1:{v1}");
            DotaskA(v1);
            Console.WriteLine($"v1:{v1}");
        }



    }
}
