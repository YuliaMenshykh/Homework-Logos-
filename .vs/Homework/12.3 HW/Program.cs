using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12._2_HW
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

            
        }
        static List<Product> ReadAllFromDB()
        {
            string json = File.ReadAllText(DBfilePath);
            List<Product> currentUser = JsonConvert.DeserializeObject<List<Product>>(json);
            return currentUser;

        }

        static string DBfilePath { get; set; }
        static void Main(string[] args)
        {
            string FileDBName = "ProductFile.txt";
            string fileFolder = Path.GetTempPath();
            DBfilePath = fileFolder + FileDBName;


            var allProduct = ReadAllFromDB();
            if (allProduct.Count == 0) Console.WriteLine("Right now file empty");
            foreach (var product in allProduct) Console.WriteLine(product);
        }
    }
}
