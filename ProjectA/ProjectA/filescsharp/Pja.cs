using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.filescsharp
{
    internal class Pja
    {
        public static void DemoA()
        {
            String firstString = "Hello";
            char[] data = { 'H', 'E', 'L', 'L', 'O' };
            String secondString = new String(data);
            Console.WriteLine(firstString + " " + secondString);
            String thirdString = String.Empty;
            int x = 0;
        }
    }
}
