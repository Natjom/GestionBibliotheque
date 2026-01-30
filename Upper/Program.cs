using Upper;

class Program
{
    static void Main(string[] args)
    {
        Model monModel = new Model();
        ViewModel monViewModel = new ViewModel(monModel);
        View maView = new View(monViewModel);

        maView.Start();
    }
}