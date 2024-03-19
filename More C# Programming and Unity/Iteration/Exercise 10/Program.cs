namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            int option = int.Parse(Console.ReadLine());
            while(option != 4)
            {

                if (option == 1) Console.WriteLine("New game started!");
                else if (option == 2) Console.WriteLine("Loading game...");
                else if (option == 3) Console.WriteLine("These are the options!");
                else Console.WriteLine("Invalid Input");
                option = int.Parse(Console.ReadLine());
            }
        }
    }
}
