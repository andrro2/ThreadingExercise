using System;
using System.Threading;

namespace SingleInstance
{
    class Program
    {
        public const string name = "RUNMEONLYONCE";

        static void Main(string[] args)
        {
            Mutex mutexVar = null;
            while (true)
            {
                try
                {
                    mutexVar = Mutex.OpenExisting(name);
                    mutexVar.Close();
                    Environment.Exit(0);

                }
                catch (WaitHandleCannotBeOpenedException e)
                {
                    mutexVar = new Mutex(true, name);
                }
            }
        }
    }
}
