using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Batting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;

            //write code here
            Console.WriteLine("Welcome to Batting Average Calculator!\n");
            do
            {
                Console.WriteLine("Enter number of times at bat:");
                int timesAtBatInput = Convert.ToInt32(Console.ReadLine());


                int[] hitResults = new int[timesAtBatInput];
                int batNumber = 1;
                for (int i = 0; i < timesAtBatInput; i++)

                {
                    Console.WriteLine("Enter Your At-Bat Results #" + batNumber + ":");
                    Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=home run\n");

                    hitResults[i] = Convert.ToInt32(Console.ReadLine());
                    {
                    }
                    batNumber++;
                }
                Console.WriteLine("Batting Average:" + CalculateBattingAverage(hitResults));
                Console.WriteLine("Slugging Average:" + CalculateSluggingAverage(hitResults));

                Console.WriteLine("Another Batter? (y/n)\n");
                userAnswer = Console.ReadLine();

            } while ("y" == userAnswer);
            Console.WriteLine("Thank You for using our Batting Average Calculator!");




        }
        public static double CalculateBattingAverage(int[] battingSheet)
        {
            int hitCounter = 0;
            for (int i = 0; i < battingSheet.Length; i++)

                if (battingSheet[i] > 0)
                    hitCounter = hitCounter + 1;
            return (double)hitCounter / battingSheet.Length;
        }
        public static double CalculateSluggingAverage(int[] battingSheet)
        {
            int basesSum = battingSheet.Sum();


            return (double)basesSum / battingSheet.Length;
        }


    }
}

