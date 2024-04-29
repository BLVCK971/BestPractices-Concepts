using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Visitor.csharpbook;

public static class Utilisateur
{
    public static void mainFunction()
    {
        Societe societe1 = new SocieteSansFilliale("sociéte1", "info@societe1.com", "rue de la société 1");
        Societe societe2 = new SocieteSansFilliale("sociéte2", "info@societe2.com", "rue de la société 2");

        Societe groupe1 = new SocieteMere("groupe1", "info@groupe1.com", "rue du groupe 1");
        groupe1.ajouteFilliale(societe1);
        groupe1.ajouteFilliale(societe2);

        Societe societe3 = new SocieteSansFilliale("sociéte3", "info@societe3.com", "rue de la société 3");

        Societe groupe2 = new SocieteMere("groupe2", "info@groupe2.com", "rue du groupe 2");
        groupe2.ajouteFilliale(groupe1);
        groupe2.ajouteFilliale(societe3);

        groupe2.accepteVisiteur(new VisiteurMailingCommercial());
    }
}
