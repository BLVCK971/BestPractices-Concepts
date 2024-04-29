using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Visitor.csharpbook;

public class SocieteSansFilliale : Societe
{
    public SocieteSansFilliale(string nom, string email, string adresse) : base(nom, email, adresse)
    {
    }

    public override void accepteVisiteur(Visiteur visiteur)
    {
        visiteur.visite(this);
    }

    public override bool ajouteFilliale(Societe filliale)
    {
        return false;
    }
}
