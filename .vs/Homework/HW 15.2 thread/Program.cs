using System;
using System.Threading;

namespace HW_15._2_thread
{
    class Program
    {
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string (' ', 0) + "Second");
                Thread.Sleep(500);
            }
        }


        static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First");
                Thread.Sleep(500);
            }
            thread.IsBackground = true;

        }
    }
}
