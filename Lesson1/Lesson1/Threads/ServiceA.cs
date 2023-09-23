using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Threads
{
    internal class ServiceA
    {
        private static object t1;

        public void DoTask()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside Dotask");
            Console.WriteLine("\t Threadid :" + id);
            int x = 0;
            for (int icount = 0; icount<=5; icount++)
            {
                x += icount;
                Console.WriteLine("\t Id="+id +":X="+ x +"icount="+icount);
            }
        }
        public void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTask();
        } 
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" +id);
            ServiceA a1 = new ServiceA();
            Thread.t1 = new Thread(a1.DoTaskA);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.start();
            a1.DoTaskA();

            Console.WriteLine(".....End of Demo.......");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1 = new ServiceA();
            Thread.t1 = new Thread(a1.DoTaskA);
            Console.WriteLine(t1.ManagedThreadId +"T1 stste"+ t1.ThreadState);
            t1.start();
            Console.WriteLine(t1.ManagedThreadId + "State after start" + t1.ThreadState);
            a1.DoTaskA();
            Console.WriteLine(t1.ManagedThreadId + "T1 State after sleep" +t1.ThreadState);
            Console.WriteLine(".....End of Demo.......");


        }
}
