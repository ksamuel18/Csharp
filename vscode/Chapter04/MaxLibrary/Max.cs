using System;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number: ");
            int first_num = Int32.Parse(Console.ReadLine());

            Console.Write("First Number: ");
            int Second_num = Int32.Parse(Console.ReadLine());

            Console.Write("Provide Integers: {0} and {1}, the max is {2}", first_num, Second_num);
        }
        static int Max (int num1, int num2)
        {
            return Math.Max(num1,num2);
        }
    }

}