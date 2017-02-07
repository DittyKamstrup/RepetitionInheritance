using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public abstract class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }


        public virtual int RegistreringsAfgift()
        {
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift > 80500)
                {
                    return 180;
                }
                else //if (BilPrisExAfgift < 80500)
                {
                    return 105;
                }
            }

            else //if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift > 81700)
                {
                    return 180;
                }
                else //if (BilPrisExAfgift < 81700)
                {
                    return 105;
                }
            }
        }

        public int TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public virtual int HalvÅrligEjerAfgift()
        {
            return 1000;
        }

        public Bil(string mærke, int prisExAfgift, int købsÅr, string registreringsNr, int kmPrLiter)
        {
            Mærke = mærke;
            BilPrisExAfgift = prisExAfgift;
            KøbsÅr = købsÅr;
            RegistreringsNr = registreringsNr;
            KmPrLiter = kmPrLiter;
        }
    }
}
