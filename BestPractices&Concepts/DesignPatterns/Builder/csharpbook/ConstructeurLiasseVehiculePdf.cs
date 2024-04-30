namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }
        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document;
            document = "<PDF>Bon de commande Client : " + nomClient + "</PDF>";
            liasse.ajouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document;
            document = "<PDF>Demande d'immatriculation Demandeur : " + nomDemandeur + "</PDF>";
            liasse.ajouteDocument(document);
        }
    }
}
