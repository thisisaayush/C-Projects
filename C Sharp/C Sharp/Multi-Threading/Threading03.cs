using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Sharp.Multi_Threading
{
    public class Threading03
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(250);
            }
        }

        public static void Thread2()
        {
            Console.WriteLine("Thread 2");
        }
    }

    public class Thread3
    {
        public static void Main(string[] args) {

            Thread t1 = new Thread(new ThreadStart(Threading03.Thread1));
            Thread t2 = new Thread(new ThreadStart(Threading03.Thread1));
            Thread t3 = new Thread(new ThreadStart(Threading03.Thread2));

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
