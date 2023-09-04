using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Turist
    {
        private int idTurist;
        private string Nume;
        private string Telefon;
        private string Email;

        public Turist() { }

        public Turist(int idTurist, string NP, string Tel, string Em)
        { 
            this.idTurist = idTurist;
            this.Nume = NP;
            this.Telefon = Tel;
            this.Email = Em;
        }

        public int ID
        {
            get { return idTurist; }
            set { idTurist = value; }
        }

        public string NP
        {
            get { return Nume; }
            set { Nume = value; }
        }

        public string Tel
        {
            get { return Telefon; }
            set { Telefon = value; }
        }

        public string Em
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
