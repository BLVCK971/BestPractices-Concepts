using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;

public class AutomobileEssence : Automobile
{
    public AutomobileEssence(string modele, string moteur, int puissance, double espace) : base(modele, moteur, puissance, espace)
    {
    }

    public override void afficherCaracteristiques()
    {
        Console.WriteLine("Automobile à essence de modèle : " + _modele + "de couleur : " + _couleur + " de puissance : " + _puissance + " d'espace : " + _espace);
    }
}