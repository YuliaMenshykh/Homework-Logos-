using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6._2__interface___enum_
{
    interface ISleep
    {
        void AnimalSleep();
    }

    interface IEat
    {
        void AnimalEat();
    }
    interface IDrink
    {
        void AnimalDrink();
    }
    interface ITalk
    {
        void AnimalTalk();
    }




    class Cat : ISleep, IEat, IDrink, ITalk
    {

        public void AnimalSleep()
        {
            Console.WriteLine("Meow, i`m sleeping");
        }
        public void AnimalEat()
        {
            Console.WriteLine("Meow, i`m eating");
        }
        public void AnimalDrink()
        {
            Console.WriteLine("Meow, i`m drinking");
        }
        public void AnimalTalk()
        {
            Console.WriteLine("Meow Meow");
        }

    }


    class Dog : ISleep, IEat, IDrink, ITalk
    {

        public void AnimalSleep()
        {
            Console.WriteLine("Wooff, i`m sleeping");
        }
        public void AnimalEat()
        {
            Console.WriteLine("Wooff, i`m eating");
        }
        public void AnimalDrink()
        {
            Console.WriteLine("Wooff, i`m drinking");
        }
        public void AnimalTalk()
        {
            Console.WriteLine("Wooff Wooff");
        }

    }
    class Program
    {
       


        
       static void Main(string[] args)
       {
          Cat cat = new Cat();
          (cat as ISleep).AnimalSleep();

          Dog dog = new Dog();
          (dog as IDrink).AnimalDrink();
            dog.AnimalDrink();


        }
        
    }
}
