using System;

namespace Homework
{
    class Program
    {
        struct People
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            //Homework 1.1
            {
                Console.WriteLine("Hello World!");
            }

            //Homework kalkulyator 1.3
            Console.WriteLine("Введіть число 1");
            double ch1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число 2");
            double ch2 = double.Parse(Console.ReadLine());
            Console.WriteLine("What do you want to do?\n  +\n  -\n *\n  /\n");
            string vybir = Console.ReadLine();

            switch (vybir)
            {
                case "+":
                    Console.WriteLine(ch1 + ch2);
                    break;
                case "-":
                    Console.WriteLine(ch1 - ch2);
                    break;
                case "*":
                    Console.WriteLine(ch1 * ch2);
                    break;
                case "/":
                    if (ch2 <= 0)
                    {
                        Console.WriteLine(ch1 / ch2);
                    }
                    else Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
            
            
            //Homework 2.1

            int res = sizeof(int);
            Console.WriteLine(res);

            int res1 = sizeof(char);
            Console.WriteLine(res1);


            //Homework  2.2

            string myWord = "hello";
            int res2 = System.Runtime.InteropServices.Marshal.SizeOf(myWord);
            Console.WriteLine(res2);


            //Homework 2.3


            int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(People));
            Console.WriteLine(size);


            //People Ivan = new People();
            //int res3 = System.Runtime.InteropServices.Marshal.SizeOf(typeof(People));
            //Console.WriteLine(res3);

           

        }
    }
}
