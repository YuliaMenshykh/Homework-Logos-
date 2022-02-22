using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{

    class Cat
    {
        public void Speek()
        {
            Console.WriteLine("- Meow -_-");
        }
    }
    class Human
    {
        public void PettingCat()
        {
            Console.WriteLine("- Dogs are better than cats !");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Human human = new Human();
            human.PettingCat();
            cat.Speek();

        }
    }
}
