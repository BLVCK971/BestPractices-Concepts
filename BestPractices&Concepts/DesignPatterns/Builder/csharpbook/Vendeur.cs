namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook;

public class Vendeur
{
    protected ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string nomClient)
    {
        constructeur.ConstruitBonDeCommande(nomClient);
        constructeur.ConstruitDemandeImmatriculation(nomClient);
        Liasse liasse = constructeur.Resultat;
        return liasse;
    }
}
