using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Concepts.DesignPatterns.Builder.csharpbook
{
    public abstract class Liasse
    { 
        protected IList<string> contenu = new List<string>();

        public abstract void ajouteDocument (string document);
        public abstract void imprime();
    }
}
