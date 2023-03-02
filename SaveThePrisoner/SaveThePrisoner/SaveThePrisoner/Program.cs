class Program
{
    static public void Main(String[] args)
    {
        Console.WriteLine(saveThePrisoner(5,2,2));
    }
    static int saveThePrisoner(int prisonerCount,int candyCount,int chairNumber)
    {
        int chairNumberOfTheWarn = 0;
        if (
            prisonerCount > 0 && 
            candyCount > 0 && 
            chairNumber > 0 && 
            chairNumber <= prisonerCount
            )
        {
            for (int i = chairNumber; i <= prisonerCount; i++)
            {
                candyCount--;

                if (i == prisonerCount && candyCount>0)
                {
                    i = 0;
                }
                else if(candyCount == 0)
                {
                    chairNumberOfTheWarn = i;
                }
            }
        }
        else
            Console.WriteLine("Please check your parametrs");
        return chairNumberOfTheWarn;
    }
}
