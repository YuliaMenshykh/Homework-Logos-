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
            //Homework 1

            int res = sizeof(int);
            Console.WriteLine(res);

            int res1 = sizeof(char);
            Console.WriteLine(res1);


            //Homework2

            string myWord = "hello";
            int res2 = System.Runtime.InteropServices.Marshal.SizeOf(myWord);
            Console.WriteLine(res2);


            //Homework3


            int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(People));
            Console.WriteLine(size);


            //People Ivan = new People();
            //int res3 = System.Runtime.InteropServices.Marshal.SizeOf(typeof(People));
            //Console.WriteLine(res3);

        }
    }
}
