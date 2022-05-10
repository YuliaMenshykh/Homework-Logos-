using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_HW_overloaded_operators
{

    class Cost
    {
        public int Price { get; set; }

        public static Cost operator +(Cost product1, Cost product2)
        {
            return new Cost { Price = product1.Price + product2.Price };
        }
        public static bool operator >(Cost product1, Cost product2)
        {
            return product1.Price > product2.Price;
        }
        public static bool operator <(Cost product1, Cost product2)
        {
            return product1.Price < product2.Price;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Cost cost1 = new Cost();
            cost1.Price = 33;
            Cost cost2 = new Cost();
            cost2.Price = 45;
            var res = cost1.Price + cost2.Price;
            Console.WriteLine(res);

        }
    }
}
