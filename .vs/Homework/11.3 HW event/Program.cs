using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3_HW_event
{
    public delegate void ProductList();

    class Keyboard
    {
        public event ProductList ByeProduct = null;
       
        public void PressKeyAEvent()
        {
            if (ByeProduct != null)
            {
                ByeProduct.Invoke();
            }
        }

        public void Start()
        {
            while (true)
            {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "exit":
                        goto exit;
                    default:
                        Console.WriteLine("Have not data", s);
                        break;
                }

            }
        exit:
            Console.WriteLine("Exit!");
        }
    }


    class Program
    {
        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    *    ");
            Console.WriteLine("   * *   ");
            Console.WriteLine("  *   *  ");
            Console.WriteLine(" * * * * ");
            Console.WriteLine("*       *");
        }


        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            keyboard.ByeProduct += PressKeyA_Handler;

            keyboard.Start();
        }
    }
}
