using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = tbIDTranzactie;
            tbIDTranzactie.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            if(lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                lvTranzactiiServicii.SelectedItems[0].Remove();
            }

            if(lvTuristi.SelectedItems.Count > 0) 
            {
                lvTuristi.SelectedItems[0].Remove();
            }
        }

        private void buttonAdaugaTranzactie_Click(object sender, EventArgs e)
        {
            int idTranzactie = int.Parse(tbIDTranzactie.Text);
            double pret = double.Parse(tbPret.Text);
            string stare = cbStare.Text;
            int idTurist = int.Parse(tbIDTuristTranzactie.Text);
            string destinatie = cbDestinatie.Text;
            string cazare = tbCazare.Text;
            string transport = cbTransport.Text;
            DateTime dataPlecare = dtpDataPlecare.Value;
            DateTime dataIntoarcere = dtpDataIntoarcere.Value;
            Serviciu s = new Serviciu(idTranzactie, pret, stare, idTurist, destinatie, cazare, transport, dataPlecare, dataIntoarcere);
            ListViewItem lvi = new ListViewItem(s.ID.ToString());
            lvi.SubItems.Add(s.PR.ToString());
            lvi.SubItems.Add(s.ST);
            lvi.SubItems.Add(s.IDT.ToString());
            lvi.SubItems.Add(s.DS);
            lvi.SubItems.Add(s.CAZ);
            lvi.SubItems.Add(s.TP);
            lvi.SubItems.Add(s.DP.ToString());
            lvi.SubItems.Add(s.DI.ToString());
            lvi.Tag = s;
            lvTranzactiiServicii.Items.Add(lvi);
        }

        private void lvTranzactiiServicii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTranzactiiServicii.SelectedItems[0];
                Serviciu s = (Serviciu)lvi.Tag;
                tbIDTranzactie.Text = s.ID.ToString();
                tbPret.Text = s.PR.ToString();
                cbStare.Text = s.ST;
                tbIDTuristTranzactie.Text = s.IDT.ToString();
                cbDestinatie.Text = s.DS;
                tbCazare.Text = s.CAZ;
                cbTransport.Text = s.TP;
                dtpDataPlecare.Value = s.DP;
                dtpDataIntoarcere.Value = s.DI;
            }
        }

        private void buttonEditeazaTranzactie_Click(object sender, EventArgs e)
        {
            if(lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                lvTranzactiiServicii.SelectedItems[0].Text = tbIDTranzactie.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[1].Text = tbPret.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[2].Text = cbStare.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[3].Text = tbIDTuristTranzactie.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[4].Text = cbDestinatie.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[5].Text = tbCazare.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[6].Text = cbTransport.Text;
                lvTranzactiiServicii.SelectedItems[0].SubItems[7].Text = dtpDataPlecare.Value.ToString();
                lvTranzactiiServicii.SelectedItems[0].SubItems[8].Text = dtpDataIntoarcere.Value.ToString();
            }
        }

        private void buttonAdaugaTurist_Click(object sender, EventArgs e)
        {
            int idTurist = int.Parse(tbIDTurist.Text);
            string nume = tbNume.Text;
            string telefon = tbTelefon.Text;
            string email = tbEmail.Text;
            Turist t = new Turist(idTurist, nume, telefon, email);
            ListViewItem lvi = new ListViewItem(t.ID.ToString());
            lvi.SubItems.Add(t.NP);
            lvi.SubItems.Add(t.Tel);
            lvi.SubItems.Add(t.Em);
            lvi.Tag = t;
            lvTuristi.Items.Add(lvi);
        }

        private void lvTuristi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvTuristi.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTuristi.SelectedItems[0];
                Turist t = (Turist)lvi.Tag;
                tbIDTurist.Text = t.ID.ToString();
                tbNume.Text = t.NP;
                tbTelefon.Text = t.Tel;
                tbEmail.Text = t.Em;
            }
        }

        private void buttonEditeazaTurist_Click(object sender, EventArgs e)
        {
            if(lvTuristi.SelectedItems.Count > 0)
            {
                lvTuristi.SelectedItems[0].Text = tbIDTurist.Text;
                lvTuristi.SelectedItems[0].SubItems[1].Text = tbNume.Text;
                lvTuristi.SelectedItems[0].SubItems[2].Text = tbTelefon.Text;
                lvTuristi.SelectedItems[0].SubItems[3].Text = tbEmail.Text;
            }
        }

        private void tbCazare_Validating(object sender, CancelEventArgs e)
        {
            if(tbCazare.Text.Length < 5)
            {
                epCazare.SetError(tbCazare, "Cazarea trebuie sa contina minim 5 litere!");
                e.Cancel = true;
            }
            else
            {
                epCazare.SetError(tbCazare, "");
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text.Length < 3)
            {
                epNume.SetError(tbNume, "Numele trebuie sa contina minim 3 litere!");
                e.Cancel = true;
            }
            else
            {
                epNume.SetError(tbNume, "");
            }
        }

        private void salveazaTuristiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere turisti *.trs|*.trs";
            fd.CheckPathExists = true; // vrem sa existe calea

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // Pas 1 => Creez lista de turisti
                List<Turist> lista = new List<Turist>();
                // Pas 2 => Populez lista de turisti
                foreach (ListViewItem item in lvTuristi.Items)
                {
                    lista.Add((Turist)item.Tag);
                }
                // Pas 3 => Serializare ( ce vom salva )
                BinaryFormatter serializator = new BinaryFormatter(); // Trebuie sa avem toate clasele din clasa serializata folosita => Serializabile
                Stream fisier = File.Create(fd.FileName); // FileName -> fisierul creat de utilizator in fereastra de lansare
                serializator.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void incarcaTuristiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // copiem din salveaza si modificam unde trebuie !!!

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fisiere turisti *.trs|*.trs";
            fd.CheckFileExists = true; // vrem sa existe calea

            if (fd.ShowDialog() == DialogResult.OK)
            {

                List<Turist> lista = new List<Turist>();

                BinaryFormatter serializator = new BinaryFormatter(); // Trebuie sa avem toate clasele din clasa serializata folosita => Serializabile
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName); // FileName -> fisierul creat de utilizator in fereastra de lansare
                    lista.AddRange((List<Turist>)serializator.Deserialize(fisier)); // returneaza ce e in fisier
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Adaugam turistii din lista in lv

                foreach (Turist t in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { t.ID.ToString(), t.NP, t.Tel, t.Em });
                    lv.Tag = t; // edit
                    lvTuristi.Items.Add(lv); // adaugam in lv
                }
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere tranzactii *.tranz|*.tranz";
            fd.CheckPathExists = true; // vrem sa existe calea

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // Pas 1 => Creem lista de turisti
                List<Serviciu> lista = new List<Serviciu>();
                // Pas 2 => Populez lista de turisti
                foreach (ListViewItem item in lvTranzactiiServicii.Items)
                {
                    lista.Add((Serviciu)item.Tag);
                }
                // Pas 3 => Serializare ( ce vom salva )
                BinaryFormatter serializator = new BinaryFormatter(); // Trebuie sa avem toate clasele din clasa serializata folosita => Serializabile
                Stream fisier = File.Create(fd.FileName); // FileName -> fisierul creat de utilizator in fereastra de lansare
                serializator.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // copiem din salveaza si modificam unde trebuie !!!

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fisiere tranzactii *.tranz|*.tranz";
            fd.CheckFileExists = true; // vrem sa existe calea

            if (fd.ShowDialog() == DialogResult.OK)
            {

                List<Serviciu> lista = new List<Serviciu>();

                BinaryFormatter serializator = new BinaryFormatter(); // Trebuie sa avem toate clasele din clasa serializata folosita => Serializabile
                try
                {
                    Stream fisier = File.OpenRead(fd.FileName); // FileName -> fisierul creat de utilizator in fereastra de lansare
                    lista.AddRange((List<Serviciu>)serializator.Deserialize(fisier)); // returneaza ce e in fisier
                    fisier.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Adaugam turistii din lista in lv

                foreach (Serviciu s in lista)
                {
                    ListViewItem lv = new ListViewItem(new string[] { s.ID.ToString(), s.PR.ToString(), s.ST, s.IDT.ToString(), s.DS, s.CAZ, s.TP, s.DP.ToString(), s.DI.ToString() });
                    lv.Tag = s; // edit
                    lvTranzactiiServicii.Items.Add(lv); // adaugam in lv
                }
            }
        }

        private void cmsTranzactie_Opening(object sender, CancelEventArgs e)
        {
            if (lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                stergeTranzactieToolStripMenuItem.Enabled = true;
            }
            else
            {
                stergeTranzactieToolStripMenuItem.Enabled = false;
            }
        }

        private void cmsTuristi_Opening(object sender, CancelEventArgs e)
        {
            if (lvTuristi.SelectedItems.Count > 0)
            {               
                stergeTuristToolStripMenuItem.Enabled = true;
            }
            else
            {
                stergeTuristToolStripMenuItem.Enabled = false;
            }
        }

        private void tbIDTranzactie_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbPret.Focus();
            }
        }

        private void tbPret_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cbStare.Focus();
                cbStare.DroppedDown = true;
            }
        }

        private void cbStare_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbIDTuristTranzactie.Focus();
            }
        }

        private void tbIDTuristTranzactie_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cbDestinatie.Focus();
                cbDestinatie.DroppedDown = true;
            }
        }

        private void cbDestinatie_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbCazare.Focus();
            }
        }

        private void tbCazare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbTransport.Focus();
                cbTransport.DroppedDown = true;
            }
        }

        private void stergeTranzactieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTranzactiiServicii.SelectedItems[0];
                lvTranzactiiServicii.Items.Remove(item);
            }   
        }

        private void stergeTuristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvTuristi.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTuristi.SelectedItems[0];
                lvTuristi.Items.Remove(item);
            }
        }

        private void afisareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> preturi = new List<int>();
            List<int> id_uri = new List<int>();
            foreach (ListViewItem item in lvTranzactiiServicii.Items)
            {
                //if (item.SubItems.ContainsKey("Pret")) // posibil de aici eroarea? posibil nu returneaza bine => returneaza ok !
                //{
                    string pretText = item.SubItems[1].Text;
                    string idText = item.SubItems[0].Text;
                    int pret;
                    int id;
                    if (int.TryParse(pretText, out pret))
                    {
                        preturi.Add(pret);
                    }
                    if (int.TryParse(idText,out id))
                    {
                        id_uri.Add(id);
                    }
                //}
            }
            
            int[] vector_preturi = preturi.ToArray();
            int[] vector_id_uri = id_uri.ToArray();
            
            
            
            int nr_observatii = 0;
            foreach (ListViewItem item in lvTranzactiiServicii.Items)
            {
                nr_observatii++;
            }

            Form_Grafic form = new Form_Grafic(nr_observatii, vector_preturi, vector_id_uri);
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Close();
            }
        }

        private void PRINTFACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Check if an item is selected in lvTranzactiiServicii
            //if (lvTranzactiiServicii.SelectedItems.Count > 0)
            //{


            //    // Show the print dialog
            //    PrintDialog printDialog = new PrintDialog();
            //    if (printDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        // Set the PrintDocument object for printing
            //        printDocument1.PrinterSettings = printDialog.PrinterSettings;
            //        printDocument1.Print();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selectati o tranzactie din lista de Tranzactii si Servicii!", "Nicio tranzactie selectata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            // Varianta mai ok

            // Check if an item is selected in lvTranzactiiServicii
            if (lvTranzactiiServicii.SelectedItems.Count > 0)
            {
                // Create a new instance of PrintDocument
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += printDocument1_PrintPage; // Hook up the PrintPage event handler

                // Create a new instance of PrintPreviewDialog
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;

                // Set the print preview dialog settings
                printPreviewDialog.WindowState = FormWindowState.Maximized;
                printPreviewDialog.PrintPreviewControl.Zoom = 1.0; // Set the initial zoom level (1.0 = 100%)
                printPreviewDialog.PrintPreviewControl.AutoZoom = false; // Disable auto zooming
                                                                         // Add other desired print preview dialog settings here

                // Show the Print Preview Dialog
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectati o tranzactie din lista de Tranzactii si Servicii!", "Nicio tranzactie selectata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set the font and other properties for printing
            Font printFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            float lineHeight = printFont.GetHeight();

            // Define the starting position for printing
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Get the current date and format it
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
            float dateX = e.MarginBounds.Right - e.Graphics.MeasureString(currentDate, printFont).Width;
            float dateY = e.MarginBounds.Top;

            // Print the current date in the right top corner
            e.Graphics.DrawString(currentDate, printFont, brush, dateX, dateY);

            // Calculate the starting position for printing the title
            Font printFontTitle = new Font("Arial", 16, FontStyle.Bold);
            Brush brushTitle = Brushes.Black;
            float lineHeightTitle = printFont.GetHeight();

            float titleWidth = e.Graphics.MeasureString("FACTURA", printFontTitle).Width;
            float pageWidth = e.MarginBounds.Width;
            float x2 = e.MarginBounds.Left + (pageWidth - titleWidth) / 2;
            float y2 = e.MarginBounds.Top;

            // Print the title
            string title = "FACTURA";
            e.Graphics.DrawString(title, printFontTitle, brushTitle, x2, y2);
            y += lineHeightTitle * 5; // Add some spacing after the title


            // PENTRU ITEM SELECTAT

            // Get the selected item from lvTranzactiiServicii
            ListViewItem selectedTranzactie = lvTranzactiiServicii.SelectedItems[0];
            string idTranzactie = selectedTranzactie.SubItems[0].Text;
            string pret = selectedTranzactie.SubItems[1].Text;
            string stare = selectedTranzactie.SubItems[2].Text;
            string idTurist = selectedTranzactie.SubItems[3].Text;
            string destinatie = selectedTranzactie.SubItems[4].Text;
            string cazare = selectedTranzactie.SubItems[5].Text;
            string transport = selectedTranzactie.SubItems[6].Text;
            string dataPlecare = selectedTranzactie.SubItems[7].Text;
            string dataIntoarcere = selectedTranzactie.SubItems[8].Text;

            // Find the corresponding item in lvTuristi
            ListViewItem connectedTurist = null;
            foreach (ListViewItem item in lvTuristi.Items)
            {
                if (item.SubItems[0].Text == idTurist)
                {
                    connectedTurist = item;
                    break;
                }
            }

            // Print the data from lvTranzactiiServicii
            e.Graphics.DrawString("ID Tranzactie: " + idTranzactie, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Pret: " + pret + " RON", printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Stare: " + stare, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Destinatie: " + destinatie, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Cazare: " + cazare, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Transport: " + transport, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Data Plecare: " + dataPlecare, printFont, brush, x, y);
            y += lineHeight;
            e.Graphics.DrawString("Data Intoarcere: " + dataIntoarcere, printFont, brush, x, y);
            y += lineHeight;

            // Add some spacing between lvTranzactiiServicii and lvTuristi data
            y += lineHeight * 2;

            //e.Graphics.DrawString("ID Turist: " + idTurist, printFont, brush, x, y);
            //y += lineHeight; // nu e nevoie iar cred

            // Print the data from lvTuristi
            if (connectedTurist != null)
            {
                string idTuristPrint = connectedTurist.SubItems[0].Text;
                string nume = connectedTurist.SubItems[1].Text;
                string telefon = connectedTurist.SubItems[2].Text;
                string email = connectedTurist.SubItems[3].Text;

                e.Graphics.DrawString("ID Turist: " + idTuristPrint, printFont, brush, x, y);
                y += lineHeight;
                e.Graphics.DrawString("Nume: " + nume, printFont, brush, x, y);
                y += lineHeight;
                e.Graphics.DrawString("Telefon: " + telefon, printFont, brush, x, y);
                y += lineHeight;
                e.Graphics.DrawString("Email: " + email, printFont, brush, x, y);
                y += lineHeight;
            }

            // Check if there are more pages to print
            e.HasMorePages = false;
        }

        private void bAZADEDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            //form.ShowDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Close();
            }
        }
    }
}