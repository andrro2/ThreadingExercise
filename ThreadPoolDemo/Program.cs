using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "ez");
            ThreadPool.QueueUserWorkItem(callback, "az");
            ThreadPool.QueueUserWorkItem(callback, "amaz");
            ThreadPool.QueueUserWorkItem(callback, "huha");
            Console.ReadLine();
        }

        public static void ShowMyText(object state)
        {
            string text = (string)state;
            text += " ThreadID: " + Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine(text);
        }
    }
}
