namespace Proiect_PAW
{
    partial class Form_Baza_De_Date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agentieDataSet = new Proiect_PAW.AgentieDataSet();
            this.agentieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentieTableAdapter = new Proiect_PAW.AgentieDataSetTableAdapters.AgentieTableAdapter();
            this.iDTranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cazareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlecareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIntoarcereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTuristDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbStare = new System.Windows.Forms.TextBox();
            this.tbDestinatie = new System.Windows.Forms.TextBox();
            this.tbCazare = new System.Windows.Forms.TextBox();
            this.tbTransport = new System.Windows.Forms.TextBox();
            this.tbIDTurist = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtDataPlecare = new System.Windows.Forms.DateTimePicker();
            this.dtDataIntoarcere = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbIDTranzactie = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSalveaza = new System.Windows.Forms.Button();
            this.bSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTranzactieDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.stareDataGridViewTextBoxColumn,
            this.destinatieDataGridViewTextBoxColumn,
            this.cazareDataGridViewTextBoxColumn,
            this.transportDataGridViewTextBoxColumn,
            this.dataPlecareDataGridViewTextBoxColumn,
            this.dataIntoarcereDataGridViewTextBoxColumn,
            this.iDTuristDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agentieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // agentieDataSet
            // 
            this.agentieDataSet.DataSetName = "AgentieDataSet";
            this.agentieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentieBindingSource
            // 
            this.agentieBindingSource.DataMember = "Agentie";
            this.agentieBindingSource.DataSource = this.agentieDataSet;
            // 
            // agentieTableAdapter
            // 
            this.agentieTableAdapter.ClearBeforeFill = true;
            // 
            // iDTranzactieDataGridViewTextBoxColumn
            // 
            this.iDTranzactieDataGridViewTextBoxColumn.DataPropertyName = "ID Tranzactie";
            this.iDTranzactieDataGridViewTextBoxColumn.HeaderText = "ID Tranzactie";
            this.iDTranzactieDataGridViewTextBoxColumn.Name = "iDTranzactieDataGridViewTextBoxColumn";
            this.iDTranzactieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // stareDataGridViewTextBoxColumn
            // 
            this.stareDataGridViewTextBoxColumn.DataPropertyName = "Stare";
            this.stareDataGridViewTextBoxColumn.HeaderText = "Stare";
            this.stareDataGridViewTextBoxColumn.Name = "stareDataGridViewTextBoxColumn";
            // 
            // destinatieDataGridViewTextBoxColumn
            // 
            this.destinatieDataGridViewTextBoxColumn.DataPropertyName = "Destinatie";
            this.destinatieDataGridViewTextBoxColumn.HeaderText = "Destinatie";
            this.destinatieDataGridViewTextBoxColumn.Name = "destinatieDataGridViewTextBoxColumn";
            // 
            // cazareDataGridViewTextBoxColumn
            // 
            this.cazareDataGridViewTextBoxColumn.DataPropertyName = "Cazare";
            this.cazareDataGridViewTextBoxColumn.HeaderText = "Cazare";
            this.cazareDataGridViewTextBoxColumn.Name = "cazareDataGridViewTextBoxColumn";
            // 
            // transportDataGridViewTextBoxColumn
            // 
            this.transportDataGridViewTextBoxColumn.DataPropertyName = "Transport";
            this.transportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.transportDataGridViewTextBoxColumn.Name = "transportDataGridViewTextBoxColumn";
            // 
            // dataPlecareDataGridViewTextBoxColumn
            // 
            this.dataPlecareDataGridViewTextBoxColumn.DataPropertyName = "Data Plecare";
            this.dataPlecareDataGridViewTextBoxColumn.HeaderText = "Data Plecare";
            this.dataPlecareDataGridViewTextBoxColumn.Name = "dataPlecareDataGridViewTextBoxColumn";
            // 
            // dataIntoarcereDataGridViewTextBoxColumn
            // 
            this.dataIntoarcereDataGridViewTextBoxColumn.DataPropertyName = "Data Intoarcere";
            this.dataIntoarcereDataGridViewTextBoxColumn.HeaderText = "Data Intoarcere";
            this.dataIntoarcereDataGridViewTextBoxColumn.Name = "dataIntoarcereDataGridViewTextBoxColumn";
            // 
            // iDTuristDataGridViewTextBoxColumn
            // 
            this.iDTuristDataGridViewTextBoxColumn.DataPropertyName = "ID Turist";
            this.iDTuristDataGridViewTextBoxColumn.HeaderText = "ID Turist";
            this.iDTuristDataGridViewTextBoxColumn.Name = "iDTuristDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(91, 488);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(173, 20);
            this.tbPret.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destinatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cazare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Transport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Plecare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data Intoarcere";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Turist";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nume";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 591);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Email";
            // 
            // tbStare
            // 
            this.tbStare.Location = new System.Drawing.Point(91, 523);
            this.tbStare.Name = "tbStare";
            this.tbStare.Size = new System.Drawing.Size(173, 20);
            this.tbStare.TabIndex = 13;
            // 
            // tbDestinatie
            // 
            this.tbDestinatie.Location = new System.Drawing.Point(91, 556);
            this.tbDestinatie.Name = "tbDestinatie";
            this.tbDestinatie.Size = new System.Drawing.Size(173, 20);
            this.tbDestinatie.TabIndex = 14;
            // 
            // tbCazare
            // 
            this.tbCazare.Location = new System.Drawing.Point(91, 588);
            this.tbCazare.Name = "tbCazare";
            this.tbCazare.Size = new System.Drawing.Size(173, 20);
            this.tbCazare.TabIndex = 15;
            // 
            // tbTransport
            // 
            this.tbTransport.Location = new System.Drawing.Point(91, 617);
            this.tbTransport.Name = "tbTransport";
            this.tbTransport.Size = new System.Drawing.Size(173, 20);
            this.tbTransport.TabIndex = 16;
            // 
            // tbIDTurist
            // 
            this.tbIDTurist.Location = new System.Drawing.Point(444, 491);
            this.tbIDTurist.Name = "tbIDTurist";
            this.tbIDTurist.Size = new System.Drawing.Size(173, 20);
            this.tbIDTurist.TabIndex = 19;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(444, 526);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(173, 20);
            this.tbNume.TabIndex = 20;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(444, 556);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(173, 20);
            this.tbTelefon.TabIndex = 21;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(444, 588);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(173, 20);
            this.tbEmail.TabIndex = 22;
            // 
            // dtDataPlecare
            // 
            this.dtDataPlecare.Location = new System.Drawing.Point(91, 646);
            this.dtDataPlecare.Name = "dtDataPlecare";
            this.dtDataPlecare.Size = new System.Drawing.Size(200, 20);
            this.dtDataPlecare.TabIndex = 23;
            // 
            // dtDataIntoarcere
            // 
            this.dtDataIntoarcere.Location = new System.Drawing.Point(91, 678);
            this.dtDataIntoarcere.Name = "dtDataIntoarcere";
            this.dtDataIntoarcere.Size = new System.Drawing.Size(200, 20);
            this.dtDataIntoarcere.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(753, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tbIDTranzactie
            // 
            this.tbIDTranzactie.Location = new System.Drawing.Point(91, 458);
            this.tbIDTranzactie.Name = "tbIDTranzactie";
            this.tbIDTranzactie.Size = new System.Drawing.Size(173, 20);
            this.tbIDTranzactie.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "ID Tranzactie";
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(974, 495);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 28;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSalveaza
            // 
            this.bSalveaza.Location = new System.Drawing.Point(974, 540);
            this.bSalveaza.Name = "bSalveaza";
            this.bSalveaza.Size = new System.Drawing.Size(75, 23);
            this.bSalveaza.TabIndex = 29;
            this.bSalveaza.Text = "Salveaza";
            this.bSalveaza.UseVisualStyleBackColor = true;
            this.bSalveaza.Click += new System.EventHandler(this.bSalveaza_Click);
            // 
            // bSterge
            // 
            this.bSterge.Location = new System.Drawing.Point(974, 586);
            this.bSterge.Name = "bSterge";
            this.bSterge.Size = new System.Drawing.Size(75, 23);
            this.bSterge.TabIndex = 30;
            this.bSterge.Text = "Sterge";
            this.bSterge.UseVisualStyleBackColor = true;
            this.bSterge.Click += new System.EventHandler(this.bSterge_Click);
            // 
            // Form_Baza_De_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 710);
            this.Controls.Add(this.bSterge);
            this.Controls.Add(this.bSalveaza);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbIDTranzactie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtDataIntoarcere);
            this.Controls.Add(this.dtDataPlecare);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbIDTurist);
            this.Controls.Add(this.tbTransport);
            this.Controls.Add(this.tbCazare);
            this.Controls.Add(this.tbDestinatie);
            this.Controls.Add(this.tbStare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Baza_De_Date";
            this.Text = "Form_Baza_De_Date";
            this.Load += new System.EventHandler(this.Form_Baza_De_Date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AgentieDataSet agentieDataSet;
        private System.Windows.Forms.BindingSource agentieBindingSource;
        private AgentieDataSetTableAdapters.AgentieTableAdapter agentieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cazareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlecareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIntoarcereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTuristDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbStare;
        private System.Windows.Forms.TextBox tbDestinatie;
        private System.Windows.Forms.TextBox tbCazare;
        private System.Windows.Forms.TextBox tbTransport;
        private System.Windows.Forms.TextBox tbIDTurist;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtDataPlecare;
        private System.Windows.Forms.DateTimePicker dtDataIntoarcere;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbIDTranzactie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSalveaza;
        private System.Windows.Forms.Button bSterge;
    }
}