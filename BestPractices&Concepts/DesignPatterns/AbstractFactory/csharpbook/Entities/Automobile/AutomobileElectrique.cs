namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;

public class AutomobileElectrique : Automobile
{
    public AutomobileElectrique(string modele, string moteur, int puissance, double espace) : base(modele, moteur, puissance, espace)
    {
    }

    public override void afficherCaracteristiques()
    {
        Console.WriteLine("Automobile électrique de modèle : " + _modele + "de couleur : " + _couleur + " de puissance : " + _puissance + " d'espace : " + _espace);
    }
}