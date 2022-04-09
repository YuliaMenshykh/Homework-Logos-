using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace _12._2_HW_add_data_in_class
{
    class Program
    {
        

        public class Product
        {
            public string name { get; set; }
            public int cost { get; set; }
            public override string ToString()
            {
                return $"{name}, {cost}$";
            }
            public Product(string name, int cost)
            {
                this.cost = cost;
                this.name = name;
            }

        }


        static List<Product> ReadAllFromDB()
        {
            string json = File.ReadAllText(DBfilePath);
            List<Product> currentProd = JsonConvert.DeserializeObject<List<Product>>(json);
            return currentProd ?? new List<Product>();

        }

        static void SaveToDB(Product product)
        {
            List<Product> allCurrentProduct = ReadAllFromDB();
            allCurrentProduct.Add(product);
            string serialized = JsonConvert.SerializeObject(allCurrentProduct);
            File.WriteAllText(DBfilePath, serialized);

        }
       

        static int GetItFromString(string inputStr)
        {
            int input = 0;
            try
            {
                input = int.Parse(inputStr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Have not that command");
            }
            return input;

        }

        static string DBfilePath { get; set; }
        static void Main(string[] args)
        {
            string FileDBName = "Product.txt";
            string fileFolder = Path.GetTempPath();
            DBfilePath = fileFolder + FileDBName;
            Console.WriteLine(DBfilePath);

            if (File.Exists(DBfilePath) == false)
            {
                var file = File.Create(DBfilePath);
                file.Close();
            }



            bool isWork = true;
            string allCommands = "\n Choos commands : \n 0 - Write all \n 1 - Add new \n 2 - Out \n* * * * * * *\n";

            while (isWork)
            {
                Console.WriteLine(allCommands);
                string input = Console.ReadLine();

                int inputRes = GetItFromString(input);


                switch (inputRes)
                {
                    case 0:
                        {
                            var allProduct = ReadAllFromDB();
                            if (allProduct.Count == 0) Console.WriteLine("Right now file empty");
                            foreach (var product in allProduct) Console.WriteLine(product);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Write product name :");
                            string name = Console.ReadLine();
                            Console.WriteLine("Write product cost :");
                            int cost =Convert.ToInt32(Console.ReadLine());
                            Product newProd = new Product(name, cost);
                            SaveToDB(newProd);
                            Console.WriteLine("New product added");

                            break;
                        }
                    case 2:
                        {

                            isWork = false;
                            Console.WriteLine("Goodbye");
                            break;
                        }
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
        }


       
       
    }
}
