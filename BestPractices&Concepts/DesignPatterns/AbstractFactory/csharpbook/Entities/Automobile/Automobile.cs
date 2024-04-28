namespace BestPractices_Concepts.DesignPatterns.AbstractFactory.csharpbook.Entities.Automobile;

public abstract class Automobile
{
    protected string _modele;
    protected string _couleur;
    protected int _puissance;
    protected double _espace;

    public Automobile(string modele, string couleur, int puissance, double espace)
    {
        _modele = modele;
        _couleur = couleur;
        _puissance = puissance;
        _espace = espace;
    }

    public abstract void afficherCaracteristiques();

}
