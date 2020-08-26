using System;

namespace Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int amountOfGuesses = 1;
            int amountOfGuessesEASY = 1;
            int amountOfGuessesMEDIUM = 1;
            int amountOfGuessesHARD = 1;
            int amountOfGuessesCHEATER = 1;

            Console.WriteLine("Lets play a Game, go ahead and give me a number you have floating around in your head....");
            // Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("...But wait! What difficulty would you like ta play: Easy, Medium, Hard or CHEATER");
            string guessLevel = Console.ReadLine();
            if (guessLevel == "easy")
            {
                return amountOfGuessesEASY(8);
            }
            else if (guessLevel == "medium")
            {
                return amountOfGuessesMEDIUM(6);
            }
            else if (amountOfGuessesHARD == "hard")
            {
                return amountOfGuessesHARD(4);
            }
            else if (amountOfGuessesCHEATER == "CHEATER")
            {
                return amountOfGuessesCHEATER(2000);
            }

            Console.WriteLine("We will see if it matches the number in my head....(1-100)?");
            //Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.Write("----------->Your Number?");
            Console.WriteLine("...");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your floating guess: {userInput}");
            //int secretNumber = 68;
            int secretNumber = new Random().Next(1, 201);



            while (amountOfGuessesEASY  | amountOfGuessesMEDIUM  | amountOfGuessesHARD  | amountOfGuessesCHEATER )
            {
                if (userInput == secretNumber)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("Your a wicked supple genius, not sure how you got such a phat brain?");
                    Console.WriteLine("--");
                    break;
                }
                else if (userInput >= secretNumber)
                {
                    Console.WriteLine($"You have guessed...x{amountOfGuesses++}.....your toooooo dang high");
                    // Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("---------->Your New Number?");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput <= secretNumber)
                {
                    Console.WriteLine($"You have guessed...x{amountOfGuesses++}.....your too dang low");
                    // Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("---------->Your New Number?");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    Console.WriteLine("You got no marbles in ya noggin, start over....");
                    break;
                }
            }
        }
    }
}