namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float BiteSize = 13.5f;

            Apple apple = new Apple();

            Console.Write(apple.AmountLeft.ToString());
            Console.Write(" " + apple.Organic.ToString());

            Console.WriteLine();

            do
            {
                apple.TakeBite(BiteSize);
                Console.WriteLine("Apple Left: " + apple.AmountLeft.ToString());
            } while (apple.AmountLeft > 0);
        }
    }
}
