using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Sharp.Multi_Threading
{
    public class Threading01
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class MainThread
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Threading01.Thread1));
            Thread t2 = new Thread(new ThreadStart(Threading01.Thread1));

            t1.Start();
            t2.Start();
        }
    }
}
