using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish_19._10._2023
{
    internal class Kup
    {
        List<Karta> karte;
        Random r=new Random();
        public Kup()
        {
            karte = new List<Karta>();
            for(int barva=0; barva < 4;barva++)
            {
                for(int vr=0; vr < 14;vr++) 
                {
                    karte.Add(new Karta((Barve)barva, (Vrednosti)vr));
                }
            }
        }
        public Kup(IEnumerable<Karta> začetek)
        {
            karte = new List<Karta>(začetek);
        }
        public void Add(Karta novaKarta)
        {
            karte.Add(novaKarta);
        }
        public int Count
        {
            get { return karte.Count; } 
        }
        public void Sort()
        {
            karte.Sort(new Primerjava());
        }
        public Karta Deli(int index)
        {
            Karta zaDelitev = karte[index];
            karte.Remove(zaDelitev); 
            return zaDelitev;
        }
        public void Mešaj()
        {
            List<Karta> noveKarte= new List<Karta>();
            while(karte.Count > 0)
            {
                int zaPremik=r.Next(karte.Count);
                noveKarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte=noveKarte;
        }
        public string[] ImenaKart()
        {
            string[] imena=new string[karte.Count];
            for(int k=0; k < imena.Count(); k++)
            {
                imena[k] = karte[k].ToString();
            }
            return imena;
        }
    }
}
