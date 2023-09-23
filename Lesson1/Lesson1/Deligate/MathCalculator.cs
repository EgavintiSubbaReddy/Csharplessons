/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Deligate
{
    internal class MathCalculator
    {
        public void DoTask()
        {
            Console.WriteLine("Calculator DoTask");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            Console.WriteLine(x + "," + y);
            return x * y;
        }
    }
  
    public class DelegateDemo
    {
        public static void TestOne()
        {
            MathCalculator mc = new MathCalculator();
            MethodHandlerA methodhandlerA = New MethodHandler(mc.DoTask);
            MethodHandlerB methodhandlerB = New MethodHandler(mc.Add);
            MethodHandlerB methodhandlerTwo = New MethodHandler(mc.Multiply);
            methodhandler();
            int addResult = methodhandlerB(100, 50);
            Console.WriteLine(addResult); 
            int MultiplyResult = methodhandlerTwo(20, 5);
            Console.WriteLine(MultiplyResult);

        }
    }
}*/
