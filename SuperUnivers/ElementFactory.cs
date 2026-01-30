namespace SuperUnivers;

public class ElementFactory
{
    private static ElementFactory _instance;

    public static ElementFactory Instance
    {
        get
        {
            if (_instance == null) _instance = new ElementFactory();
            return _instance;
        }
    }

    private ElementFactory()
    {
    }

    public Element CreateAtome(string nom)
    {
        return nom.ToLower() switch
        {
            "carbone" => new Atome("Carbone", "C", 12.01074f),
            "hydrogène" => new Atome("Hydrogène", "H", 1.00794f),
            "lithium" => new Atome("Lithium", "Li", 6.941f),
            _ => throw new Exception("Atome inconnu !")
        };
    }
    
    public Element CreateMolecule(string nom, List<string> nomsAtomes)
    {
        List<Atome> listeAtomes = new List<Atome>();
    
        foreach (var nomAtome in nomsAtomes)
        {
            listeAtomes.Add((Atome)CreateAtome(nomAtome));
        }

        return new Molecule(nom, listeAtomes);
    }
}