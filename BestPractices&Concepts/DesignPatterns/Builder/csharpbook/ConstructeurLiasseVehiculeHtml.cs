namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook;

public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml();
    }

    public override void ConstruitBonDeCommande(string nomClient)
    {
        string document;
        document = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
        liasse.ajouteDocument(document);
    }

    public override void ConstruitDemandeImmatriculation(string nomDemandeur)
    {
        string document;
        document = "<HTML>Demande d'immatriculation Demandeur : " + nomDemandeur + "</HTML>";
        liasse.ajouteDocument(document);
    }
}
