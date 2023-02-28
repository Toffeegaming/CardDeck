using Cas;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck pokerDeck = new Deck();

            pokerDeck.ShowCards();

            pokerDeck.Shufflecards();

            pokerDeck.ShowCards();
        }
    }
}