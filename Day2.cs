public static class Day2
{
    public static void Problem1()
    {
        var input  = Utilities.ReadLines(2);
        Console.WriteLine(input.Select(i => RoundValue(i)).Sum());
    }

    public static void Problem2()
    {
        var input  = Utilities.ReadLines(2);
        Console.WriteLine(input.Select(i => RoundValue2(i)).Sum());
    }
    
    private static int RoundValue(string round)
    {
        switch (round)
        {
            case "A X":
                return 4;
            case "A Y":
                return 8;
            case "A Z":
                return 3;
            case "B X":
                return 1;
            case "B Y":
                return 5;
            case "B Z":
                return 9;
            case "C X":
                return 7;
            case "C Y":
                return 2;
            case "C Z":
                return 6;
            default:
                Console.WriteLine("round");
                throw new Exception("Something went wrong.");
        }
    }
    
    private static int RoundValue2(string round)
    {
        switch (round)
        {
            case "A X":
                return 3;
            case "A Y":
                return 4;
            case "A Z":
                return 8;
            case "B X":
                return 1;
            case "B Y":
                return 5;
            case "B Z":
                return 9;
            case "C X":
                return 2;
            case "C Y":
                return 6;
            case "C Z":
                return 7;
            default:
                Console.WriteLine("round");
                throw new Exception("Something went wrong.");
        }
    }
}