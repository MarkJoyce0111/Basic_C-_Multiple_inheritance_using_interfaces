using System;

namespace interfacebasic
{
    interface RobotAnimal
    {
        public void Speak();
        
    }

    class Dog : RobotAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof Woof, I'm Spot! A scary robot dog from Boston Dynamics");
        }
    }

    interface Weapon
    {
        public void Aim();
        public void Fire();
    }

    class BackMountGun : Weapon
    {
        public void Aim()
        {
            Console.WriteLine("I see you....");
        }

        public void Fire()
        {
            Console.WriteLine("Bang!, your dead");
        }
    }

    class DogGun : RobotAnimal, Weapon
    {
        Dog SpotObj = new Dog();
        BackMountGun WeaponObj2 = new BackMountGun();

        public void Speak()
        {
            SpotObj.Speak();
        }

        public void Aim()
        {
            WeaponObj2.Aim();
        }
        public void Fire()
        {
            WeaponObj2.Fire();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of DogGun class
            DogGun obj = new DogGun();
            obj.Speak();
            obj.Aim();
            obj.Fire();
            Console.WriteLine("All Done");
        }
    }
}
