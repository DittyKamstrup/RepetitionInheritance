using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class DieselBil : Bil
    {
        public bool PartikelFilter { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            int value = 0;

            if (PartikelFilter == false)
            {
                value += 500;
            }
            if (KmPrLiter < 15)
            {
                return value + 2000;
            }
            else if (KmPrLiter >= 15 && KmPrLiter <= 25)
            {
                return value + 1000;
            }
            else
            {
                return value + 350;
            }
        }

        //public override int HalvÅrligEjerAfgift()
        //{
        //    return base.HalvÅrligEjerAfgift() + 500;
        //}

        public override int Rækkevidde()
        {
            return Tank * KmPrLiter;
        }

        public DieselBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, int tank, bool partikelFilter) : base(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter, tank)
        {
            PartikelFilter = partikelFilter;
        }

        public DieselBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, int tank) : this(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter, tank, true)
        {
        }
    }
}
