using System;

namespace deliverableTwoWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            var Random = new Random();
            bool realInteger = false;
            int numberOfFlips = 0;
            int correctCount = 0;
            bool correctGuessType = true;


            Console.WriteLine("We're flipping a coin! Help us out with our game.");

            //number of coin flips 
            //loop if user does not enter a number
            while (realInteger == false)

            {
                Console.Write("How many times should we flip our coin? ");
                string input = Console.ReadLine();
                realInteger = int.TryParse(input, out numberOfFlips);



                if (realInteger == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number.");
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You decided to flip the coin {numberOfFlips} times.");


            //heads or tails
            while (correctGuessType)
            {

                Console.WriteLine($"After we flip our coin {numberOfFlips} times, will it have landed on heads or tails more?: ");
                string headsOrTailsGuess = Console.ReadLine();

                if (headsOrTailsGuess.ToLower() != "heads" && headsOrTailsGuess.ToLower() != "tails")
                {
                    Console.WriteLine("Invalid entry. Please enter 'heads' or 'tails'");
                }
                else
                {
                    correctGuessType = false;
                    Console.WriteLine();
                    if (headsOrTailsGuess.ToLower() == "heads")
                    {
                        for (int i = 0; i <= numberOfFlips; i++)
                        {
                            int nextRandomNumber = Random.Next(0, 2);
                            if (nextRandomNumber == 0)
                            {
                                Console.WriteLine("Heads");
                                correctCount++;
                            }
                            else Console.WriteLine("Tails");
                        }
                    }
                    else if (headsOrTailsGuess.ToLower() == "tails")
                    {
                        for (int i = 0; i <= numberOfFlips; i++)
                        {
                            int nextRandomNumber = Random.Next(0, 2);
                            if (nextRandomNumber == 0)
                            {
                                Console.WriteLine("Tails");
                                correctCount++;
                            }
                            else
                                Console.WriteLine("Heads");
                        }
                    }
                    double winRate = (correctCount * 1.0 / numberOfFlips) * 100;
                    int n = (int)winRate;
                    Console.WriteLine();
                    Console.WriteLine($"You guessed {headsOrTailsGuess} which appeared {correctCount} times, or {n}%!");
                }
            }
        }
    }
}
