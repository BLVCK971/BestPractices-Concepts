using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook;

public class LiassePdf : Liasse
{
    public override void ajouteDocument(string document)
    {
        if(document.StartsWith("<PDF>"))
            contenu.Add(document);
    }

    public override void imprime()
    {
        Console.WriteLine("Liasse PDF");
        foreach(string s in contenu) 
            Console.WriteLine(s);
    }
}
