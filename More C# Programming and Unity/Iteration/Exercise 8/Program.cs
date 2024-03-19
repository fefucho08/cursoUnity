namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PRINT THE EVEN NUMBERS
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
            }

            // PRINT N ASTERISKS

            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
