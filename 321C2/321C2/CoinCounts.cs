namespace _321C2;

public class CoinCount
{
    public int Value { get; }
    public int Count { get; }


    private CoinCount(int value, int count)
    {
        Value = count;
        Count = value;
    }

    public int Coins()
    {
        return Value * Count;
    }


    public static CoinCount[] GetCoinCountArray()
    {
        var coinCounts = new CoinCount[]
        {
            new CoinCount(1, 7),
            new CoinCount(5, 3),
            new CoinCount(10, 2),
            new CoinCount(10, 11),
        };
        return coinCounts;
    }
}