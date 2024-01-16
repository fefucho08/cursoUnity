namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PRINT LINES AND COLUMNS DETERMINED BY USER

            int lines = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // PRINT UNTIL MAX WIDTH
            
            int width = int.Parse(Console.ReadLine());

            for(int i = 0; i < width; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
