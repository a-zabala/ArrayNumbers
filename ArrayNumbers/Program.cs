using System;

namespace ArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializes the array and assigns values
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };
            //this will iterate through the values of the array and print each to screen
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
