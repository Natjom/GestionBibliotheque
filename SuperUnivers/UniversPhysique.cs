namespace SuperUnivers;

public class UniversPhysique
{
    private Element[,] _grille;
    public int Largeur { get; }
    public int Hauteur { get; }

    public event Action<Element> OnElementAdded;
    public event Action<Element> OnElementRemoved;

    public UniversPhysique(int x, int y)
    {
        Largeur = x;
        Hauteur = y;
        _grille = new Element[x, y];
    }

    public void AjouterElement(Element e, int x, int y)
    {
        if (x < 0 || x >= Largeur || y < 0 || y >= Hauteur)
            throw new Exception("Hors de l'univers !");

        if (_grille[x, y] != null)
            throw new Exception("Position déjà occupée !");

        e.SetPosition(x, y);
        _grille[x, y] = e;
        OnElementAdded?.Invoke(e);
    }
}