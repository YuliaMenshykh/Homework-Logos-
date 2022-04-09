using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6._2__interface___enum_
{
    public enum whatToEat
    {
        meat,
        fish,
        fruits,
        milk
    }


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


     class IHealthPeasfull
    {
        void AnimalHealth( whatToEat whatToEat)
        {
            double health = 0;
            switch (whatToEat)
            {
                case whatToEat.meat:
                    health =- 0.25;
                    break;
                case whatToEat.fish:
                    health =-0.25;
                    break;
                case whatToEat.fruits:
                    health =+0.25;
                    break;
                case whatToEat.milk:
                    health =+0.25;
                    break;
                default:
                    Console.WriteLine("Problem"); 
                    break;

               
            }
             
            
        }
    }





     class Cat : IHealthPeasfull, ISleep, IEat, IDrink, ITalk

    {

        public void AnimalSleep()
        {
            Console.WriteLine("Meow, i`m sleeping");
        }
        public void AnimalEat()
        {
           
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
           


        }
        
    }
}
