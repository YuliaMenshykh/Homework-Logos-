using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_HW_method__rand
{
    class Product
    {
        private static string[] name = {"Computer","Phone","AirPods","Macbook","Memory","Processor" };
        public static void RandProd ()
        {
            var rand = new Random();
            string randProd = name[rand.Next(name.Length)];
            Console.WriteLine(randProd);
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product.RandProd();


        }
    }
}
