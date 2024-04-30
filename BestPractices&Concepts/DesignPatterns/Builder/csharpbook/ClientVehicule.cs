namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook;

public class ClientVehicule
{
    public static void mainFunction()
    {
        ConstructeurLiasseVehicule constructeur;
        Console.WriteLine("Voulez-vous construire des liasses HTML (1) ou PDF (2) : ");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }

        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.Construit("Martin");
        liasse.imprime();
    }
}
