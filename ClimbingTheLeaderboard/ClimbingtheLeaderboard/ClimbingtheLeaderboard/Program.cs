using System.Diagnostics.Metrics;

class Program
{
    static public void Main(String[] args)
    {
        List<int> ranked = new List<int> { 100, 90, 90, 80 };
        List<int> player = new List<int>() { 70, 105, 90, 5, 80, 85 };

        var result = climbingLeaderboard(ranked, player.OrderByDescending(x=>x).ToList());

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }



    }
    static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> playerRank = new List<int>();

        for (int i = 0; i < player.Count(); i++)
        {
            if (player[i] > ranked[0])
            {
                playerRank.Add(1);
                
            }
            else if (player[i] < ranked[ranked.Count() - 1])
            {
                playerRank.Add(ranked.Count());

            }
            else
            {
                for (int j = 0; j < ranked.Count(); j++)
                {
                    if (player[i] == ranked[j])
                    {
                        if (playerRank.Contains(j))
                        {
                            playerRank.Add(j + 1);
                        }
                        else
                        {
                            playerRank.Add(j);
                        }
                        break;
                    }
                    else if(player[i] > ranked[j])
                    {
                        playerRank.Add(j-1);
                    }
                }
            }
        }
        return playerRank;
    }
}