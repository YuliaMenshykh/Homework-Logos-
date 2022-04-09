using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_HW_constructor
{

    class Gun
    {
        public Gun()
        {
            Console.WriteLine("Викликано конструктор без параметрів");
        }

        public Gun(int a)
        {
            Console.WriteLine("Викликано конструктор з одним параметром");
        }

        public Gun(int a, int b)
        {
            Console.WriteLine("Викликано конструктор з двома параметрами");
        }

        static Gun()
        {
            Console.WriteLine("Викликано статичний конструктор");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            Console.WriteLine(gun);

            Gun gun1 = new Gun(1);
            Console.WriteLine(gun1);

            Gun gun2 = new Gun(1,2);
            Console.WriteLine(gun2);

        }
    }
}
