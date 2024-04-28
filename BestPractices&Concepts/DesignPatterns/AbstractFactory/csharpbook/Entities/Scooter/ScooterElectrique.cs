using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Scooter;

public class ScooterElectrique : Scooter
{
    public ScooterElectrique(string modele, string moteur, int puissance) : base(modele, moteur, puissance)
    {
    }

    public override void afficherCaracteristiques()
    {
        Console.WriteLine("Scooter électrique de modèle : " + modele + "de couleur : " + couleur + " de puissance : " + puissance);
    }
}