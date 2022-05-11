using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public DateTime Garanty { get; set; }
      
        public double PriseWithoutTax
        {
            get
            {
                return Price * 0.75;
            }
        }

        public virtual string getInfo()
        {
            return $"{Name}: {Price}$";
        }


        public override string ToString()
        {
            return $"Product name: {Name}\nProduct price: {Price}\n_____";
        }


        public Product AddNewProduct()
        {
            Console.WriteLine("Write name :");
            string name = Console.ReadLine();
            Console.WriteLine("Write price :");
            double price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Write count of product :");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Write garanty time :");
            DateTime garanty = DateTime.Parse(Console.ReadLine());
          


            return new Product() { Name = name, Price = price, Count = count, Garanty = garanty};
        }


    }
}
