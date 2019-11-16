using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadstart = new ThreadStart(Counting);
            Thread thread1 = new Thread(threadstart);
            Thread thread2 = new Thread(threadstart);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.ReadLine();

        }

        public static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Count: {0}, ThreadId: {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
