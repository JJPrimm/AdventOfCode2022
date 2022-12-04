using System.IO;
public static class Utilities
{    
    public static string[] ReadLines(int day)
    {
        return File.ReadAllLines($"Input//Input{day}.txt");
    }
}