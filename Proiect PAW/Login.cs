using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate the login credentials
            bool isValid = ValidateLogin(username, password);

            if (isValid) // daca datele de autentificare sunt corecte
            {
                MessageBox.Show("Bine ai venit, utilizatorule!", "Autentificare reusita", MessageBoxButtons.OK);
                Form_Baza_De_Date form = new Form_Baza_De_Date();
                if(form.ShowDialog()==DialogResult.OK)
                {
                    form.Close();
                }
            }
            else
            {
                MessageBox.Show("Datele de conectare sunt gresite!", "Eroare Login", MessageBoxButtons.OK);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Perform the login validation
            // You can replace this with your own logic
            return (username == "ITeodor53D" && password == "stud");
        }

        public void TogglePasswordVisibility(bool isVisible)
        {
            textBox2.UseSystemPasswordChar = !isVisible;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItems.Count > 0)
            {
                lb.DoDragDrop(lb.SelectedItems[0], DragDropEffects.Copy); // sau Move si se sterge din lb ce mutam
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            textBox1.Text = data;

            if (e.Effect == DragDropEffects.Copy)
            {
                //listBox1.Items.Remove(data);
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
