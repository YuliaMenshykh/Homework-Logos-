using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{

    abstract class Weapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage : {Damage}");
        }

    }

    class Gun : Weapon
    {
        public override int Damage => 5;

        public override void Fire()
        {
            Console.WriteLine("Паф");
        }
    }

    class LazerGun : Weapon
    {
        public override int Damage { get { return 4; } }

        public override void Fire()
        {
            Console.WriteLine("Піу -Піу");
        }
    }

    class Bow : Weapon
    {
        public override int Damage => 6;

        public override void Fire()
        {
            Console.WriteLine("Чпуньк");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //Gun gun = new Gun();
            //player.Fire(gun);
            Weapon[] AllWeapons = { new Gun(), new LazerGun(), new Bow() };
            foreach (var item in AllWeapons)
            {

                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }

        }
    }
}
