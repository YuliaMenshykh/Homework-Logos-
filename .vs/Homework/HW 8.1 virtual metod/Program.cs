using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8._1_virtual_metod
{

    class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("I`m driving fast");
        }
    }

    class SportCar : Car 
    {
        public override void Drive()
        {
            Console.WriteLine("I`m driving faster.I`m lighting!");
        }
    }

    class Person
    {
        public void Drive (Car car)
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new SportCar());
            person.Drive(new Car());
            //Методи використно для перезапису існуючої релізації в різних клaсах
        }
    }
}
