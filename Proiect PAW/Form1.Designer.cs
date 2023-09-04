namespace Proiect_PAW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvTranzactiiServicii = new System.Windows.Forms.ListView();
            this.ID_Tranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Turist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cazare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Plecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Intoarcere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTranzactie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeTranzactieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaTranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereTuristiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaTuristiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaTuristiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRINTFACTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BAZADEDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbIDTranzactie = new System.Windows.Forms.Label();
            this.lbPret = new System.Windows.Forms.Label();
            this.lbStare = new System.Windows.Forms.Label();
            this.lbNume = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDestinatie = new System.Windows.Forms.Label();
            this.lbCazare = new System.Windows.Forms.Label();
            this.lbTransport = new System.Windows.Forms.Label();
            this.lbDataPlecare = new System.Windows.Forms.Label();
            this.lbDataIntoarcere = new System.Windows.Forms.Label();
            this.tbIDTranzactie = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbDestinatie = new System.Windows.Forms.ComboBox();
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.dtpDataPlecare = new System.Windows.Forms.DateTimePicker();
            this.dtpDataIntoarcere = new System.Windows.Forms.DateTimePicker();
            this.buttonAdaugaTranzactie = new System.Windows.Forms.Button();
            this.buttonEditeazaTranzactie = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.tbCazare = new System.Windows.Forms.TextBox();
            this.lbTranzactiiServicii = new System.Windows.Forms.Label();
            this.lvTuristi = new System.Windows.Forms.ListView();
            this.IDTurist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTuristi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeTuristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTuristi = new System.Windows.Forms.Label();
            this.tbIDTuristTranzactie = new System.Windows.Forms.TextBox();
            this.lbIDTuristTranzactie = new System.Windows.Forms.Label();
            this.lbIDTurist = new System.Windows.Forms.Label();
            this.tbIDTurist = new System.Windows.Forms.TextBox();
            this.buttonAdaugaTurist = new System.Windows.Forms.Button();
            this.buttonEditeazaTurist = new System.Windows.Forms.Button();
            this.cbStare = new System.Windows.Forms.ComboBox();
            this.epCazare = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.cmsTranzactie.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cmsTuristi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCazare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTranzactiiServicii
            // 
            this.lvTranzactiiServicii.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvTranzactiiServicii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Tranzactie,
            this.Pret,
            this.Stare,
            this.ID_Turist,
            this.Destinatie,
            this.Cazare,
            this.Transport,
            this.Data_Plecare,
            this.Data_Intoarcere});
            this.lvTranzactiiServicii.ContextMenuStrip = this.cmsTranzactie;
            this.lvTranzactiiServicii.HideSelection = false;
            this.lvTranzactiiServicii.Location = new System.Drawing.Point(12, 93);
            this.lvTranzactiiServicii.Name = "lvTranzactiiServicii";
            this.lvTranzactiiServicii.Size = new System.Drawing.Size(812, 195);
            this.lvTranzactiiServicii.TabIndex = 0;
            this.lvTranzactiiServicii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactiiServicii.View = System.Windows.Forms.View.Details;
            this.lvTranzactiiServicii.SelectedIndexChanged += new System.EventHandler(this.lvTranzactiiServicii_SelectedIndexChanged);
            // 
            // ID_Tranzactie
            // 
            this.ID_Tranzactie.Text = "ID Tranzactie";
            this.ID_Tranzactie.Width = 82;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            // 
            // Stare
            // 
            this.Stare.Text = "Stare";
            // 
            // ID_Turist
            // 
            this.ID_Turist.Text = "ID Turist";
            // 
            // Destinatie
            // 
            this.Destinatie.Text = "Destinatie";
            // 
            // Cazare
            // 
            this.Cazare.Text = "Cazare";
            // 
            // Transport
            // 
            this.Transport.Text = "Transport";
            // 
            // Data_Plecare
            // 
            this.Data_Plecare.Text = "Data Plecare";
            this.Data_Plecare.Width = 145;
            // 
            // Data_Intoarcere
            // 
            this.Data_Intoarcere.Text = "Data Intoarcere";
            this.Data_Intoarcere.Width = 221;
            // 
            // cmsTranzactie
            // 
            this.cmsTranzactie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeTranzactieToolStripMenuItem});
            this.cmsTranzactie.Name = "cmsTranzactie";
            this.cmsTranzactie.Size = new System.Drawing.Size(163, 26);
            this.cmsTranzactie.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTranzactie_Opening);
            // 
            // stergeTranzactieToolStripMenuItem
            // 
            this.stergeTranzactieToolStripMenuItem.Name = "stergeTranzactieToolStripMenuItem";
            this.stergeTranzactieToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.stergeTranzactieToolStripMenuItem.Text = "Sterge Tranzactie";
            this.stergeTranzactieToolStripMenuItem.Click += new System.EventHandler(this.stergeTranzactieToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.fisiereTuristiToolStripMenuItem,
            this.afisareGraficToolStripMenuItem,
            this.PRINTFACTURAToolStripMenuItem,
            this.BAZADEDATEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1387, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaTranzactiiToolStripMenuItem,
            this.incarcaToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.fisiereToolStripMenuItem.Text = "Fisiere Tranzactii";
            // 
            // salveazaTranzactiiToolStripMenuItem
            // 
            this.salveazaTranzactiiToolStripMenuItem.Name = "salveazaTranzactiiToolStripMenuItem";
            this.salveazaTranzactiiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaTranzactiiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salveazaTranzactiiToolStripMenuItem.Text = "Salveaza Tranzactii";
            this.salveazaTranzactiiToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // incarcaToolStripMenuItem
            // 
            this.incarcaToolStripMenuItem.Name = "incarcaToolStripMenuItem";
            this.incarcaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.incarcaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.incarcaToolStripMenuItem.Text = "Incarca Tranzactii";
            this.incarcaToolStripMenuItem.Click += new System.EventHandler(this.incarcaToolStripMenuItem_Click);
            // 
            // fisiereTuristiToolStripMenuItem
            // 
            this.fisiereTuristiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaTuristiToolStripMenuItem,
            this.incarcaTuristiToolStripMenuItem});
            this.fisiereTuristiToolStripMenuItem.Name = "fisiereTuristiToolStripMenuItem";
            this.fisiereTuristiToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.fisiereTuristiToolStripMenuItem.Text = "Fisiere Turisti";
            // 
            // salveazaTuristiToolStripMenuItem
            // 
            this.salveazaTuristiToolStripMenuItem.Name = "salveazaTuristiToolStripMenuItem";
            this.salveazaTuristiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salveazaTuristiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salveazaTuristiToolStripMenuItem.Text = "Salveaza Turisti";
            this.salveazaTuristiToolStripMenuItem.Click += new System.EventHandler(this.salveazaTuristiToolStripMenuItem_Click);
            // 
            // incarcaTuristiToolStripMenuItem
            // 
            this.incarcaTuristiToolStripMenuItem.Name = "incarcaTuristiToolStripMenuItem";
            this.incarcaTuristiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.incarcaTuristiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.incarcaTuristiToolStripMenuItem.Text = "Incarca Turisti";
            this.incarcaTuristiToolStripMenuItem.Click += new System.EventHandler(this.incarcaTuristiToolStripMenuItem_Click);
            // 
            // afisareGraficToolStripMenuItem
            // 
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.afisareGraficToolStripMenuItem.Text = "Afisare Grafic";
            this.afisareGraficToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficToolStripMenuItem_Click);
            // 
            // PRINTFACTURAToolStripMenuItem
            // 
            this.PRINTFACTURAToolStripMenuItem.Name = "PRINTFACTURAToolStripMenuItem";
            this.PRINTFACTURAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PRINTFACTURAToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.PRINTFACTURAToolStripMenuItem.Text = "PRINT FACTURA";
            this.PRINTFACTURAToolStripMenuItem.Click += new System.EventHandler(this.PRINTFACTURAToolStripMenuItem_Click);
            // 
            // BAZADEDATEToolStripMenuItem
            // 
            this.BAZADEDATEToolStripMenuItem.Name = "BAZADEDATEToolStripMenuItem";
            this.BAZADEDATEToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.BAZADEDATEToolStripMenuItem.Text = "BAZA DE DATE";
            this.BAZADEDATEToolStripMenuItem.Click += new System.EventHandler(this.bAZADEDATEToolStripMenuItem_Click);
            // 
            // lbIDTranzactie
            // 
            this.lbIDTranzactie.AutoSize = true;
            this.lbIDTranzactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTranzactie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIDTranzactie.Location = new System.Drawing.Point(34, 326);
            this.lbIDTranzactie.Name = "lbIDTranzactie";
            this.lbIDTranzactie.Size = new System.Drawing.Size(152, 25);
            this.lbIDTranzactie.TabIndex = 3;
            this.lbIDTranzactie.Text = "ID Tranzacție";
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPret.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPret.Location = new System.Drawing.Point(131, 368);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(55, 25);
            this.lbPret.TabIndex = 4;
            this.lbPret.Text = "Preț";
            // 
            // lbStare
            // 
            this.lbStare.AutoSize = true;
            this.lbStare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStare.Location = new System.Drawing.Point(118, 405);
            this.lbStare.Name = "lbStare";
            this.lbStare.Size = new System.Drawing.Size(68, 25);
            this.lbStare.TabIndex = 5;
            this.lbStare.Text = "Stare";
            // 
            // lbNume
            // 
            this.lbNume.AutoSize = true;
            this.lbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNume.Location = new System.Drawing.Point(916, 363);
            this.lbNume.Name = "lbNume";
            this.lbNume.Size = new System.Drawing.Size(139, 25);
            this.lbNume.TabIndex = 6;
            this.lbNume.Text = "Nume Turist";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTelefon.Location = new System.Drawing.Point(960, 405);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(91, 25);
            this.lbTelefon.TabIndex = 7;
            this.lbTelefon.Text = "Telefon";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(979, 449);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(70, 25);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "Email";
            // 
            // lbDestinatie
            // 
            this.lbDestinatie.AutoSize = true;
            this.lbDestinatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestinatie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDestinatie.Location = new System.Drawing.Point(68, 495);
            this.lbDestinatie.Name = "lbDestinatie";
            this.lbDestinatie.Size = new System.Drawing.Size(118, 25);
            this.lbDestinatie.TabIndex = 9;
            this.lbDestinatie.Text = "Destinație";
            // 
            // lbCazare
            // 
            this.lbCazare.AutoSize = true;
            this.lbCazare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCazare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCazare.Location = new System.Drawing.Point(99, 541);
            this.lbCazare.Name = "lbCazare";
            this.lbCazare.Size = new System.Drawing.Size(87, 25);
            this.lbCazare.TabIndex = 10;
            this.lbCazare.Text = "Cazare";
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTransport.Location = new System.Drawing.Point(73, 591);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(113, 25);
            this.lbTransport.TabIndex = 11;
            this.lbTransport.Text = "Transport";
            // 
            // lbDataPlecare
            // 
            this.lbDataPlecare.AutoSize = true;
            this.lbDataPlecare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPlecare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDataPlecare.Location = new System.Drawing.Point(38, 629);
            this.lbDataPlecare.Name = "lbDataPlecare";
            this.lbDataPlecare.Size = new System.Drawing.Size(148, 25);
            this.lbDataPlecare.TabIndex = 12;
            this.lbDataPlecare.Text = "Dată Plecare";
            // 
            // lbDataIntoarcere
            // 
            this.lbDataIntoarcere.AutoSize = true;
            this.lbDataIntoarcere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataIntoarcere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDataIntoarcere.Location = new System.Drawing.Point(12, 667);
            this.lbDataIntoarcere.Name = "lbDataIntoarcere";
            this.lbDataIntoarcere.Size = new System.Drawing.Size(174, 25);
            this.lbDataIntoarcere.TabIndex = 13;
            this.lbDataIntoarcere.Text = "Data Întoarcere";
            // 
            // tbIDTranzactie
            // 
            this.tbIDTranzactie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDTranzactie.Location = new System.Drawing.Point(192, 326);
            this.tbIDTranzactie.Name = "tbIDTranzactie";
            this.tbIDTranzactie.Size = new System.Drawing.Size(200, 20);
            this.tbIDTranzactie.TabIndex = 14;
            this.tbIDTranzactie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIDTranzactie_KeyDown);
            // 
            // tbPret
            // 
            this.tbPret.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPret.Location = new System.Drawing.Point(192, 368);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(200, 20);
            this.tbPret.TabIndex = 15;
            this.tbPret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPret_KeyDown);
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNume.Location = new System.Drawing.Point(1062, 368);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(200, 20);
            this.tbNume.TabIndex = 17;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // tbTelefon
            // 
            this.tbTelefon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelefon.Location = new System.Drawing.Point(1062, 410);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(200, 20);
            this.tbTelefon.TabIndex = 18;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEmail.Location = new System.Drawing.Point(1062, 455);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 20);
            this.tbEmail.TabIndex = 19;
            // 
            // cbDestinatie
            // 
            this.cbDestinatie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbDestinatie.FormattingEnabled = true;
            this.cbDestinatie.Items.AddRange(new object[] {
            "Grecia",
            "Italia",
            "Germania",
            "Franta"});
            this.cbDestinatie.Location = new System.Drawing.Point(192, 500);
            this.cbDestinatie.Name = "cbDestinatie";
            this.cbDestinatie.Size = new System.Drawing.Size(200, 21);
            this.cbDestinatie.TabIndex = 20;
            this.cbDestinatie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbDestinatie_KeyDown);
            // 
            // cbTransport
            // 
            this.cbTransport.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTransport.FormattingEnabled = true;
            this.cbTransport.Items.AddRange(new object[] {
            "Autocar",
            "Tren",
            "Avion",
            "Vapor"});
            this.cbTransport.Location = new System.Drawing.Point(192, 591);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(200, 21);
            this.cbTransport.TabIndex = 22;
            // 
            // dtpDataPlecare
            // 
            this.dtpDataPlecare.Location = new System.Drawing.Point(192, 632);
            this.dtpDataPlecare.Name = "dtpDataPlecare";
            this.dtpDataPlecare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPlecare.TabIndex = 23;
            // 
            // dtpDataIntoarcere
            // 
            this.dtpDataIntoarcere.Location = new System.Drawing.Point(192, 670);
            this.dtpDataIntoarcere.Name = "dtpDataIntoarcere";
            this.dtpDataIntoarcere.Size = new System.Drawing.Size(200, 20);
            this.dtpDataIntoarcere.TabIndex = 24;
            // 
            // buttonAdaugaTranzactie
            // 
            this.buttonAdaugaTranzactie.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdaugaTranzactie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaTranzactie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdaugaTranzactie.Location = new System.Drawing.Point(439, 472);
            this.buttonAdaugaTranzactie.Name = "buttonAdaugaTranzactie";
            this.buttonAdaugaTranzactie.Size = new System.Drawing.Size(335, 67);
            this.buttonAdaugaTranzactie.TabIndex = 25;
            this.buttonAdaugaTranzactie.Text = "Adaugă Tranzacție";
            this.buttonAdaugaTranzactie.UseVisualStyleBackColor = false;
            this.buttonAdaugaTranzactie.Click += new System.EventHandler(this.buttonAdaugaTranzactie_Click);
            // 
            // buttonEditeazaTranzactie
            // 
            this.buttonEditeazaTranzactie.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEditeazaTranzactie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditeazaTranzactie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditeazaTranzactie.Location = new System.Drawing.Point(439, 602);
            this.buttonEditeazaTranzactie.Name = "buttonEditeazaTranzactie";
            this.buttonEditeazaTranzactie.Size = new System.Drawing.Size(335, 67);
            this.buttonEditeazaTranzactie.TabIndex = 26;
            this.buttonEditeazaTranzactie.Text = "Editează Tranzacție";
            this.buttonEditeazaTranzactie.UseVisualStyleBackColor = false;
            this.buttonEditeazaTranzactie.Click += new System.EventHandler(this.buttonEditeazaTranzactie_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSterge.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSterge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSterge.Location = new System.Drawing.Point(439, 339);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(335, 67);
            this.buttonSterge.TabIndex = 27;
            this.buttonSterge.Text = "Șterge Normal sau Dublu";
            this.buttonSterge.UseVisualStyleBackColor = false;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // tbCazare
            // 
            this.tbCazare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCazare.Location = new System.Drawing.Point(192, 546);
            this.tbCazare.Name = "tbCazare";
            this.tbCazare.Size = new System.Drawing.Size(200, 20);
            this.tbCazare.TabIndex = 28;
            this.tbCazare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCazare_KeyDown);
            this.tbCazare.Validating += new System.ComponentModel.CancelEventHandler(this.tbCazare_Validating);
            // 
            // lbTranzactiiServicii
            // 
            this.lbTranzactiiServicii.AutoSize = true;
            this.lbTranzactiiServicii.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTranzactiiServicii.ForeColor = System.Drawing.Color.White;
            this.lbTranzactiiServicii.Location = new System.Drawing.Point(269, 45);
            this.lbTranzactiiServicii.Name = "lbTranzactiiServicii";
            this.lbTranzactiiServicii.Size = new System.Drawing.Size(294, 36);
            this.lbTranzactiiServicii.TabIndex = 29;
            this.lbTranzactiiServicii.Text = "Tranzacții și Servicii";
            // 
            // lvTuristi
            // 
            this.lvTuristi.AllowDrop = true;
            this.lvTuristi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvTuristi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDTurist,
            this.Nume,
            this.Telefon,
            this.Email});
            this.lvTuristi.ContextMenuStrip = this.cmsTuristi;
            this.lvTuristi.HideSelection = false;
            this.lvTuristi.Location = new System.Drawing.Point(935, 93);
            this.lvTuristi.Name = "lvTuristi";
            this.lvTuristi.Size = new System.Drawing.Size(440, 195);
            this.lvTuristi.TabIndex = 30;
            this.lvTuristi.UseCompatibleStateImageBehavior = false;
            this.lvTuristi.View = System.Windows.Forms.View.Details;
            this.lvTuristi.SelectedIndexChanged += new System.EventHandler(this.lvTuristi_SelectedIndexChanged);
            // 
            // IDTurist
            // 
            this.IDTurist.Text = "ID Turist";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 114;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 113;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 149;
            // 
            // cmsTuristi
            // 
            this.cmsTuristi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeTuristToolStripMenuItem});
            this.cmsTuristi.Name = "cmsTuristi";
            this.cmsTuristi.Size = new System.Drawing.Size(140, 26);
            this.cmsTuristi.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTuristi_Opening);
            // 
            // stergeTuristToolStripMenuItem
            // 
            this.stergeTuristToolStripMenuItem.Name = "stergeTuristToolStripMenuItem";
            this.stergeTuristToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.stergeTuristToolStripMenuItem.Text = "Sterge Turist";
            this.stergeTuristToolStripMenuItem.Click += new System.EventHandler(this.stergeTuristToolStripMenuItem_Click);
            // 
            // lbTuristi
            // 
            this.lbTuristi.AutoSize = true;
            this.lbTuristi.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuristi.ForeColor = System.Drawing.Color.White;
            this.lbTuristi.Location = new System.Drawing.Point(1098, 45);
            this.lbTuristi.Name = "lbTuristi";
            this.lbTuristi.Size = new System.Drawing.Size(106, 36);
            this.lbTuristi.TabIndex = 31;
            this.lbTuristi.Text = "Turiști";
            // 
            // tbIDTuristTranzactie
            // 
            this.tbIDTuristTranzactie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDTuristTranzactie.Location = new System.Drawing.Point(192, 454);
            this.tbIDTuristTranzactie.Name = "tbIDTuristTranzactie";
            this.tbIDTuristTranzactie.Size = new System.Drawing.Size(200, 20);
            this.tbIDTuristTranzactie.TabIndex = 32;
            this.tbIDTuristTranzactie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIDTuristTranzactie_KeyDown);
            // 
            // lbIDTuristTranzactie
            // 
            this.lbIDTuristTranzactie.AutoSize = true;
            this.lbIDTuristTranzactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTuristTranzactie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIDTuristTranzactie.Location = new System.Drawing.Point(85, 450);
            this.lbIDTuristTranzactie.Name = "lbIDTuristTranzactie";
            this.lbIDTuristTranzactie.Size = new System.Drawing.Size(101, 25);
            this.lbIDTuristTranzactie.TabIndex = 33;
            this.lbIDTuristTranzactie.Text = "ID Turist";
            // 
            // lbIDTurist
            // 
            this.lbIDTurist.AutoSize = true;
            this.lbIDTurist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTurist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIDTurist.Location = new System.Drawing.Point(952, 320);
            this.lbIDTurist.Name = "lbIDTurist";
            this.lbIDTurist.Size = new System.Drawing.Size(101, 25);
            this.lbIDTurist.TabIndex = 34;
            this.lbIDTurist.Text = "ID Turist";
            // 
            // tbIDTurist
            // 
            this.tbIDTurist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDTurist.Location = new System.Drawing.Point(1062, 326);
            this.tbIDTurist.Name = "tbIDTurist";
            this.tbIDTurist.Size = new System.Drawing.Size(200, 20);
            this.tbIDTurist.TabIndex = 35;
            // 
            // buttonAdaugaTurist
            // 
            this.buttonAdaugaTurist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdaugaTurist.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaTurist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdaugaTurist.Location = new System.Drawing.Point(1036, 504);
            this.buttonAdaugaTurist.Name = "buttonAdaugaTurist";
            this.buttonAdaugaTurist.Size = new System.Drawing.Size(273, 67);
            this.buttonAdaugaTurist.TabIndex = 36;
            this.buttonAdaugaTurist.Text = "Adaugă Turist";
            this.buttonAdaugaTurist.UseVisualStyleBackColor = false;
            this.buttonAdaugaTurist.Click += new System.EventHandler(this.buttonAdaugaTurist_Click);
            // 
            // buttonEditeazaTurist
            // 
            this.buttonEditeazaTurist.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEditeazaTurist.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditeazaTurist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditeazaTurist.Location = new System.Drawing.Point(1036, 605);
            this.buttonEditeazaTurist.Name = "buttonEditeazaTurist";
            this.buttonEditeazaTurist.Size = new System.Drawing.Size(273, 67);
            this.buttonEditeazaTurist.TabIndex = 37;
            this.buttonEditeazaTurist.Text = "Editează Turist";
            this.buttonEditeazaTurist.UseVisualStyleBackColor = false;
            this.buttonEditeazaTurist.Click += new System.EventHandler(this.buttonEditeazaTurist_Click);
            // 
            // cbStare
            // 
            this.cbStare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbStare.FormattingEnabled = true;
            this.cbStare.Items.AddRange(new object[] {
            "Achitat",
            "In curs",
            "Neachitat"});
            this.cbStare.Location = new System.Drawing.Point(192, 408);
            this.cbStare.Name = "cbStare";
            this.cbStare.Size = new System.Drawing.Size(200, 21);
            this.cbStare.TabIndex = 38;
            this.cbStare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbStare_KeyDown);
            // 
            // epCazare
            // 
            this.epCazare.ContainerControl = this;
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1387, 724);
            this.Controls.Add(this.cbStare);
            this.Controls.Add(this.buttonEditeazaTurist);
            this.Controls.Add(this.buttonAdaugaTurist);
            this.Controls.Add(this.tbIDTurist);
            this.Controls.Add(this.lbIDTurist);
            this.Controls.Add(this.lbIDTuristTranzactie);
            this.Controls.Add(this.tbIDTuristTranzactie);
            this.Controls.Add(this.lbTuristi);
            this.Controls.Add(this.lvTuristi);
            this.Controls.Add(this.lbTranzactiiServicii);
            this.Controls.Add(this.tbCazare);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonEditeazaTranzactie);
            this.Controls.Add(this.buttonAdaugaTranzactie);
            this.Controls.Add(this.dtpDataIntoarcere);
            this.Controls.Add(this.dtpDataPlecare);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.cbDestinatie);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbIDTranzactie);
            this.Controls.Add(this.lbDataIntoarcere);
            this.Controls.Add(this.lbDataPlecare);
            this.Controls.Add(this.lbTransport);
            this.Controls.Add(this.lbCazare);
            this.Controls.Add(this.lbDestinatie);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbNume);
            this.Controls.Add(this.lbStare);
            this.Controls.Add(this.lbPret);
            this.Controls.Add(this.lbIDTranzactie);
            this.Controls.Add(this.lvTranzactiiServicii);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Agentie de Turism";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsTranzactie.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsTuristi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCazare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTranzactiiServicii;
        private System.Windows.Forms.ColumnHeader ID_Tranzactie;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Stare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaTranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaToolStripMenuItem;
        private System.Windows.Forms.Label lbIDTranzactie;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.Label lbStare;
        private System.Windows.Forms.Label lbNume;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDestinatie;
        private System.Windows.Forms.Label lbCazare;
        private System.Windows.Forms.Label lbTransport;
        private System.Windows.Forms.Label lbDataPlecare;
        private System.Windows.Forms.Label lbDataIntoarcere;
        private System.Windows.Forms.TextBox tbIDTranzactie;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbDestinatie;
        private System.Windows.Forms.ComboBox cbTransport;
        private System.Windows.Forms.DateTimePicker dtpDataPlecare;
        private System.Windows.Forms.DateTimePicker dtpDataIntoarcere;
        private System.Windows.Forms.Button buttonAdaugaTranzactie;
        private System.Windows.Forms.Button buttonEditeazaTranzactie;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.TextBox tbCazare;
        private System.Windows.Forms.Label lbTranzactiiServicii;
        private System.Windows.Forms.ColumnHeader ID_Turist;
        private System.Windows.Forms.ColumnHeader Destinatie;
        private System.Windows.Forms.ColumnHeader Cazare;
        private System.Windows.Forms.ColumnHeader Transport;
        private System.Windows.Forms.ColumnHeader Data_Plecare;
        private System.Windows.Forms.ColumnHeader Data_Intoarcere;
        private System.Windows.Forms.Label lbTuristi;
        private System.Windows.Forms.ListView lvTuristi;
        private System.Windows.Forms.ColumnHeader IDTurist;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Label lbIDTuristTranzactie;
        private System.Windows.Forms.TextBox tbIDTuristTranzactie;
        private System.Windows.Forms.TextBox tbIDTurist;
        private System.Windows.Forms.Label lbIDTurist;
        private System.Windows.Forms.Button buttonEditeazaTurist;
        private System.Windows.Forms.Button buttonAdaugaTurist;
        private System.Windows.Forms.ComboBox cbStare;
        private System.Windows.Forms.ErrorProvider epCazare;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ToolStripMenuItem fisiereTuristiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaTuristiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaTuristiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTranzactie;
        private System.Windows.Forms.ToolStripMenuItem stergeTranzactieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTuristi;
        private System.Windows.Forms.ToolStripMenuItem stergeTuristToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PRINTFACTURAToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem BAZADEDATEToolStripMenuItem;
    }
}

