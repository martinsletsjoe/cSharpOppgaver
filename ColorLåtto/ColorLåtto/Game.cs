namespace ColorLotto
{
    internal class Game
    {
        private Card[] _cards;


        public Game(int numberOfCards)
        {
            _cards = new Card[numberOfCards];

        }

        public bool CheckIfFinished()
        {

            foreach (var card in _cards)
            {
                if (card == null || !card._isOpen) return false;
            }

            return true;
        }

        public void DrawBoard()
        {

            for (var index = 0; index < _cards.Length; index++)
            {
                int row = index / 4;
                int col = index % 4;
                if (_cards[index] == null)
                {
                    _cards[index] = new Card(index + 1, color: (ConsoleColor)(index % 8));
                }

                _cards[index].Show(col * 3, row * 2);
            }

        }

        public Card OpenCard(int cardIndex)
        {
            var currentCard = _cards[cardIndex - 1];
            currentCard.Open();

            return currentCard;

            //var openCards = _cards.Where(card => card._isOpen).ToList();

            //if (openCards.Count == 2)
            //{
            //    var firstCard = openCards[0];
            //    var secondCard = openCards[1];

            //    firstCard.Match(secondCard);
            //}
        }

        public void CheckMatch(Card firstCard, Card secondCard)
        {
            firstCard.Match(secondCard);
        }
    }
}
/*
        /*
         * Lage en array av cards og initalisere meg forskjellige
         * Vise kortene i et rutenet CHECK
         * Metode for å velge kort - som kalle Open på det kortet CHECK
         *   - hvis det er andre kort som velges, kalles Match på det første og det andre kortet
         * Ev. kjenne igjen om spillet ferdig + starte på nytt
         * Ev. lage random farger
         */
/* 
        private void InitializeBoard()
   {
   _board = new Card[_rows, _columns];
   
   for (int i = 0; i < _rows; i++)
   {
   for (int j = 0; j < _columns; j++)
   {
   int cardNumber = i * _columns + j +1;
   ConsoleColor cardColor = (ConsoleColor)((cardNumber % 15) + 1);
   _board[i, j] = new Card(cardNumber, cardColor);
   }
   }
   }
   
   public void ShowBoard()
   {
   Console.Clear();
   for (int i = 0; i < _rows; i++)
   {
   for (int j = 0; j < _columns; j++)
   {
   _board[i, j].Show(j * 3, i *2);
   }
   }
   }
*/