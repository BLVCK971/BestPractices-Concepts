using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Visitor.csharpbook;

public class VisiteurMailingCommercial : Visiteur
{
    public void visite(SocieteSansFilliale societe)
    {
        Console.WriteLine("Envoie d'un mail à" + societe.nom + " adresse : " + societe.email + " Proposition commerciale pour votre societe");    }

    public void visite(SocieteMere societe)
    {
        Console.WriteLine("Envoie d'un mail à" + societe.nom + " adresse : " + societe.email + " Proposition commerciale pour votre groupe");
        Console.WriteLine("Impression d'un courrier à " + societe.nom + " adresse : " + societe.adresse + " Proposition commerciale pour votre groupe");
    }
}
