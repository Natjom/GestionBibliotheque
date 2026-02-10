public delegate int Somme(int v1, int v2);

public class E1
{
    public int Methode(int v1, int v2)
    {
        return v1 + v2;
    }

    public int Add(int v1, int v2)
    {
        Somme somme = Methode;

        return somme(v1, v2);
    }
}