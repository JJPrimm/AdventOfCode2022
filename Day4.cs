public static class Day4
{
    public static void Problem1()
    {
        var pairs = Utilities.ReadLines(4);
        var count = 0;
        foreach (var pair in pairs)
        {
            int min1 = Convert.ToInt32(pair.Split('-')[0]);
            int max1 = Convert.ToInt32(pair.Split('-')[1].Split(',')[0]);
            int min2 = Convert.ToInt32(pair.Split('-')[1].Split(',')[1]);
            int max2 = Convert.ToInt32(pair.Split('-')[2]);
            if ((min1 <= min2 && max1 >= max2) || (min2 <= min1 && max2 >= max1))
            {
                count++;
            }
        }
        Console.WriteLine($"Day 4 P1: {count}");
    }

    public static void Problem2()
    {
        var pairs = Utilities.ReadLines(4);
        var count = 0;
        foreach (var pair in pairs)
        {
            int min1 = Convert.ToInt32(pair.Split('-')[0]);
            int max1 = Convert.ToInt32(pair.Split('-')[1].Split(',')[0]);
            int min2 = Convert.ToInt32(pair.Split('-')[1].Split(',')[1]);
            int max2 = Convert.ToInt32(pair.Split('-')[2]);
            if ((min1 <= max2 && max1 >= min2) || (min2 <= max1 && max2 >= min1))
            {
                count++;
            }
        }
        Console.WriteLine($"Day 4 P1: {count}");
    }
}
