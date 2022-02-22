using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3_Homework__check_
{
    class Program
    {
        enum Product
        {
            Milk,
            Bread,
            Juice,
            Cookes,
            Tomatos,
            Sausages,
            Onion,
            Water
        }
        class productCount
        {
            int[] count = { };

          }

        class Check
        {
            public void Count ()
            {

            }

            public int countWithoutTax
            {
                get
                {
                    return count * 0.8;
                }
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
