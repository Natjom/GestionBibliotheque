namespace SuperUnivers;

public class Molecule : Element
{
    private List<Atome> _composants;

    public Molecule(string nom, List<Atome> atomes) : base(nom, "", 0)
    {
        if (atomes == null || atomes.Count < 2)
            throw new Exception("Une molécule doit contenir au moins 2 atomes !");

        _composants = atomes;

        this.Symbole = GenererSymbole();
        this.Masse = CalculerMasse();
    }

    private float CalculerMasse()
    {
        return _composants.Sum(a => a.Masse);
    }

    private string GenererSymbole()
    {
        var groupes = _composants.GroupBy(a => a.Symbole);
        string resultat = "";

        foreach (var g in groupes)
        {
            resultat += g.Key;
            if (g.Count() > 1)
                resultat += g.Count();
        }

        return resultat;
    }
}