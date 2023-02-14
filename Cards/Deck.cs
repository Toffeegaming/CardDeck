using Cas;

namespace Cards
{
    internal class Deck
    {
        private List<Card> _cards;
        private IoHandler _ioHandler = IoHandler.Instance;

        public Deck()
        {
            _cards = new List<Card>(52);
            InitDeck();
        }

        private void InitDeck()
        {
            _cards.AddRange(GenerateSuit("Hearts"));
            _cards.AddRange(GenerateSuit("Diamonds"));
            _cards.AddRange(GenerateSuit("Spades"));
            _cards.AddRange(GenerateSuit("Clubs"));

            _ioHandler.PrintLine($"{_cards.Count.ToString()} cards added to deck.");
        }

        private List<Card> GenerateSuit(string suit)
        {
            List<Card> generatedCards = new List<Card>(13);

            for (int i = 2; i <= 10; i++)
            {
                generatedCards.Add(new Card(suit, i.ToString()));
            }

            generatedCards.Add(new Card(suit, "Jack"));
            generatedCards.Add(new Card(suit, "Queen"));
            generatedCards.Add(new Card(suit, "King"));
            generatedCards.Add(new Card(suit, "Ace"));

            return generatedCards;
        }

        public void ShowCards()
        {
            _ioHandler.PrintLine("\nThe current deck is as follows:");
            foreach (var card in _cards)
            {
                _ioHandler.PrintLine(card.GetDetails());
            }
        }

        public void Shufflecards()
        {
            _ioHandler.PrintLine("\n==========[Shuffling the deck!]==========");
            Random rand = new Random(24012001);
            _cards = _cards.OrderBy(_ => rand.Next()).ToList();
        }
    }
}
