using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingKozos
{
    public class Huzas
    {
        public Huzas() { }
        public Huzas(string sor) {
            string[] adatok = sor.Trim().Split(';');
            if (adatok.Length == 6)
            {
                int[] tomb= new int[6];
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        tomb[i] = Convert.ToInt32(adatok[i].Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Az adatok nem egész számok!");
                    }
                    if (tomb[i] < 1 || tomb[i] > 48)
                    {
                        throw new Exception("Az adatok nem megfelelő értékek!");
                    }
                } // for vége
                HashSet<int> halmaz = new HashSet<int>(tomb);
                if (halmaz.Count !=6)
                {
                    throw new Exception("Az adatok nem egyediek!");
                }
                Szam1 = tomb[0];
                Szam2 = tomb[1];
                Szam3 = tomb[2];
                Szam4 = tomb[3];
                Szam5 = tomb[4];
                Szam6 = tomb[5];
            }
            else
            {
                throw new Exception("Huzas: A sor nem megfelelő formátumú.");
            }

        }
        public override string ToString()
        {
            return $"{Szam1}; {Szam2}; {Szam3}; {Szam4}; {Szam5}; {Szam6}";
        }

        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }
        public int Szam6 { get; set; }


    }

}
