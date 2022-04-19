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

    interface IDrink
    {
        void AnimalDrink();
    }
    interface ITalk
    {
        void AnimalTalk();
    }

    interface IEat
    {
        double AnimalHealth(food food);

    }

    //public class Eat
    //{
    //    public enum food
    //    {
    //        meat,
    //        fish,
    //        fruits,
    //        milk,
    //        sweeets
    //    }

    //    public void AnimalHealth( food whatToEat)
    //    {
    //        double health = 4;
    //        switch (whatToEat)
    //        {
    //            case food.meat:
    //            case food.fish:
    //            case food.milk:   
    //                Console.WriteLine(health += +0.25);
    //                break;
    //            case food.fruits:
    //            case food.sweeets:
    //                Console.WriteLine(health += -0.25);
    //                break;
    //            default:
    //                Console.WriteLine("Problem"); 
    //                break;

    //        }

    //    }
    //}
    public enum food
        {
            meat,
            fish,
            fruits,
            milk,
            sweeets
        }





    class Cat : IEat, ISleep, IDrink, ITalk
    {
        
        public void AnimalSleep()
        {
            Console.WriteLine("Meow, i`m sleeping");
        }

        public void AnimalDrink()
        {
            Console.WriteLine("Meow, i`m drinking");
        }
        public void AnimalTalk()
        {
            Console.WriteLine("Meow Meow");
        }

        double health = 1;
        public double AnimalHealth(food whatToEat)
        {
          switch (whatToEat)
          {
            case food.meat:
            case food.fish:
            case food.milk:
            Console.WriteLine(health += +0.25);
            break;
            case food.fruits:
            case food.sweeets:
            Console.WriteLine(health += -0.25);
            break;
            default:
            Console.WriteLine("Problem");
            break;
          }
          return health;
        }



        class Dog : IEat, ISleep, IDrink, ITalk
        {

            public void AnimalSleep()
            {
                Console.WriteLine("Wooff, i`m sleeping");
            }

            public void AnimalDrink()
            {
                Console.WriteLine("Wooff, i`m drinking");
            }
            public void AnimalTalk()
            {
                Console.WriteLine("Wooff Wooff");
            }
            double health = 2;
            public double AnimalHealth(food whatToEat)
            {
                switch (whatToEat)
                {
                    case food.meat:
                    case food.fish:
                        Console.WriteLine(health += +0.25);
                        break;
                    case food.fruits:
                    case food.sweeets:
                    case food.milk:
                        Console.WriteLine(health += -0.25);
                        break;
                    default:
                        Console.WriteLine("Problem");
                        break;
                }
                return health;
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                Cat cat = new Cat();
                cat.AnimalSleep();
                cat.AnimalHealth(food.fruits);
                cat.AnimalHealth(food.milk);

                Dog dog = new Dog();
                dog.AnimalHealth(food.fish);
                dog.AnimalHealth(food.meat);




            }

        }

    }
}
