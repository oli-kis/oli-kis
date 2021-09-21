using System;
using System.Media;


namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer player = new SoundPlayer("Music.wav");
                player.Load();
                //player.Play();
                player.PlayLooping();
            }

            //Welcome
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcone to my Random Number Generator");

            //Ask Name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            start:
            Console.WriteLine("Hello {0}, Please guess a Number between 1-100...", userName);

            //Generate Number
            Random rand = new Random();
            int number = rand.Next(0, 100);

            //variables
            int guess = 0;
            int trys = 0;

            while (guess != number)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please use an actual number ! ! !");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                else
                {
                    trys++;

                    if (guess <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number between 1-100");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    if (guess >= 101 && guess != 1976 && guess != 420)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number between 1-100");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    if (guess < number && guess >= 1 && guess <= 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The secret number is bigger, please try again...");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    if (guess > number && guess >= 0 && guess <= 101)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The secret number is smaller, please try again...");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    if (guess == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats, you guessed the secret number, it was {0}.", number);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Great, you needed {0} trys to guess the number!", trys);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (guess == 1976)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Congrats you found the Easter Egg ! ! !\n");
                        Console.WriteLine("_________________________$$$$");
                        Console.WriteLine("_______________________$$$$$$");
                        Console.WriteLine("______________________$$$$$$");
                        Console.WriteLine("______________________$$$$");
                        Console.WriteLine("______________________$$");
                        Console.WriteLine("_________$$$$$$$$$$$$$_$$$$$$$$$$$$$");
                        Console.WriteLine("______$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("____$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("____$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("_____$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("______$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine(" ________$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("__________$$$$$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("____________$$$$$$$$$$$$$$$$$$$$$");
                        Console.WriteLine("______________$$$$$$$$__$$$$$$$");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nNow please really guess a number between 1-100...\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    if (guess == 6969)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("░░▄▀░░░░░░░░░░░░░░░▀▀▄▄░░░░░ ");
                        Console.WriteLine("░░▄▀░░░░░░░░░░░░░░░░░░░░▀▄░░░ ");
                        Console.WriteLine("░▄▀░░░░░░░░░░░░░░░░░░░░░░░█░░ ");
                        Console.WriteLine("░█░░░░░░░░░░░░░░░░░░░░░░░░░█░ ");
                        Console.WriteLine("▐░░░░░░░░░░░░░░░░░░░░░░░░░░░█ ");
                        Console.WriteLine("█░░░░▀▀▄▄▄▄░░░▄▌░░░░░░░░░░░░▐ ");
                        Console.WriteLine("▌░░░░░▌░░▀▀█▀▀░░░▄▄░░░░░░░▌░▐ ");
                        Console.WriteLine("▌░░░░░░▀▀▀▀░░░░░░▌░▀██▄▄▄▀░░▐ ");
                        Console.WriteLine("▌░░░░░░░░░░░░░░░░░▀▄▄▄▄▀░░░▄▌ ");
                        Console.WriteLine("▐░░░░▐░░░░░░░░░░░░░░░░░░░░▄▀░ ");
                        Console.WriteLine("░█░░░▌░░▌▀▀▀▄▄▄▄░░░░░░░░░▄▀░░ ");
                        Console.WriteLine("░░█░░▀░░░░░░░░░░▀▌░░▌░░░█░░░░ ");
                        Console.WriteLine("░░░▀▄░░░░░░░░░░░░░▄▀░░▄▀░░░░░ ");
                        Console.WriteLine("░░░░░▀▄▄▄░░░░░░░░░▄▄▀▀░░░░░░░ ");
                        Console.WriteLine("░░░░░░░░▐▌▀▀▀▀▀▀▀▀░░░░░░░░░░░ ");
                        Console.WriteLine("░░░░░░░░█░░░░░░░░░░░░░░░░░░░░ ");
                        Console.WriteLine("░░╔═╗╔═╗╔═╗░░░░░║░║╔═╗║░║░░░░ ");
                        Console.WriteLine("░░╠═╣╠╦╝╠╣░░░░░░╚╦╝║░║║░║░░░░ ");
                        Console.WriteLine("░░║░║║╚═╚═╝░░░░░░║░╚═╝╚═╝░░░░ ");
                        Console.WriteLine("║╔═░╦░╦═╗╦═╗╦╔╗║╔═╗░░╔╦╗╔═╗╔╗ ");
                        Console.WriteLine("╠╩╗░║░║░║║░║║║║║║═╗░░║║║╠╣░╔╝ ");
                        Console.WriteLine("║░╚░╩░╩═╝╩═╝╩║╚╝╚═╝░░║║║╚═╝▄░ ");
                        Console.WriteLine("\nNow please really guess a number between 1-100...\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDo you wanna play again? [yes|no]");

            wrongInput:
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "yes":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYou have decided to play the Random Number Generator again\n");
                    goto start;

                case "no":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nThanks for playing my game :)");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPlease write [yes|no] ! ! !");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    goto wrongInput;
            }
        }
    }
}
