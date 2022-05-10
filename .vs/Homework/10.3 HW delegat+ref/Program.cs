using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3_HW_delegat_ref
{

    class Count
    {
        public delegate void PupilsCount(ref int a, ref int b, ref int c);
        public PupilsCount pupilsC { get; set; }
    }

       
    class Program
    {
        public static void Ch(ref int a, ref int b, ref int c)
        {
            int res = a + b + c;
            Console.WriteLine(res);
        }

        static void Main(string[] args)
        {
            int Pupils2A = 23;
            int Pupils2B = 22;
            int Pupils2C = 20;


            Count count = new Count();
            count= Pupils(ref Pupils2A, ref Pupils2B, ref Pupils2C);

        }

       
    }


}
