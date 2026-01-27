namespace GestionBibliotheque;

public class Bibliotheque
{
    private List<Livre> _collection = new List<Livre>();
    
    public void AjouterLivre(Livre livre)
    {
        _collection.Add(livre);    
        Console.WriteLine("Le livre " + livre.getTitre() +  " a été ajouté à la collection !");
    }

    public void SupprimerLivre(string titre)
    {
        foreach (Livre livre in _collection)
        {
            if (livre.getTitre() == titre)
            {
                _collection.Remove(livre);
                Console.WriteLine("Le livre " + livre.getTitre() +  " a été retiré de la collection !");
                return;
            }
        }
        
        Console.Write("Le livre " + titre +  " n'est pas présent dans la collection !");
        
    }

    public Livre RechercherLivre(string titre)
    {
        foreach (Livre livre in _collection)
        {
            if (livre.getTitre() == titre)
            {
                Console.WriteLine("Le livre " + livre.getTitre() +  " est présent dans la collection : ");
                return livre;
            }
        }
        Console.WriteLine("Le livre " + titre + " n'est pas présent dans la collection.");
        return null;
    }

    public void EmprunterLivre(string titre, string nomEmprunteur)
    {
        foreach (Livre livre in _collection)
        {
            if (livre.getTitre() == titre)
            {
                Console.WriteLine("Le livre " + livre.getTitre() + " a été empreunté.");
                livre.Emprunter(nomEmprunteur);
            }
        }
    }
    
    public void RetournerLivre(string titre)
    {
        foreach (Livre livre in _collection)
        {
            if (livre.getTitre() == titre)
            {
                livre.Rentourner();
                Console.WriteLine("Le livre " + livre.getTitre() + " a été rapporté.");
            }
        }
    }

    public void AfficherLivres()
    {
        foreach (Livre livre in _collection)
        {
            Console.WriteLine(livre.ToString());
        }
    }
}