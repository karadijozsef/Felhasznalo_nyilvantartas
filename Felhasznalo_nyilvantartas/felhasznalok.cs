using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhasznalo_nyilvantartas
{
    internal class felhasznalok
    {
        int id;
        string nev;
        DateTime szuletesidatum;
        string profilnev;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesidatum { get => szuletesidatum; set => szuletesidatum = value; }
        public string Profilnev { get => profilnev; set => profilnev = value; }

        public felhasznalok(int id, string nev, DateTime szuletesidatum, string profilnev)
        {
            Id = id;
            Nev = nev;
            Szuletesidatum = szuletesidatum;
            Profilnev = profilnev;
        }
    }
}
