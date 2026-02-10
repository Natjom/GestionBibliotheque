public class E6 : IDisposable
{
    private bool isOpen = false;

    public E6()
    {
        Console.WriteLine("Database connection opened.");
        isOpen = true;
    }

    public void ExecuteQuery(string query)
    {
        if (!isOpen)
            throw new InvalidOperationException("The connection is closed.");

        Console.WriteLine($"Executing query: {query}");
    }

    public void Close()
    {
        if (isOpen)
        {
            Console.WriteLine("Database connection closed.");
            isOpen = false;
        }
    }

    public void Dispose()
    {
        Close();
    }
}