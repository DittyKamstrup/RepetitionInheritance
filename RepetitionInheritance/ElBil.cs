using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class ElBil : Bil
    {
        public ElBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, int tank) : base(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter, tank)
        {
        }

        public override int HalvÅrligEjerAfgift()
        {
            throw new NotImplementedException();
        }

        public override int Rækkevidde()
        {
            throw new NotImplementedException();
        }
    }
}
