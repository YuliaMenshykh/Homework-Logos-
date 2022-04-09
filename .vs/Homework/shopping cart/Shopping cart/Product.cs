using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart
{
    class Product
    {

        public Product (string a, double b, DateTime c)
        {
            Name = a;
            Cost = b;
            ExpiryDate = c;
        }
        
        
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime ExpiryDate { get; set; }


        public Product[] MyProduct = null;
        public ShoppingList()
        {
            MyProduct[0] = new Product("Bananna", 3.5 , 23.04.2022 );
        }

        public void PrintShopList(string Name, int Cost)
        {
            Console.WriteLine($" Name :{Name}, Cost : {Cost}");
        }


        

        static List<Product> items = new List<Product>()
        {
            
        };



        double Headphone = 155;
        double Computer = 13000;
        double Memory = 1200;
        double Phone = 10000;
        double Keyboard = 1100;
        double Mouse = 300;



        

    }
}
