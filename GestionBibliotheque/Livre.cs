namespace GestionBibliotheque;

public class Livre
{
    private readonly string _titre;
    private readonly string _auteur;
    private bool _estDisponible = true;
    private string _nomEmprunteur;
    private DateTime _dateEmprunt;
    private DateTime _dateRetour;

    public Livre(string Titre, string Auteur)
    {
        _titre = Titre;
        _auteur = Auteur;
    }

    public new string ToString()
    {
        if (_estDisponible)
        {
            return "Titre: " + _titre + " par " + _auteur + " - Disponible depuis le  " + _dateRetour;
        }

        return "Titre: " + _titre + " par " + _auteur + " - Empreunté par " + _nomEmprunteur + " depuis le " +
               _dateEmprunt;
    }

    public string getTitre()
    {
        return _titre;
    }

    public void Emprunter(string nomEmprunteur)
    {
        if (!_estDisponible)
        {
            return;
        }

        _estDisponible = false;
        _nomEmprunteur = nomEmprunteur;
        _dateEmprunt = DateTime.Now;
    }

    public void Rentourner()
    {
        {
            if (_estDisponible)
            {
                return;
            }

            _estDisponible = true;
            _nomEmprunteur = "";
            _dateRetour = DateTime.Now;
        }
    }
}