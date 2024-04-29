using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Visitor.csharpbook;

public interface Visiteur
{
    void visite(SocieteSansFilliale societe);
    void visite(SocieteMere societe);
}
