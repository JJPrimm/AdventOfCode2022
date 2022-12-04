public static class Day1
{
    public static void Problem1()
    {
        var input = Utilities.ReadLines(1);
        var max = 0;
        var current = 0;
        foreach (var line in input)
        {
            if (line == "")
            {
                current = 0;
            }
            else
            {
                current += Convert.ToInt32(line);
                if (current > max)
                {
                    max = current;
                }
            }
        }
        Console.WriteLine(max);
    }

    public static void Problem2()
    {
        var input = Utilities.ReadLines(1);
        var elves = new List<int>();
        var current = 0;
        foreach (var line in input)
        {
            if (line == "" && current != 0)
            {
                elves.Add(current);
                current = 0;
            }
            else
            {
                current += Convert.ToInt32(line);
            }
        }
        if (current > 0)
        {
            elves.Add(current);
        }
        Console.WriteLine(elves.OrderDescending().Take(3).Sum());
    }
}