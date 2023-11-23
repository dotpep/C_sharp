using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < 1000; ++i)
        {
            for (int j = 0; j < 1000; ++j)
            {
                if (j % 2 == 0)
                {
                    continue;
                }
            }
        }

        stopwatch.Stop();

        double durationMicro = stopwatch.Elapsed.TotalMilliseconds * 1000; // Convert to microseconds
        double durationMilli = stopwatch.Elapsed.TotalMilliseconds;

        Console.WriteLine($"C# Execution Time: {durationMicro} microseconds ({durationMilli} milliseconds)");
    }
}
