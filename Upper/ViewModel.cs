namespace Upper;

public class ViewModel
{
    private Model _model;

    public ViewModel(Model model)
    {
        _model = model;
    }

    public Model GetModel()
    {
        return _model;
    }
    
    public string process(string chaine)
    {
        return _model.toUpper(chaine);
    }
}