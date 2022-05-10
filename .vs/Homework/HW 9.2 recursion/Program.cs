using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._2_recursion
{
    class Program
    {
        class Welcome
        {
            public Welcome()
            {
                Console.WriteLine("Hi" +
                    "\n." +
                    "\n." +
                    "\n." +
                    "\n." +
                    "\n.");
            }


            public Welcome(int a)
            {
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("Goodbye" +
                    "\n_" +
                    "\n_" +
                    "\n_" +
                    "\n_");
                }
                

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Welcome ss = new Welcome(5);
                Welcome s1 = new Welcome();
            }
           
        }
    }
}
