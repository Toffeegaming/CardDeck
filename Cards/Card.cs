namespace Cards
{
    internal class Card
    {
        private string _suit;
        private string _faceValue;

        public string Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                _suit = value;
            }
        }

        public string faceValue
        {
            get
            {
                return _faceValue;
            }
            set
            {
                _faceValue = value;
            }
        }

        public Card(string suit, string faceValue)
        {
            this._suit = suit;
            this._faceValue = faceValue;
        }

        public string GetDetails()
        {
            return $"{this.faceValue} of {this._suit}";
        }
    }
}
