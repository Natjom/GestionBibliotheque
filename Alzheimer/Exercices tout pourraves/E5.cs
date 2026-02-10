using System;
using System.Diagnostics;

public class E5
{
    public void start()
    {
        const int largeSize = 200000;

        AllocateLargeArrayOnHeap(largeSize);
        AllocateLargeArrayOnStack(largeSize);
    }

    static void AllocateLargeArrayOnStack(int size)
    {
        try
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Span<int> largeArray = stackalloc int[size];
            for (int j = 0; j < 2000; j++)
            {
                largeArray[0] = 0;
                for (int i = 1; i < largeArray.Length; i++)
                {
                    largeArray[i] = largeArray[i - 1];
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Stack : {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Stack allocation not possible: {ex.Message}");
        }
    }
    
    static void AllocateLargeArrayOnHeap(int size)
    {
        try
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] largeArray = new int[size];
            for (int j = 0; j < 2000; j++)
            {
                largeArray[0] = 0;
                for (int i = 1; i < largeArray.Length; i++)
                {
                    largeArray[i] = largeArray[i - 1];
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Heap  : {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Heap allocation error: {ex.Message}");
        }
    }
}