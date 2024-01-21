using System.Collections.Generic;

namespace Exercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // BACKWARDS LOOP TO REMOVE EVEN NUMBERS
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // FORWARD LOOP DOES NOT WORK

            List<int> otherNumbers = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                otherNumbers.Add(i);
            }

            for (int i = 0; i < otherNumbers.Count; i++)
            {
                if (otherNumbers[i] == 1 || otherNumbers[i] == 2 || otherNumbers[i] == 3)
                {
                    otherNumbers.Remove(otherNumbers[i]);
                }
            }

            Console.WriteLine();

            for(int i = 0; i < otherNumbers.Count; i++)
            {
                Console.Write(otherNumbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
