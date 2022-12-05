public static class Day3
{

    public static void Problem1()
    {
        var rucksacks = Utilities.ReadLines(3).Select(i => new Rucksack(i));
        Console.WriteLine($"Day 3 P1: {rucksacks.Sum(r => r.Priority)}");
    }

    public static void Problem2()
    {
        var types = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var rucksacks = Utilities.ReadLines(3);
        var total = 0;
        for (int g = 0; g<rucksacks.Count()/3; g++)
        {
            var group = rucksacks.Skip(3*g).Take(3).ToArray();
            var badge = group[0].Intersect(group[1].Intersect(group[2])).Single();
            total += types.IndexOf(badge);
        }
        Console.WriteLine($"Day 3 P2: {total}");
    }
}

public class Rucksack
{
    private string types = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private char[] _comp1;
    private char[] _comp2;
    private char _common;
    public Rucksack(string input)
    {
        _comp1 = input.Take(input.Length/2).ToArray();
        _comp2 = input.Skip(input.Length/2).ToArray();
        _common = _comp1.Intersect(_comp2).Single();
    }

    public char Common { get { return _common; } }
    public int Priority { get {return types.IndexOf(_common);} }
}