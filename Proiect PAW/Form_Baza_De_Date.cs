using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form_Baza_De_Date : Form
    {
        DataSet DSAgentie = new DataSet();
        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agentie;";
        // Initial catalog este denumirea bazei de date si stergem tot ce este dupa ; ( pastram ; de la finalul denumirii )
        string selectCommand = "select * from agentie";

        public Form_Baza_De_Date()
        {
            InitializeComponent();

            IncarcaDate();
        }

        private void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            adaptor.Fill(DSAgentie, "Agentie");

            DSAgentie.Tables["Agentie"].PrimaryKey = new DataColumn[1]
            {
                DSAgentie.Tables["Agentie"].Columns["ID Tranzactie"]
            };

            conexiune.Close();

            comboBox1.DataBindings.Clear();
            comboBox1.DataSource = DSAgentie.Tables["Agentie"];
            comboBox1.DisplayMember = "Nume";
            comboBox1.ValueMember = "ID Tranzactie";

            tbIDTranzactie.DataBindings.Clear();
            tbNume.DataBindings.Clear();

            tbIDTranzactie.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "ID Tranzactie");
            tbPret.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Pret");
            tbStare.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Stare");
            tbDestinatie.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Destinatie");
            tbCazare.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Cazare");
            tbTransport.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Transport");
            dtDataPlecare.DataBindings.Add("Value", DSAgentie.Tables["Agentie"], "Data Plecare");
            dtDataIntoarcere.DataBindings.Add("Value", DSAgentie.Tables["Agentie"], "Data Intoarcere");
            tbIDTurist.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "ID Turist");
            tbNume.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Nume");
            tbTelefon.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Telefon");
            tbEmail.DataBindings.Add("Text", DSAgentie.Tables["Agentie"], "Email");
        }

        private void Form_Baza_De_Date_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentieDataSet.Agentie' table. You can move, or remove it, as needed.
            this.agentieTableAdapter.Fill(this.agentieDataSet.Agentie);
            // TODO: This line of code loads data into the 'mediciDataSet.Medici' table. You can move, or remove it, as needed.
            //this.DSAgentieTabl.Fill(this.mediciDataSet.Medici);
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                agentieBindingSource.EndEdit();

                int i = agentieTableAdapter.Update(agentieDataSet.Agentie);
                // fara .Medici updateaza toate tabelele si nu e ok !!!!
                // aceasta linie de update trebuie facuta pentru fiecare tabela in parte !!!

                MessageBox.Show("Salvare cu succes " + i + " linii!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            IncarcaDate(); // ca sa se updateze combobox-ul imediat dupa ce am updatat tabela si am apasat butonul update
        }

        private void bSalveaza_Click(object sender, EventArgs e)
        {
            BindingManagerBase legatura = BindingContext[DSAgentie.Tables["Agentie"]];

            legatura.EndCurrentEdit(); // ca sa termin editarea

            string selectCommand = "";
            string updateCommand = "update agentie set ID_Tranzactie=@ID_Tranzactie, Pret=@Pret, Stare=@Stare, Destinatie=@Destinatie, Cazare=@Cazare, Transport=@Transport, Data_Plecare=@Data_Plecare, Data_Intoarcere=@Data_Intoarcere, ID_Turist=@ID_Turist, Nume=@Nume, Telefon=@Telefon, Email=@Email where ID_Tranzactie=@ID_Tranzactie";

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            adaptor.UpdateCommand = conexiune.CreateCommand();
            adaptor.UpdateCommand.CommandText = updateCommand;
            adaptor.UpdateCommand.Parameters.AddWithValue("ID Tranzactie", tbIDTranzactie.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Pret", tbPret.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Stare", tbStare.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Destinatie", tbDestinatie.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Cazare", tbCazare.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Transport", tbTransport.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Data Plecare", dtDataPlecare.Value);
            adaptor.UpdateCommand.Parameters.AddWithValue("Data Intoarcere", dtDataIntoarcere.Value);
            adaptor.UpdateCommand.Parameters.AddWithValue("ID Turist", tbIDTurist.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Nume", tbNume.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Telefon", tbTelefon.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("Email", tbEmail.Text);

            int Id = (int)comboBox1.SelectedValue;

            adaptor.UpdateCommand.Parameters.AddWithValue("ID Tranzactie", Id);

            DataSet DSAgentieModificari = DSAgentie.GetChanges();

            if (DSAgentieModificari != null)
            {
                int i = adaptor.Update(DSAgentieModificari, "Agentie"); // modificari pe tabela Agentie
                MessageBox.Show("Au fost actualizate " + i + " linii");

                DataTable tabela = DSAgentie.Tables["Agentie"];
                DataRow linie = tabela.Rows.Find(Id);
                linie.AcceptChanges();
            }

            conexiune.Close();
            this.agentieTableAdapter.Fill(this.agentieDataSet.Agentie);
        }

        private void bSterge_Click(object sender, EventArgs e)
        {
            string selectCommand = "";
            string deleteCommand = "delete dbo.agentie where ID_Tranzactie=@ID_Tranzactie";

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            SqlDataAdapter adaptor = new SqlDataAdapter(selectCommand, conexiune);
            adaptor.DeleteCommand = conexiune.CreateCommand();
            adaptor.DeleteCommand.CommandText = deleteCommand;

            int Id = (int)comboBox1.SelectedValue;

            adaptor.DeleteCommand.Parameters.AddWithValue("ID Tranzactie", Id);

            DataTable tabela = DSAgentie.Tables["Agentie"];
            tabela.Rows.Find(Id).Delete();

            int i = adaptor.Update(tabela.GetChanges());
            tabela.AcceptChanges();

            MessageBox.Show("S-au sters " + i + " linii");

            conexiune.Close();
            this.agentieTableAdapter.Fill(this.agentieDataSet.Agentie);
        }
    }
}