using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8._3_generic
{
    class Person<I, P>
    {
        public I Id { get; }
        public P Password { get; set; }
        public string Name { get; }
        public Person(I id, P password, string name)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
           Person<int, string> Vlad = new Person<int, string>(3323,"Q12", "Vlad");
           Console.WriteLine(Vlad.Id);
        }
    }

}
