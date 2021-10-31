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
        Dog obj1 = new Dog();
        BackMountGun obj2 = new BackMountGun();

        public void Speak()
        {
            obj1.Speak();
        }

        public void Aim()
        {
            obj2.Aim();
        }
        public void Fire()
        {
            obj2.Fire();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of GeeksforGeeks class
            DogGun obj = new DogGun();
            obj.Speak();
            obj.Aim();
            obj.Fire();
            Console.WriteLine("All Done");
        }
    }
}
