/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.InnerClass
{
    internal class Lambda
    {
        static void DemoA()
        {
            Func<>
        }
        static void Democ()
        {
            Func<double, double, double> call me (x, y) => (x + y) / 2;
            int v1 = 101;
            int v2 = 19;
            double result = call me(v1, v2);
            Console.WriteLine(result);
        }
        static void DemoD()
        {
            Func<int, double> foo = x => (double(x / 2);
            int v1 = 100;
            double result = foo(v1);
            Console.WriteLine(result);

        }
        static void DemoF()
        {
            Func<double, int> foo = x => (int)x / 2;
            int v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }
        static void Echo(Func<string> foo)
        {
            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "Hello");
            Echo(() => "World");
        }
        static double Dotrans(Func<int, int double> foo)
        {
            return foo(50, 5);
        }
        static void TestDotrans()
        {
            Func<int, int, double> Multiply = (x,y) => x* y;
            double d = Dotrans(Multiply);
            Console.WriteLine(d);
            Func<int, int, double> Add = (x, y) => x + y;
            double d = Dotrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1; return x / y;
            };
            double d1 = Dotrans(Divide);
            Console.WriteLine(d1);

           


        }

    }
*/


}
