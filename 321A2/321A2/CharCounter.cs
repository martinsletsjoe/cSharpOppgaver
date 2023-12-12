using System;

namespace _321A2;

public class CharCounter
{
    public int _range;
    public int[] _counts;

    public CharCounter()
    {
        _range = 250;
        _counts = new int[_range];
    }

    public void AddText(string text)
    {
        foreach (var character in text ?? string.Empty)
        {
            _counts[(int)character]++;
        }
    }

    public void ShowCounts()
    {
        for (var i = 0; i < _range; i++)
        {
            if (_counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + _counts[i]);
            }
        }
    }
}