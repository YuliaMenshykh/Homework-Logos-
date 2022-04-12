using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Homework_OOP
{
    class Shopper
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void InfoName (string firstName, string lastName)
        {
            Console.WriteLine($"FirstName: {firstName}, LastName: {lastName}");
        }
    }
    abstract class Employee: Shopper
    {
        public abstract string position { get; }
        public abstract string function { get; }
        public void InfoEmployee (string firstName, string lastName)
        {
            Console.WriteLine($"FirstName: {firstName};\nLastName: {lastName};\nPosition : {position};\nFunction : {function}");
        }

    }
    class Manager: Employee
    {
        
        public override string position { get => "Manager"; }
        public override string function { get => "Hiring, training, supervising, and evaluating employees.\nHandling customer complaints."; }
    }
    class Accountant : Employee
    {
        public override string position { get => "Accountant"; }
        public override string function { get => "Ensure timely bank payments \n Compute taxes and prepare tax returns \nHandle monthly, quarterly and annual closings"; }
        
    }
    class Cashier:Employee
    {
        public override string position => "Cashier";

        public override string function => "Manage transactions with customers using cash registers.\n Handle merchandise returns and exchanges \nMaintain clean and tidy checkout areas ";
    }



    class Program
    {
        

        //static Name GetShopper()
        //{
        //    Name name = new Name();
        //    name.firstName = "Bob";
        //    name.lastName = "Marley";
        //    return name;
        //}

        //static Name GetMenadger()
        //{
        //    Name name = new Name();
        //    name.firstName = "Dan";
        //    name.lastName = "Taller";
        //    name.position ="menager";
        //    name.function = "Hiring, training, supervising, and evaluating employees.\n Handling customer complaints.";
        //    return name;
        //}

        
        static void Main(string[] args)
        {
            Console.WriteLine("\nManager :\n");
            Manager manager = new Manager();
            string nameM =  manager.firstName = "Polly";
            string surnameM = manager.lastName = "Sayti";
            manager.InfoEmployee(nameM, surnameM);

            Console.WriteLine("\nCashier :\n");
            Cashier cashier = new Cashier();
            string nameC = cashier.firstName = "Emily";
            string surnameC = cashier.lastName = "Tersis";
            cashier.InfoEmployee(nameC, surnameC);


        }
    }
}
 