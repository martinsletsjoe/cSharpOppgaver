namespace ColorLåtto

{
    internal class Game
    {
        private Card[] _cards;


        public Game(int numberOfCards)
        {
            _cards = new Card[numberOfCards];
        }

        public void drawBoard()
        {

            for (var index = 0; index < _cards.Length; index++)
            {
                int row = index / 4;
                int col = index % 4;

                if (_cards[index] == null)
                {
                    _cards[index] = new Card(index, ConsoleColor.Blue);
                
                }
                _cards[index].Show(col * 3, row * 2);
            }
        }

        public void OpenCard(int cardIndex)
        {
            _cards[cardIndex].Open();
        }
    }
}
/*
        /*
         * Lage en array av cards og initalisere meg forskjellige
         * Vise kortene i et rutenet CHECK
         * Metode for å velge kort - som kalle Open på det kortet
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