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
            string name = "Empty";
            int healthRegon = 0;
            int intellignece = 6;

            Console.WriteLine("1.Knight");
            Console.WriteLine("2.Wizard");
            Console.ReadLine();


            while
            {
                if name == "1";
                {
                    //the two caractors that are in the game
                    int health = 15;
                    int damage = 3;
                    int stamana = 10;
                    Console.WriteLine("Health" + health);
                    Console.WriteLine("Damage" + damage);
                    Console.WriteLine("stamana" + stamana);
                }

                else Console.ReadLine()
                {
                    int health = 7;
                    int damage = 25;
                    int stamana = 4;
                    Console.WriteLine("Health" + health);
                    Console.WriteLine("Damage" + damage);
                    Console.WriteLine("stamana" + stamana);

                }

            }

          //the intro for the added caractor creation
            Console.WriteLine("Travaler you have come a long way to just up and loose your life. If you have the will for adventure let me hear your name.");
            name = Console.ReadLine();
            Console.WriteLine(name + " What a splendid travaler you are to come so far and then this.");
            Console.WriteLine("Now the deal is made and there is no going back.");
            Console.WriteLine("So were do we travel first partner");
        }
    }
}
