namespace SuperUnivers;

public interface IMoveStrategy
{
    void Move(IMovable element, UniversPhysique univers);
}

public class BounceStrategy : IMoveStrategy
{
    public void Move(IMovable e, UniversPhysique u)
    {
        e.X += e.VitesseX;
        e.Y += e.VitesseY;

        if (e.X <= 0 || e.X >= u.Largeur - 1) e.VitesseX *= -1;

        if (e.Y <= 0 || e.Y >= u.Hauteur - 1) e.VitesseY *= -1;
    }
}

public class ToricStrategy : IMoveStrategy
{
    public void Move(IMovable e, UniversPhysique u)
    {
        e.X = (e.X + e.VitesseX + u.Largeur) % u.Largeur;
        e.Y = (e.Y + e.VitesseY + u.Hauteur) % u.Hauteur;
    }
}