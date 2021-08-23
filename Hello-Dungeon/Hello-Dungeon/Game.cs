using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_Dungeon
{
    using System;

    namespace Hello_Dungeon
    {
        class Game
        {
            public void run()
            {

                void gameover()
                {
                    string input = Console.ReadLine();
                    int validinputreseive = 0;
                    bool gameover = false;
                    if (input == "1" || input == "2")
                    {

                        Console.WriteLine("GAMEOVER");
                        Console.WriteLine("1.EXIT");
                        Console.WriteLine("2.continue");
                        Console.WriteLine("3.restart");
                        Console.Write(">");

                        if (input == "1")
                        {

                            validinputreseive = 1;
                            Console.ReadKey();
                            Console.ReadLine();
                            Console.WriteLine("press any key.");
                            gameover = true;
                        }
                        else if (input == "2")
                        {
                            validinputreseive = 2;
                            Console.ReadKey();
                            Console.ReadLine();
                            Console.WriteLine("So you stay good for you");
                            start();

                        }
                        else
                        {
                            Console.ReadKey();
                            Console.ReadLine();
                            Console.WriteLine("you choose to go again good luck");
                            run();
                        }
                    }
                }


                //GAME OVER SCREEN



                //Health and Health Regon/ varables
                string characterJob = "job";
                int healthRegon = 0;
                int health = 15;
                health += healthRegon;
                int power = 1;
                string name = "Empty";
                Console.WriteLine("Travaler you have come a long way to just up and loose your life. If you have the will for adventure now let me know who you are");
                name = Console.ReadLine();
                string input = Console.ReadLine();

                string validinputreseive = "";
                input = "";

                void start()
                {
                    Console.WriteLine("Your Characer Stats");
                    Console.WriteLine("Job " + characterJob);
                    Console.WriteLine("Name " + name);
                    Console.WriteLine("Health " + health);
                    Console.WriteLine("Power " + power);

                }

                while (validinputreseive == "1" || validinputreseive == "2")
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
                        validinputreseive = "1";
                        input = Console.ReadLine();
                        characterJob = "Wizard";
                        health = 15;
                        power = 30;

                    }
                    //Other character title and states.
                    else if (input == "2" || input == "Knight")
                    {
                        validinputreseive = "2";
                        input = Console.ReadLine();
                        characterJob = "knight";
                        health = 30;
                        power = 15;

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
                Console.WriteLine("Job " + characterJob);
                Console.WriteLine("Name " + name);
                Console.WriteLine("Health " + health);
                Console.WriteLine("Power " + power);

                int numberOfAttempts = 5;

                Console.WriteLine("Very good traveler but lets not wait there is someone coming");
                Console.WriteLine("A very old man with a monkey on his back approaches you" +
                    "\nthe monkey is offering you the big money if you can solve the riddle in " + numberOfAttempts);

                for (int i = 0; i <= numberOfAttempts; i++)
                {
                    //This is the anwers and questions that are here for the first situation
                    string answer = "all";
                    Console.WriteLine("What month of the year has 28 days");
                    int attemptsRemaining = numberOfAttempts--;
                    Console.WriteLine("attempts Remaining" + attemptsRemaining);
                    Console.Write(">");
                    input = Console.ReadLine();

                    if (input == answer)
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


                for (int i = 0; i < 3; i++)
                {

                    //This is the second situation
                    Console.WriteLine("As you watch the moneky trying to speek it was silenced by the old man and they walk away.");
                    Console.WriteLine("You look and watch them walk away you realize they have no BIG MONEY and now you have wasted time to you start watlking.");
                    Console.WriteLine(" In anger you see a very small creature not even the size of a rabbit");
                    Console.WriteLine("1.Do you attack it");
                    Console.WriteLine("2. leave the poor creature alone");
                    Console.WriteLine(">");
                    input = Console.ReadLine();


                    if (input == "1")
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("You kill the innoccent creature and it dies painfully");
                        Console.WriteLine("You monster");
                        break;
                    }

                    else if (input == "2")
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("You are a good person but no it dies from a haret attack from you");
                        Console.WriteLine("You are still a good person though");
                        break;
                    }

                    else
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("Incorrect! but realy you just had to didnt you  -_-");

                    }


                }
                Console.WriteLine("You walk and admire the view and know that your advenchure only just started");
                for (int i = 0; i < 3; i++)
                {

                    //This is the second situation
                    Console.WriteLine("But you see a suspicious looking deer you follow it.");
                    Console.WriteLine("You waneder why it look so suspicious .");
                    Console.WriteLine(" But you countinue to follow it but it starts to run ");
                    Console.WriteLine("1.Do  you follow even more");
                    Console.WriteLine("2. leave the suspicious deer to its own");
                    Console.WriteLine(">");
                    input = Console.ReadLine();


                    if (input == "1")
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("NEVER, you say that you put enough time you might as well");
                        Console.WriteLine("CHARGE");
                        Console.WriteLine("You see a shadow and think you got to be FUC");
                        Console.WriteLine("The dragon sweeps and snaches the deer. You and the dragon lock eyes");
                        Console.WriteLine("in horror you relieze you are dead, life is sad");
                        Console.WriteLine("The dragon land and looks at you in discuse ");
                        Console.WriteLine("Cowerd");
                        Console.WriteLine("If flys away leaving you in a hobbled position ");
                        Console.WriteLine("you sumble home in shame and fear of the dragon");
                        Console.WriteLine("But you know you live one more day");
                        break;
                    }

                    else if (input == "2")
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("As you watch it the deer turns into a set of claws but that did not look \nright and so you look again but it was snached my a dragon -_- ");
                        Console.WriteLine("oooo no");
                        Console.WriteLine("you think of all the things that you did today and say nah and start running away but it did not seem to persue you");
                        Console.WriteLine("You live a nother day");
                        break;
                    }

                    else
                    {
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.WriteLine("Incorrect! but realy you just had to didnt you  -_-");

                    }

                }
                Console.WriteLine("The next day");
                // have to make a close game function
            }

        }
    }
}