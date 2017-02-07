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

            DieselBil dieselBil1 = new DieselBil("Seat", 500, 2014, "HJ 34 735", 30, true);
            DieselBil dieselBil2 = new DieselBil("Peugeot", 550, 2015, "MK 97 254", 35, true);
            DieselBil dieselBil3 = new DieselBil("Mercedes", 2000, 2016, "XZ 98 243", 50, true);
            DieselBil dieselBil4 = new DieselBil("Toyota", 300, 2014, "OP 23 547", 27, false);
            DieselBil dieselBil5 = new DieselBil("Opel", 300, 2008, "SU 55 346", 15, false);

            dieselListe.Add(dieselBil1);
            dieselListe.Add(dieselBil2);
            dieselListe.Add(dieselBil3);
            dieselListe.Add(dieselBil4);
            dieselListe.Add(dieselBil5);

            foreach (DieselBil bil in dieselListe)
            {
                Console.WriteLine("Registrerings Nr : " + bil.RegistreringsNr + " Halvårlige Ejerafgift: " + bil.HalvÅrligEjerAfgift());
            }
        }
    }
}
