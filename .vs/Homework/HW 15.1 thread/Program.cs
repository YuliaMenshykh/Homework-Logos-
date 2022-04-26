using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW_15._1_thread
{
    class Program
    {
        static void WriteSecond()
        {
            int counter = 0;
            while (counter<10)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Thread ID {Thread.CurrentThread.GetHashCode()}, Counter {counter}");
                counter++;
            }
        }

        static void Last()
        {
            int counter = 0;
            while (counter < 10)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Thread ID {Thread.CurrentThread.GetHashCode()}, Counter {counter}");
                counter++;
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteSecond);
            thread.Start();
            Thread thread2 = new Thread(Last);
            thread2.Start();

            
            
            
        }

    }
}
