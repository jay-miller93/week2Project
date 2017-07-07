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

            Console.WriteLine("\n" + "Please enter six Lucky Numbers that are within the number range you have        selected:");
            int[] luckyNum = new int[6];
           
        }        
    }
}
