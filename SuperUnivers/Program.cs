using SuperUnivers;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;

        UniversPhysique monUnivers = new UniversPhysique(15, 10);

        Element h1 = ElementFactory.Instance.CreateAtome("Hydrogène");
        Element h2 = ElementFactory.Instance.CreateAtome("Hydrogène");
        Element c = ElementFactory.Instance.CreateAtome("Carbone");

        h1.StrategieDeplacement = new BounceStrategy();
        h1.VitesseX = 1; h1.VitesseY = 1;

        h2.StrategieDeplacement = new ToricStrategy();
        h2.VitesseX = -1; h2.VitesseY = 0;

        c.StrategieDeplacement = new BounceStrategy();
        c.VitesseX = 0; c.VitesseY = 1;

        List<Element> population = new List<Element> { h1, h2, c };

        try {
            monUnivers.AjouterElement(h1, 0, 0);
            monUnivers.AjouterElement(h2, 5, 5);
            monUnivers.AjouterElement(c, 8, 2);
        } catch (Exception ex) {
            Console.WriteLine($"Erreur de placement : {ex.Message}");
        }

        MoteurGraphique moteur = new MoteurGraphique(monUnivers, population, 200);
        moteur.Lancer();

        Console.WriteLine("Moteur démarré. Appuyez sur une touche pour arrêter le programme principal.");
        Console.ReadKey();
    }
}