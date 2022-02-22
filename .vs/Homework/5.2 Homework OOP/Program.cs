using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Homework_OOP
{
    class Name
    {
        public string firstName;
        public string lastName;
        public string position;
        public string function;
        public void printShopper()
        {
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");
        }
        public void printWorkers()
        {
            Console.WriteLine($"FirstName: {firstName}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Function: {function}");
        }
    }


    class Program
    {
        static Name GetShopper()
        {
            Name name = new Name();
            name.firstName = "Bob";
            name.lastName = "Marley";
            return name;
        }

        static Name GetMenadger()
        {
            Name name = new Name();
            name.firstName = "Dan";
            name.lastName = "Taller";
            name.position ="menager";
            name.function = "Hiring, training, supervising, and evaluating employees.\n Handling customer complaints.";
            return name;
        }

        static Name GetAccountant()
        {
            Name name = new Name();
            name.firstName = "Emily";
            name.lastName = "Tersis";
            name.position = "accountant";
            name.function = "Ensure timely bank payments \n Compute taxes and prepare tax returns \n Handle monthly, quarterly and annual closings";
            return name;
        }

        static Name GetCashier()
        {
            Name name = new Name();
            name.firstName = "Polly";
            name.lastName = "Sayti";
            name.position = "Cashier";
            name.function = "Manage transactions with customers using cash registers.\n Handle merchandise returns and exchanges \n Maintain clean and tidy checkout areas ";
            return name;
        }

        static void Main(string[] args)
        {
            Name FirstShopper = GetShopper();
            Console.WriteLine(" = Shopper =");
            FirstShopper.printShopper();
            Name Cashier = GetCashier();
            Console.WriteLine("\n = Cashier =");
            Cashier.printWorkers();
            Name Accountant = GetAccountant();
            Console.WriteLine("\n = Accountant =");
            Accountant.printWorkers();
            Name Menadger = GetMenadger();
            Console.WriteLine("\n = Menager =");
            Menadger.printWorkers();
        }
    }
}
 