/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLessons.tst
{
    internal class ClassA
    {
        public static void TestMethodA()
        {
            int id=Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");

            Task t3 = new Task(ClassA.TestMethodA);
            t3.Start();
            Task t4 = new Task(ClassA.TestMethodA);
            t4.Start();
        }
        public static void TaskMethodB(Task t)
        {
            Console.Write("running TaskB");
            Console.WriteLine($" After task {t.Id} ");
            Thread.Sleep(15000);
            Console.WriteLine($"taskB id {Task.CurrentId} Completed");
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("running TaskC");
            Console.WriteLine(" After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("running TaskB1");
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("taskB1 id {0} Completed", Task.CurrentId);
        }
        public static void ContinueTask()
        {
            Task t1 = new Task(ClassA.TaskMethodA);
            Task t2 = t1.ContinueWith(ClassA.TaskMethodB);
            Task t3 = t1.ContinueWith(ClassA.TaskMethodC);
            Task t4 = t2.ContinueWith(ClassA.TaskMethodB1);
            t1.Start();
            Console.WriteLine("Bye from ContinueTask");
        }
    }
}*/
