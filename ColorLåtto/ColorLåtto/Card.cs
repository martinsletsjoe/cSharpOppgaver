namespace ColorLotto
{
    internal class Card
    {
        public bool _isOpen;
        private ConsoleColor _color;
        private readonly int _number;

        public Card(int number, ConsoleColor color)
        {
            _color = color;
            _number = number;



        }

        public void Open()
        {
            _isOpen = true;
        }

        public void Match(Card otherCard)
        {
            if (otherCard._color != _color)
            {
                _isOpen = false;
                otherCard._isOpen = false;
            }
        }

        public void Show(int x, int y)
        {
            Console.BackgroundColor = _isOpen ? _color : ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x, y);

            if (_number < 10) { Console.Write("0" + _number); }
            else { Console.Write(_number); }

            Console.ResetColor();
        }

    }
}