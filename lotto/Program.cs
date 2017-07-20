using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do
            {
                //get user input
                Console.WriteLine("Hello! and welcome to The Lottery Game!!");

                Console.WriteLine("\n" + "Please select a low number for the first number in your number range:");
                int lowNum = int.Parse(Console.ReadLine());

                Console.WriteLine("\n" + "Great! Now, please select a high number for the end of your range(at least 50   more than low number):");
                int highNum = int.Parse(Console.ReadLine());

                Console.WriteLine("\n" + "Please enter six Lucky Numbers that are within the number range you have        selected.");
                int[] luckyNum = new int[6];
                for (int i = 0; i < luckyNum.Length; i++)
                {
                    Console.WriteLine("Enter number:");
                    luckyNum[i] = int.Parse(Console.ReadLine());

                    while (luckyNum[i] < lowNum || luckyNum[i] > highNum)
                    {
                        Console.WriteLine("Please enter a valid number between set number range");
                        luckyNum[i] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("I will now randomly generate 6 numbers! Please press enter:");
                Console.ReadLine();

                Random ran = new Random();
                int[] ranNum = new int[6];
                for (int i = 0; i < ranNum.Length; i++)
                {
                    ranNum[i] = ran.Next(lowNum, highNum);
                }

                foreach (int number in ranNum)
                {
                    Console.WriteLine("\nYour Lottery Number: " + number);
                }
                Console.WriteLine("Press enter for your Winnings!");
                Console.ReadLine();


                int matchingNum = 0;
                foreach (int number in luckyNum)
                {
                    if (number == ranNum[0] || number == ranNum[1] || number == ranNum[2] || number == ranNum[3] || number == ranNum[4] || number == ranNum[5])
                    {
                        matchingNum++;
                    }
                }
                int maxAmount = 5000000;
                Console.WriteLine("Winning Numbers: {0}", matchingNum);
                int amountWon = ((maxAmount / 6) * matchingNum);
                Console.WriteLine("Total Amount Winnings: $" + amountWon);


                Console.WriteLine("\nWould you like to play again?");
                playAgain = Console.ReadLine();

            }
            while (playAgain == "yes");
        }
    }
}
