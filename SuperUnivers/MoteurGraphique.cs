namespace SuperUnivers;

using System;
using System.Collections.Generic;
using System.Threading;

public class MoteurGraphique
{
    private UniversPhysique _univers;
    private List<Element> _elements;
    private int _vitesse;

    public MoteurGraphique(UniversPhysique univers, List<Element> elements, int delaiMs)
    {
        _univers = univers;
        _elements = elements;
        _vitesse = delaiMs;
    }

    public void Lancer()
    {
        Console.Clear();
        
        Thread threadMoteur = new Thread(() =>
        {
            while (true)
            {
                foreach (var element in _elements)
                {
                    element.UpdateLocation(_univers);
                }
                Dessiner();
                Thread.Sleep(_vitesse);
            }
        });
        threadMoteur.Start();
    }

    private void Dessiner()
    {
        string rendu = "";

        for (int y = 0; y < _univers.Hauteur; y++)
        {
            for (int x = 0; x < _univers.Largeur; x++)
            {
                var el = _elements.Find(e => e.X == x && e.Y == y);
                rendu += el != null ? $"[{el.Symbole}]" : "[ ]";
            }

            rendu += "\n";
        }

        Console.SetCursorPosition(0, 0);
        Console.Write(rendu);
        Console.WriteLine("\n--- Univers en mouvement (Appuyez sur Ctrl+C pour quitter) ---");
    }
}