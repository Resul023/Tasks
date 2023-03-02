class Program
{
    static public void Main(String[] args)
    {
        int[] candleHeights = { 5, 35, 8, 35, 10 };

        if (candleHeights.Length > 0)
            Console.WriteLine($"There are {birthdayCakeCandles(candleHeights)} of them");
        else 
            Console.WriteLine("Check your array");

    }
    static int birthdayCakeCandles(int[] candleHeights)
    {
        int tallCandle = candleHeights[0];
        for (int i = 0; i < candleHeights.Length; i++)
        {
            if (tallCandle < candleHeights[i])
            {
                tallCandle = candleHeights[i];
            }
        }
        Console.WriteLine($"The talest candle are {tallCandle}");
        int count = 0;
        for (int i = 0; i < candleHeights.Length; i++)
        {
            if (tallCandle == candleHeights[i])
            {
                count++;
            }
        }
        return count;
    }
}