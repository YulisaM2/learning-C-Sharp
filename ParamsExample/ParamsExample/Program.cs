using System;

namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int buffer = MinParams(10, 2, 3, 4, 5, 754, 4, -123, -2);
            Console.WriteLine("The minimum value is : {0}", buffer);
        }

        // Keyword params used to pass as many arguments as required.
        public static int MinParams(params int[] list)
        {
            int min = int.MaxValue;
            foreach(int number in list)
            {
                if(number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
