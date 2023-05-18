using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        UseString(70000);
        Console.WriteLine("Ready to switch");
        Console.ReadKey();

        UseStringBuilder(70000);
        Console.ReadKey();
    }

    static string UseString(int n)
    {
        string value = "";

        for (int i = 0; i < n; i++)
        {
            value += i.ToString();
            value += " ";
        }

        return value;
    }

    static string UseStringBuilder(int n)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            builder.Append(i.ToString());
            builder.Append(" ");
        }

        return builder.ToString();
    }
}
public class Testing
{
    static int Iterations = 10000;
    [Benchmark]
    public string UseString()
    {
        string value = "";

        for (int i = 0; i < Iterations; i++)
        {
            value += i.ToString();
            value += " ";
        }

        return value;
    }

    [Benchmark]
    public string UseStringBuilder()
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < Iterations; i++)
        {
            builder.Append(i.ToString());
            builder.Append(" ");
        }

        return builder.ToString();
    }
}