using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class SportEqvipment : Product 
    {
        public override string getInfo()
        {
            return $"{Name}: {Price}$";
        }

    }

    class Technique : Product
    {

    }


    class Program
    {
        static List<Product> product = new List<Product>();


        static void addProduct()
        {
            Console.WriteLine("Choose category: 1. Sport eqvipment, 2. Technique");
            int choose = int.Parse(Console.ReadLine());
            
            switch (choose)
            {
                case 1:
                    product.Add(new SportEqvipment().AddNewProduct());
                    break;
                case 2:
                    product.Add(new Technique().AddNewProduct());
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Console.WriteLine("\n New product added");

        }

        static void deleteProduct()
        {
            Console.WriteLine("Choose wich product you wanna delete");
            Console.WriteLine(product);
            int choose = int.Parse(Console.ReadLine());

            product.Remove(product[choose - 1]);

        }


        static void Main(string[] args)
        {
            addProduct();
        }
    }
}
