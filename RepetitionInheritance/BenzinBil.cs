using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public sealed class BenzinBil : Bil
    {
        public BenzinBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, int tank) : base(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter, tank)
        {
        }


        public override int HalvÅrligEjerAfgift()
        {
            int value = 0;

            if (KmPrLiter < 20)
            {
                return value + 1200;
            }
            else if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                return value + 600;
            }
            else
            {
                return value + 320;
            }
        }
    }
}
