namespace SuperUnivers;

public abstract class Element : IMovable
{
    public string Nom { get; protected set; }
    public string Symbole { get; protected set; }
    public float Masse { get; protected set; }
    public int X { get; set; }
    public int Y { get; set; }

    public event Action<Element> OnMove;

    public IMoveStrategy StrategieDeplacement { get; set; }
    public int VitesseX { get; set; } = 1;
    public int VitesseY { get; set; } = 1;

 
    
    protected Element(string nom, string symbole, float masse)
    {
        Nom = nom;
        Symbole = symbole;
        Masse = masse;
    }

    public void SetPosition(int x, int y)
    {
        this.X = x;
        this.Y = y;
        OnMove?.Invoke(this);
    }
    
    public void UpdateLocation(UniversPhysique univers)
    {
        StrategieDeplacement?.Move(this, univers);
    
        OnMove?.Invoke(this);
    }
}

