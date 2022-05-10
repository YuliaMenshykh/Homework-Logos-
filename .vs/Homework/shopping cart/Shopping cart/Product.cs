using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart
{
    class Product
    {

        public Product(string name, double cost, DateTime expiryDate)
        {
            Name = name;
            Cost = cost;
            ExpiryDate = expiryDate;
            
        }


        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime ExpiryDate { get; set; }


        public Product[] MyProduct = null;
        public void ShoppingList()
        {
            MyProduct[0] = new Product("Headphone", 155, new DateTime(2024, 06, 15));
            MyProduct[1] = new Product("Computer", 3.5, new DateTime(2022, 06, 15));
            MyProduct[2] = new Product("Memory", 3.5, new DateTime(2022, 06, 15));
            MyProduct[3] = new Product("Phone", 3.5, new DateTime(2022, 06, 15));
        }





        //double Headphone = 155;
        //double Computer = 13000;
        //double Memory = 1200;
        //double Phone = 10000;
        //double Keyboard = 1100;
        //double Mouse = 300;





    }
}
