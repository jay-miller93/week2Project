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
            //get user input
            Console.WriteLine("Hello! and welcome to The Lottery Game!!");

            Console.WriteLine("\n" + "Please select a low number for the first number in your number range:");
            int lowNum = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + "Great! Now, please select a high number for the end of your range(at least 50   more than low number):");
            int highNum = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + "Please enter six Lucky Numbers that are within the number range you have        selected.");
            int[] luckyNum = new int[6];
           for(int i = 0; i < luckyNum.Length; i++)
            {
                Console.WriteLine("Enter number:");
                luckyNum[i] = int.Parse(Console.ReadLine());
            }
            //while(int i < lowNum && int i > highNum)
            // {
            //     Console.WriteLine("Please enter a valid number between set number range");
            // }
            //cannot get function to work

            Console.WriteLine("I will now randomly generate 6 numbers! Please press enter:");
            Console.ReadLine();

            Random ran = new Random();
            int[] ranNum = new int[6];

            for (int i = 0; < 6; i++)
            {

            }
            //HHHHEEEEEELLPPPPPPPPPPPPPPPP
            //LOOPS ARE HARD
            //#FML


       
        }        
    }
}
