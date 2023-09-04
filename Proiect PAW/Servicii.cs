using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Serviciu : Tranzactie
    {
        private string Destinatie;
        private string Cazare;
        private string Transport;
        private DateTime Data_Plecare;
        private DateTime Data_Intoarcere;

        public Serviciu() { }

        public Serviciu(int idTranzactie, double pret, string stare, int id_Turist, string destinatie, string cazare, string transport, DateTime data_Plecare, DateTime data_Intoarcere):base(idTranzactie, pret, stare, id_Turist)
        {
            this.Destinatie = destinatie;
            this.Cazare = cazare;
            this.Transport = transport;
            this.Data_Plecare = data_Plecare;
            this.Data_Intoarcere = data_Intoarcere;
        }

        public string DS
        {
            get { return Destinatie; }
            set { Destinatie = value; }
        }

        public string CAZ
        {
            get { return Cazare; }
            set { Cazare = value; }
        }

        public string TP
        {
            get { return Transport; }
            set { Transport = value; }
        }

        public DateTime DP
        {
            get { return Data_Plecare; }
            set { Data_Plecare = value; }
        }

        public DateTime DI
        {
            get { return Data_Intoarcere; }
            set { Data_Intoarcere = value; }
        }

    }
}
