using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    class DieselBil : Bil
    {
        public bool PartikelFilter { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            return 1500;
        }

        //public override int HalvÅrligEjerAfgift()
        //{
        //    return base.HalvÅrligEjerAfgift() + 500;
        //}

        public DieselBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter, bool partikelFilter) : base(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter)
        {
            PartikelFilter = partikelFilter;
        }

        public DieselBil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter) : this(mærke, prisExAfgift, købsÅr, registreringsNr, kmPrLiter, true)
        {
        }
    }
}
