using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 10, 50, 70, -1, 0 };
            // return the index of the min element/            
            int minNumberIndex = 0; //we accept first number is the min with his indexNr/
            int minNumb = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currNum > numbers[j])
                    {
                        minNumb = numbers[j];
                        minNumberIndex = j;
                    }
                }
            }

            Console.WriteLine($"minIndex is: {minNumberIndex}");
            Console.WriteLine($"minNumber is: {minNumb}");
        }
    }
}
