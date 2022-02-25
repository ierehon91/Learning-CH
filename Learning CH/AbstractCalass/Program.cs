using System;

namespace AbstractCalass
{
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
    }

    abstract class Weapon
    {
        abstract public int Damage { get; }
        abstract public void Fire();
        public void PrintMeta(Weapon weapon)
        {
            Console.WriteLine($"Name: {weapon.GetType().Name} | Damage: {weapon.Damage} HP");
        }
    }

    class Gun : Weapon
    {
        public override int Damage => 10;
        override public void Fire()
        {
            PrintMeta(this);
            Console.WriteLine("Выстрел из револьера.");
        }
    }

    class Laser : Weapon
    {
        public override int Damage => 7;
        override public void Fire()
        {
            PrintMeta(this);
            Console.WriteLine("Выстрел из лазерной винтовки.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun revolver = new Gun();
            Laser laserGun = new Laser();
            player.Fire(revolver);
            player.Fire(laserGun);
        }
    }
}
