namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("New game started!");
                    break;
                case 2:
                    Console.WriteLine("Loading Game...");
                    break;
                case 3:
                    Console.WriteLine("Showing Options");
                    break;
                case 4:
                    Console.WriteLine("Exiting game... Thanks for playing!");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
