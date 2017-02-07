using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    class DieselBil : Bil
    {
        public DieselBil(string mærke, int prisExAfgift, int købsÅr, int kmPrLiter) : base(mærke, prisExAfgift, købsÅr, kmPrLiter)
        {
        }
    }
}
