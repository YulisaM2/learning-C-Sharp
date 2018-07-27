using System;
/** This program checks if num1 is bigger, smaller or equal to num2 
 * Quick algorithm to practice the usage of enhanced if statements
 * 
 * */
namespace EnchancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Condition ? first expresion : second expression;
            // First condition ? first expression : Second condition ? second expression : third expression

            Console.WriteLine("Please enter num1 ");
            string strnum1 = Console.ReadLine();
            int num1 = int.Parse(strnum1);
            
            Console.WriteLine("Please enter num2 ");
            string strnum2 = Console.ReadLine();
            int num2 = int.Parse(strnum2);

            string verify = num1 > num2 ? "bigger" : num1 == num2 ? "equal" : "smaller";
            Console.WriteLine("Num1 " + num1 + " is {0} than num2 " + num2, verify);
            Console.ReadKey();


        }
    }
}
