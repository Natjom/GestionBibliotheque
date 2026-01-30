using GestionBibliotheque;

class Program

{
    static void Main(string[] args)

    {
        Bibliotheque bibliotheque = new Bibliotheque();

        string titre;
        string auteur;
        string user;
        Livre livre;

        Console.WriteLine("Quel est votre nom ?");
        user = Console.ReadLine();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("   1    /    2    /     3    /    4    /   5     /   6    /   7  ");
            Console.WriteLine("Ajouter/Supprimer/Rechercher/Emprunter/Retourner/Afficher/Quitter");
            int selector = Convert.ToInt32(Console.ReadLine());
            switch (selector)
            {
                case 1:
                    Console.WriteLine("Quel est le titre du livre ?");
                    titre = Console.ReadLine();
                    Console.WriteLine("Quel est l'auteur du livre ?");
                    auteur = Console.ReadLine();
                    livre = new Livre(titre, auteur);
                    bibliotheque.AjouterLivre(livre);
                    break;
                case 2:
                    Console.WriteLine("Quel est le titre du livre ?");
                    titre = Console.ReadLine();
                    bibliotheque.SupprimerLivre(titre);
                    break;
                case 3:
                    Console.WriteLine("Quel est le titre du livre ?");
                    titre = Console.ReadLine();
                    bibliotheque.RechercherLivre(titre);
                    break;
                case 4:
                    Console.WriteLine("Quel est le titre du livre ?");
                    titre = Console.ReadLine();
                    bibliotheque.EmprunterLivre(titre, user);
                    break;
                case 5:
                    Console.WriteLine("Quel est le titre du livre ?");
                    titre = Console.ReadLine();
                    bibliotheque.RetournerLivre(titre);
                    break;
                case 6:
                    bibliotheque.AfficherLivres();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Bonne journée !");
                    Environment.Exit(1);
                    break;
            }


            Console.WriteLine("Appuyez sur entrée pour continuer !");
            Console.ReadLine();
        }
    }
}