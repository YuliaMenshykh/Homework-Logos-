using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Shop
{
    class SportEqvipment : Product 
    {
    
    }

    class Technique : Product
    {

    }


    class Program
    {
        static List<Product> product = new List<Product>();
        static List <Product> bill = new List<Product>();


        static void addNewProduct()
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
            int index = 1;
            foreach (var item in product)
            {
                Console.WriteLine($"{index++}; \t{item.Name};");
            }
            
            int choose = int.Parse(Console.ReadLine());
            product.Remove(product[choose - 1]);

        }


        static void allproductcount()
        {
            var sorted = from Product in product
                         orderby Product.Count ascending
                         select Product;

            int index = 1;
            foreach (Product item in sorted)
            {
                Console.WriteLine($"{index++}; \t{item.Name}; \t{item.Count}");
            }
        }

        static void allProductGaranty()
        {
            var sorted = from Product in product
                         orderby Product.Garanty ascending
                         select Product;
            int index = 1;
            foreach (var item in sorted)
            {
                Console.WriteLine($"{index++}; \t{item.Name}; \t{item.Garanty}");
            }
        }

        static void MakeOrder()
        {
            Console.WriteLine("Choose operation : \n1.Add product\n2.Delete product\n3.Print a bill");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }

        static void addProductToBill()
        {
            Console.WriteLine("Choose category: 1. Sport eqvipment, 2. Technique");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    int index = 1;
                    foreach (var item in )
                    {
                        Console.WriteLine($"{index++}; \t{item.Name};");
                    };
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
        static void Run()
        {
            Console.WriteLine("Choose operation : \n1. Add new product\n2. Delete" +
                "\n3. Make order\n4. Quantity of products in the warehouse\n5. List of products relative to the date of validity");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    addNewProduct();
                    break;
                case 2:
                    deleteProduct();
                    break;
                case 3:
                    MakeOrder();
                    break;
                case 4:
                    allproductcount();
                    break;
                case 5:
                    allProductGaranty();
                    break;

                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }


        }



        static void Main(string[] args)
        {
            product.Add(new Technique() { Name = "Headphone", Price = 300, Count = 50,  Garanty = new DateTime(2025, 06, 30)});
            product.Add(new Technique() { Name = "Computer", Price = 120, Count = 46, Garanty = new DateTime(2024, 09, 22)});
            product.Add(new Technique() { Name = "Memory", Price = 140, Count = 23, Garanty = new DateTime(2025, 08, 09)  });
            product.Add(new Technique() { Name = "Headphone", Price = 540, Count = 65, Garanty = new DateTime(2026, 09, 11) });
            allproductcount();
            allProductGaranty();
        }
    }
}
