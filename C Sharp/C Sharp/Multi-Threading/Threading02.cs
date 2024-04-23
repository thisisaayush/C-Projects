using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp.Multi_Threading
{
    public  class Threading02
    {
        public static void Thread1()
        {
            Console.WriteLine("Thread 1");
        }

        public static void Thread2()
        {
            Console.WriteLine("Thread 2");
        }
    }

    public class MainThread2
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Threading02.Thread1));
            Thread t2 = new Thread(new ThreadStart(Threading02.Thread2));

            t1.Start();
            t2.Start();
        }
    }
}
