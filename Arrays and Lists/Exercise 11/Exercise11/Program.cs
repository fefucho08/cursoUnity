using System;
using ConsoleCards;

namespace Exercise11
{
    /// <summary>
    /// Exercise 11
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 11
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card[] cards = new Card[5];

            deck.Shuffle();

            cards[0] = deck.TakeTopCard();
            cards[0].FlipOver();
            cards[0].Print();

            cards[1] = deck.TakeTopCard();
            cards[1].FlipOver();
            cards[0].Print();
            cards[1].Print();

        }
    }
}
