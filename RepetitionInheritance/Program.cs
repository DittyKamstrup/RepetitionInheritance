using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dieselListe = new List<DieselBil>();

            DieselBil dieselBil1 = new DieselBil("Seat", 500, 2014, "HJ 34 735", 30, 500, true);
            DieselBil dieselBil2 = new DieselBil("Peugeot", 550, 2015, "MK 97 254", 35, 600, true);
            DieselBil dieselBil3 = new DieselBil("Mercedes", 2000, 2016, "XZ 98 243", 50, 800, true);
            DieselBil dieselBil4 = new DieselBil("Toyota", 300, 2014, "OP 23 547", 27, 700, false);
            DieselBil dieselBil5 = new DieselBil("Opel", 300, 2008, "SU 55 346", 15, 200, false);

            dieselListe.Add(dieselBil1);
            dieselListe.Add(dieselBil2);
            dieselListe.Add(dieselBil3);
            dieselListe.Add(dieselBil4);
            dieselListe.Add(dieselBil5);

            foreach (DieselBil bil in dieselListe)
            {
                Console.WriteLine("Registrerings Nr : " + bil.RegistreringsNr + ", Halvårlige Ejerafgift: " + bil.HalvÅrligEjerAfgift());
                Console.WriteLine("");
            }

            List<BenzinBil> benzinListe = new List<BenzinBil>();

            BenzinBil benzinBil1 = new BenzinBil("Seat", 500, 2014, "HJ 34 735", 30, 200);
            BenzinBil benzinBil2 = new BenzinBil("Peugeot", 550, 2015, "MK 97 254", 35, 300);
            BenzinBil benzinBil3 = new BenzinBil("Mercedes", 2000, 2016, "XZ 98 243", 50, 500);
            BenzinBil benzinBil4 = new BenzinBil("Toyota", 300, 2014, "OP 23 547", 27, 400);
            BenzinBil benzinBil5 = new BenzinBil("Opel", 300, 2008, "SU 55 346", 15, 100);

            benzinListe.Add(benzinBil1);
            benzinListe.Add(benzinBil2);
            benzinListe.Add(benzinBil3);
            //benzinListe.Add(benzinBil4);
            //benzinListe.Add(benzinBil5);

            foreach (BenzinBil bil in benzinListe)
            {
                Console.WriteLine("Mærke : " + bil.Mærke + ", Pris eks. Afgift : " + bil.BilPrisExAfgift + ", Købs År : " + bil.KøbsÅr);
                Console.WriteLine("Registrerings Nr : " + bil.RegistreringsNr + ", Km pr Liter : " + bil.KmPrLiter + ", Halvårlige Ejerafgift: " + bil.HalvÅrligEjerAfgift() + ", Tankstørrelse: " + bil.Tank);
                Console.WriteLine("");
            }

            List<Bil> bilListe = new List<Bil>();

            bilListe.Add(dieselBil1);
            bilListe.Add(dieselBil2);
            bilListe.Add(dieselBil3);
            bilListe.Add(dieselBil4);
            bilListe.Add(dieselBil5);

            bilListe.Add(benzinBil1);
            bilListe.Add(benzinBil2);
            bilListe.Add(benzinBil3);
            bilListe.Add(benzinBil4);
            bilListe.Add(benzinBil5);

            foreach (Bil bil in bilListe)
            {
                //if (bil is ElBil)
                //{
                //    Console.WriteLine()
                //}
                if (bil is DieselBil)
                {
                    DieselBil dBil = bil as DieselBil;
                    Console.WriteLine(dBil.GetType().ToString(), dBil.Mærke, dBil.BilPrisExAfgift, dBil.KøbsÅr, dBil.RegistreringsNr, dBil.KmPrLiter, dBil.Tank);
                    
                    //Bil bil1 = dieselBil1 as Bil;
                }
                else if (bil is BenzinBil)
                {
                    Console.WriteLine();
                }
            }
        }            
    }
}
