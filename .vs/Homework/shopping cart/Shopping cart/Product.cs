using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart
{
    public delegate double PriseWithoutTax(double Cost);
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Product()
        {
        }

        public Product(string name, double cost, DateTime expiryDate)
        {
            Name = name;
            Cost = cost;
            ExpiryDate = expiryDate;
        }

        public double PriseWithoutTax (double Cost)
        {
            return Cost * 0.8;
        }

        


        
        public void ProdList()
        {
            List<Product> ProdList = new List<Product>();
            ProdList.Add(new Product { Name = "Headphone", Cost = 300, ExpiryDate = new DateTime(2025, 06, 15) });
            ProdList.Add(new Product { Name = "Computer", Cost = 1000, ExpiryDate = new DateTime(2025, 06, 15) });
            ProdList.Add(new Product { Name = "Memory", Cost = 450, ExpiryDate = new DateTime(2025, 06, 15) });
            ProdList.Add(new Product { Name = "Phone", Cost = 750, ExpiryDate = new DateTime(2025, 06, 15) });

        }


        



        //double Headphone = 155;
        //double Computer = 13000;
        //double Memory = 1200;
        //double Phone = 10000;
        //double Keyboard = 1100;
        //double Mouse = 300;





    }
}
