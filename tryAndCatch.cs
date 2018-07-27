using System;
/* This program is to learn how to use the try and catch statements, and how to handle the most basic and general exceptions
 * It only verifies if the number entered by the user can be an integer
 **/
 
namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be verified.");
            string strNum = Console.ReadLine();

            try
            {
                int num = int.Parse(strNum);
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR: FORMAT MISTAKE");
            }
            catch(OverflowException)
            {
                Console.WriteLine("ERROR: OVERFLOW MISTAKE");
            }
            catch(Exception)
            {
                Console.WriteLine("ERROR: GENERAL MISTAKE");
            }
            finally
            {
                Console.WriteLine("Thanks for using!");
            }

            Console.ReadKey();
        }
    }
}
