using System.Threading;

delegate int DELG2(int v);

class E3
{
    public void MiniMain()
    {
        DELG2 d = x =>
        {
            int res = x * x;
            Console.WriteLine($"The square of {x} is {res}");
            return res;
        };
        Thread[] Threads = new Thread[10];
        for (int i = 0; i < Threads.Length; i++)
        {
            var j = i;
            Threads[i] = new Thread(() => d(j));
        }

        foreach (Thread t in Threads)
        {
            t.Start();
            t.Join();
        }
    }
}