using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_HW_overloaded_operators
{

    class Coast
    {
        public int Price { get; set; }

        public static Coast operator +(Coast product1, Coast product2)
        {
            return new Coast { Price = product1.Price + product2.Price };
        }
        public static bool operator >(Coast product1, Coast product2)
        {
            return product1.Price > product2.Price;
        }
        public static bool operator <(Coast product1, Coast product2)
        {
            return product1.Price < product2.Price;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
