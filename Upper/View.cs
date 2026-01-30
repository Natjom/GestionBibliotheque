namespace Upper;

public class View
{
    private ViewModel _viewModel;

    public View(ViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    public ViewModel GetViewModel()
    {
        return _viewModel;
    }

    public void Start()
    {
        Console.Clear();
        
        string chaine = "";
        
        Console.WriteLine("Enter your string.");

        chaine = Console.ReadLine();
        
        chaine = _viewModel.process(chaine);
        
        Console.WriteLine(chaine);
        
        Console.WriteLine("\nPress any key to quit...");
        Console.ReadKey();
        Console.Clear();
    }
}