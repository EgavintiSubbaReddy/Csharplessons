using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Threads
{
    internal class ThreadDemo
    {
        public static void DemoCurrent()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadId=" +id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" +t1.ThreadState);
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh Id" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTask();
        }


    }
}

