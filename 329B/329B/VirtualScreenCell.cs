namespace _329B;

public class VirtualScreenCell
{
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }



    public char GetCharacter()
    {
        if (Up && Down && Right && Left){ return '\u253c'; }

        if (Up && Down && Right) {return '\u251c'; }

        if (Up && Down && Left) { return '\u2524'; }

        return ' ';
    }

    public void AddHorizontal()
    {
        Right = true;
        Left = true;
    }

    public void AddVertical()
    {
        Up = true;
        Down = true;
    }

    public void AddLowerLeftCorner()
    {
        Up = true;
        Right = true;
    }

    public void AddUpperLeftCorner()
    {
        Down = true;
        Right = true;
    }

    public void AddUpperRightCorner()
    {
        Left = true;
        Down = true;
    }

    public void AddLowerRightCorner()
    {
        Up = true;
        Left = true;
    }
}