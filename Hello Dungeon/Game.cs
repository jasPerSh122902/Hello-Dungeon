using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_Dungeon
{
    class Game
    {
        public void Run()
        {

            //Health and Health Regon/ varables
            string characterJob = "job";
            int healthRegon = 0;
            int health = 15;
            int power = 1;
            string name = "Empty";
            Console.WriteLine("Travaler you have come a long way to just up and loose your life. If you have the will for adventure now let me know who you are");
            name = Console.ReadLine();
            string input = Console.ReadLine();

            //increase health by Regon value
            health += healthRegon;

            bool validinputreseive = true;
            input = "";
            while (validinputreseive == true)
            {
                Console.WriteLine("Pick a job!");
                Console.WriteLine("1.Wizard");
                Console.WriteLine("2.Knight");
                Console.Write(">");
                input = Console.ReadLine();
                //input for the job changing and other states.
                if (input == "1" || input == "Wizard")
                //The Characters states and titles.
                {
                    validinputreseive = false;
                    input = Console.ReadLine();
                    characterJob = "Wizard";
                    health = 15;
                    power = 4;

                }
                //Other character title and states.
                else if (input == "2" || input == "Knight")
                {
                    validinputreseive = false;
                    input = Console.ReadLine();
                    characterJob = "knight";
                    health = 30;
                    power = 20;

                }
                //This is the damage skript mess with when we make emimes

                else
                {
                    //display error
                    Console.ReadLine();
                    Console.WriteLine("Invald input");

                }
            }

            //this is the CHARACTOR STATS 
            Console.WriteLine("Your Characer Stats");
            Console.WriteLine("job " + characterJob);
            Console.WriteLine("name " + name);
            Console.WriteLine("Health " + health);
            Console.WriteLine("Power " + power);

            int numberOfAttempts = 5;

            Console.WriteLine("A very old man with a monkey on his back approaches you" +
                "\n the monkey is offering you the big money if you can solve the riddle in " + numberOfAttempts, " tryies.");

            for (int i = 0; i < numberOfAttempts; i++)
            {
                string answer = "all";
                Console.WriteLine("What month of the year has 28 days");
                int attemptsRemaining = numberOfAttempts--;
                Console.WriteLine("attempts Remaining" + attemptsRemaining);
                Console.Write(">");
                Console.ReadLine();

                if (answer == "all")
                {
                    Console.ReadKey();
                    Console.ReadLine();
                    Console.WriteLine("Congrats you smart peson now ,get the big dollar");
                    break;
                }
                else
                {
                    Console.ReadKey();
                    Console.ReadLine();
                    Console.WriteLine("Incorrect! you sorry soul the big bollar is not yours for now");
                    health -= 1;
                }
            }


            for (int i = 0; i < numberOfAttempts; i--)
            {
                Console.ReadLine();
                Console.WriteLine("As you watch the moneky trying to speek it silenced my the old man and they walk away.");
                Console.WriteLine("You look and watch them walk away you realize they have no BIG MONEY and now you have wasted time to you start watlking.");
                Console.WriteLine("You see a very small creature not even the size of a rabbit");
                Console.WriteLine("1.Do you attack it");
                Console.WriteLine("2. leave the poor creature alone");


                if (input == "1")
                {
                    Console.WriteLine("You kill the innoccent creature and it dies painfully");
                    Console.WriteLine("You monster");
                }

                else if (input == "2")
                {
                    Console.WriteLine("You are a good person but no it dies from a haret attack from you");
                    Console.WriteLine("You are still a good person though");
                }
            }

        }
    }
}