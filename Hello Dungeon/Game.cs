using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_Dungeon
{
    class Game
    {
        public void Run()
        {

            //Health and Health Regon
            int healthRegon = 0;
            int health  =  15;
            int speed = 10;
            int intellignece = 6;
            int stamana = 4;

            //damage
            int damagePhysical = 5;
                {
                bool (damagePhysical = true) ;
                }
            Console.WriteLine("You have dealt 1 physical damage");
            Console.WriteLine("You have dealt 2 magical damage");
            int damageMagical = 2;

            //increase health by Regon value
            health += healthRegon;

            //Health shown to player

            Console.WriteLine("Health " + health);
            Console.WriteLine("Damage Physical " + damagePhysical);
            Console.WriteLine("Damage Magacial " + damageMagical);
            Console.WriteLine("Intelligence " + intellignece);
            Console.WriteLine("Stamana " + stamana);

            //Name system - this is going to be the intro
            string name = "Empty";
            Console.WriteLine("Travaler you have come a long way to just up and loose your life. If you have the will for adventure let me hear your name.");
            name = Console.ReadLine();
            Console.WriteLine(name + " What a splendid travaler you are to come so far and then this.");
            Console.WriteLine("Now the deal is made and there is no going back.");
            Console.WriteLine("So were do we travel first partner");


            //Damage wompus bompus

            
        }
    }
}
