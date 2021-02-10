using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 6, 10, 50, 70, -1, 0 };
            // return the index with the min elements/
            //int minNumber = numbers.Min();
            int minNumberIndex = 0;
            int minNumb = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                // int minNumb = currNum; //We accept that our first array number is the min

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (currNum > numbers[j])
                    {
                        minNumb = numbers[i + 1];
                        minNumberIndex = i + 1;
                    }
                } 
            }

            Console.WriteLine($"minIndex is: {minNumberIndex}");
            Console.WriteLine($"minNumber is: {minNumb}");
        }
    }
}
