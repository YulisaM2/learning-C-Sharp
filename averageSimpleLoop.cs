using System;

/**
* This is a quick program that calculates the average of several scores introduced from a scale of 0 to 20
* THe purpose of this project is to practice parsing, loops, and normal C# sintaxis
**/

namespace Averages_Simple_Loop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to The Average Calculator!");
               // Variables are initialized here for better control and verification
            string strScore = "", quitApp = "";
            double score = 0, sum = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Please enter the score of the student, scale of 0 to 20");
                strScore = Console.ReadLine();
                score = double.Parse(strScore);
                // In case the grade entered is not on the scale specified, it will be informed to the user
                // Only that cases that fit our description will be used to calculate the sum and final average 
                if(score >= 0 && score <= 20)
                {
                    counter++;
                    sum += score;
                }
                else
                {
                    Console.WriteLine("ERROR: SCORE OUT OF RANGE, PLEASE TRY AGAIN");
                }
               

                Console.WriteLine("Add another score? If not, enter -1");
                quitApp = Console.ReadLine();

            } while (quitApp != "-1");
            // quick calculation of average shown with data provided
            double average = sum / counter;
            Console.WriteLine("The Final Average of the student is {0}", average);
            Console.Read();


        }
    }
}
