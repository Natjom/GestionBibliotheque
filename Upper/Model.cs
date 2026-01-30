namespace Upper;

public class Model
{
    public string toUpper(string chaine)
    {
        // wlh je comprend pas à quoi cesi joue c quoi ce pb de con
        if (!(string.IsNullOrEmpty(chaine) || chaine.Length > 8)) { return chaine.ToUpper(); }
        return "-1";
    }
}