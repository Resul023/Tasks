class Program
{
    static public void Main(String[] args)
    {

        Console.WriteLine(SquareCount(17,24));
    }
    static int SquareCount(int min,int max)
    {
        int count = 0;
        if (min<max)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i * i >= min && i * i <= max)
                {
                    count++;
                }
            }
        }
        else
            Console.WriteLine("Please check your parametrs");
        
        return count;
    }
}
