using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_HW_method__rand
{
    class Product
    {
        private static string[] name = {"Computer","Phone","AirPods","Macbook","Memory","Processor" };
        public static string RandProd ()
        {
            var rand = new Random();
            string randProd = name[rand.Next(name.Length)];
            
            return randProd;
        }




        public static bool Solution(string str, string ending)
        {
            //try
            //{
            //    string res = str.Substring(str.Length - ending.Length, ending.Length);
            //    if (res == ending) return true;
            //    else return false;
            //}
            //catch (Exception)
            //{
            //    return false;
            //    throw;
            //}


            return str.EndsWith(ending);
        }
    }

   


    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine(Product.RandProd());

            Console.WriteLine(Product.Solution("r", "er")); 


        }
    }
}
