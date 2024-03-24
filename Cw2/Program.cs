using System.Xml.XPath;

namespace Cw2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("It's me");
        Console.WriteLine("s27369");
        Console.WriteLine(":D");
        int[] tab = { 2, 4, 5, 7 };
        Console.WriteLine(avg(tab));
        Console.WriteLine(max(tab));
    }

    public static double avg(int[] tab)
    {
        int sum = 0;
        foreach (int v in tab) sum += v;
        return (double)sum / tab.Length;
    }

    public static int max(int[] tab)
    {
        int x = tab[0];
        foreach (int v in tab) if (v > x) x = v;
        return x;
    }
}