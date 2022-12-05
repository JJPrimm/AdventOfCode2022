public static class Day5
{
    public static void Problem1()
    {
        var input = Utilities.ReadLines(5);
        var stacks = BuildStacks(input.Take(8).ToArray());
        foreach (var instruction in input.Skip(10))
        {
            int count = Convert.ToInt32(instruction.Split(' ')[1]);
            int source = Convert.ToInt32(instruction.Split(' ')[3]) - 1;
            int destination = Convert.ToInt32(instruction.Split(' ')[5]) - 1;

            stacks[destination].AddRange(stacks[source].Skip(stacks[source].Count() - count).Reverse());
            stacks[source] = stacks[source].Take(stacks[source].Count() - count).ToList();
        }
        var answer = String.Join(null, stacks.Select(s => s.Last()));
        Console.WriteLine($"Day 5 P1: {answer}");
    }
    public static void Problem2()
    {
        var input = Utilities.ReadLines(5);
        var stacks = BuildStacks(input.Take(8).ToArray());
        foreach (var instruction in input.Skip(10))
        {
            int count = Convert.ToInt32(instruction.Split(' ')[1]);
            int source = Convert.ToInt32(instruction.Split(' ')[3]) - 1;
            int destination = Convert.ToInt32(instruction.Split(' ')[5]) - 1;

            stacks[destination].AddRange(stacks[source].Skip(stacks[source].Count() - count));
            stacks[source] = stacks[source].Take(stacks[source].Count() - count).ToList();
        }
        var answer = String.Join(null, stacks.Select(s => s.Last()));
        Console.WriteLine($"Day 5 P1: {answer}");
    }

    private static List<char>[] BuildStacks(string[] input)
    {
        List<char>[] stacks = new List<char>[9];
        for(int s = 0; s < 9; s++)
        {
            stacks[s] = new List<char>();
            for (int i = 7; i >= 0; i--)
            {
                if (input[i][s * 4 + 1] == ' ')
                {
                    break;
                }
                else
                {
                    stacks[s].Add(input[i][s * 4 + 1]);
                }
            }
        }
        return stacks;
    }
}