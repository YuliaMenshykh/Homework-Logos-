 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_cart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProdList = new List<Product>();
            ProdList.Add(new Product {Name = "Bananna",Cost = 3.5, ExpiryDate =  new DateTime(2022, 06, 15)});
            

        }
    }
}
