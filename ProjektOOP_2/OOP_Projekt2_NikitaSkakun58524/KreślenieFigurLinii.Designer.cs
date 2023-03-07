
namespace OOP_Projekt2_NikitaSkakun58524
{
    partial class KreślenieFigurLinii
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
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.rdbLinia = new System.Windows.Forms.RadioButton();
            this.rdbElipsa = new System.Windows.Forms.RadioButton();
            this.rdbOkrąg = new System.Windows.Forms.RadioButton();
            this.gbFigury_Linie = new System.Windows.Forms.GroupBox();
            this.rdbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            this.rdbKwadrat = new System.Windows.Forms.RadioButton();
            this.rdbProstokątWypełniony = new System.Windows.Forms.RadioButton();
            this.rdbProsrokąt = new System.Windows.Forms.RadioButton();
            this.rdbOkrągWypełniony = new System.Windows.Forms.RadioButton();
            this.rdbKrzywaBaziera = new System.Windows.Forms.RadioButton();
            this.rdbLiniaKreślonaMyszą = new System.Windows.Forms.RadioButton();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.gbAtrybutyGraficzne = new System.Windows.Forms.GroupBox();
            this.X = new System.Windows.Forms.TrackBar();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKolorTła = new System.Windows.Forms.Button();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.btnPrzesuń = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPowrówDoMenu = new System.Windows.Forms.Button();
            this.btnWłąćPokazFigurGeom = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.gbPokazFigur = new System.Windows.Forms.GroupBox();
            this.btnPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.btnAuto = new System.Windows.Forms.RadioButton();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.btnWyłąćPokazFigurGeom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.trbSuwakGrubościLinii = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.gbFigury_Linie.SuspendLayout();
            this.gbAtrybutyGraficzne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbPokazFigur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakGrubościLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRysownica
            // 
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.pbRysownica.Location = new System.Drawing.Point(179, 34);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(795, 416);
            this.pbRysownica.TabIndex = 0;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(500, 55);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "x";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // lblY
            // 
            this.lblY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(579, 55);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 17);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "y";
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbPunkt.Location = new System.Drawing.Point(13, 45);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(67, 22);
            this.rdbPunkt.TabIndex = 5;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // rdbLinia
            // 
            this.rdbLinia.AutoSize = true;
            this.rdbLinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbLinia.Location = new System.Drawing.Point(13, 73);
            this.rdbLinia.Name = "rdbLinia";
            this.rdbLinia.Size = new System.Drawing.Size(59, 22);
            this.rdbLinia.TabIndex = 6;
            this.rdbLinia.TabStop = true;
            this.rdbLinia.Text = "Linia";
            this.rdbLinia.UseVisualStyleBackColor = true;
            // 
            // rdbElipsa
            // 
            this.rdbElipsa.AutoSize = true;
            this.rdbElipsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbElipsa.Location = new System.Drawing.Point(14, 156);
            this.rdbElipsa.Name = "rdbElipsa";
            this.rdbElipsa.Size = new System.Drawing.Size(69, 22);
            this.rdbElipsa.TabIndex = 7;
            this.rdbElipsa.TabStop = true;
            this.rdbElipsa.Text = "Elipsa";
            this.rdbElipsa.UseVisualStyleBackColor = true;
            // 
            // rdbOkrąg
            // 
            this.rdbOkrąg.AutoSize = true;
            this.rdbOkrąg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbOkrąg.Location = new System.Drawing.Point(13, 128);
            this.rdbOkrąg.Name = "rdbOkrąg";
            this.rdbOkrąg.Size = new System.Drawing.Size(70, 22);
            this.rdbOkrąg.TabIndex = 8;
            this.rdbOkrąg.TabStop = true;
            this.rdbOkrąg.Text = "Okrąg";
            this.rdbOkrąg.UseVisualStyleBackColor = true;
            // 
            // gbFigury_Linie
            // 
            this.gbFigury_Linie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFigury_Linie.Controls.Add(this.rdbKrzywaKardynalna);
            this.gbFigury_Linie.Controls.Add(this.rdbKwadrat);
            this.gbFigury_Linie.Controls.Add(this.rdbProstokątWypełniony);
            this.gbFigury_Linie.Controls.Add(this.rdbProsrokąt);
            this.gbFigury_Linie.Controls.Add(this.rdbOkrągWypełniony);
            this.gbFigury_Linie.Controls.Add(this.rdbKrzywaBaziera);
            this.gbFigury_Linie.Controls.Add(this.rdbLiniaKreślonaMyszą);
            this.gbFigury_Linie.Controls.Add(this.btnCofnij);
            this.gbFigury_Linie.Controls.Add(this.rdbPunkt);
            this.gbFigury_Linie.Controls.Add(this.rdbOkrąg);
            this.gbFigury_Linie.Controls.Add(this.rdbLinia);
            this.gbFigury_Linie.Controls.Add(this.rdbElipsa);
            this.gbFigury_Linie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFigury_Linie.Location = new System.Drawing.Point(1016, 107);
            this.gbFigury_Linie.Name = "gbFigury_Linie";
            this.gbFigury_Linie.Size = new System.Drawing.Size(339, 252);
            this.gbFigury_Linie.TabIndex = 9;
            this.gbFigury_Linie.TabStop = false;
            this.gbFigury_Linie.Text = "Figure geometryczne";
            // 
            // rdbKrzywaKardynalna
            // 
            this.rdbKrzywaKardynalna.AutoSize = true;
            this.rdbKrzywaKardynalna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbKrzywaKardynalna.Location = new System.Drawing.Point(151, 157);
            this.rdbKrzywaKardynalna.Name = "rdbKrzywaKardynalna";
            this.rdbKrzywaKardynalna.Size = new System.Drawing.Size(153, 22);
            this.rdbKrzywaKardynalna.TabIndex = 18;
            this.rdbKrzywaKardynalna.TabStop = true;
            this.rdbKrzywaKardynalna.Text = "Krzywa kardynalna";
            this.rdbKrzywaKardynalna.UseVisualStyleBackColor = true;
            // 
            // rdbKwadrat
            // 
            this.rdbKwadrat.AutoSize = true;
            this.rdbKwadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbKwadrat.Location = new System.Drawing.Point(151, 129);
            this.rdbKwadrat.Name = "rdbKwadrat";
            this.rdbKwadrat.Size = new System.Drawing.Size(83, 22);
            this.rdbKwadrat.TabIndex = 17;
            this.rdbKwadrat.TabStop = true;
            this.rdbKwadrat.Text = "Kwadrat";
            this.rdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // rdbProstokątWypełniony
            // 
            this.rdbProstokątWypełniony.AutoSize = true;
            this.rdbProstokątWypełniony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbProstokątWypełniony.Location = new System.Drawing.Point(151, 101);
            this.rdbProstokątWypełniony.Name = "rdbProstokątWypełniony";
            this.rdbProstokątWypełniony.Size = new System.Drawing.Size(170, 22);
            this.rdbProstokątWypełniony.TabIndex = 16;
            this.rdbProstokątWypełniony.TabStop = true;
            this.rdbProstokątWypełniony.Text = "Prostokąt wypełniony";
            this.rdbProstokątWypełniony.UseVisualStyleBackColor = true;
            // 
            // rdbProsrokąt
            // 
            this.rdbProsrokąt.AutoSize = true;
            this.rdbProsrokąt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbProsrokąt.Location = new System.Drawing.Point(151, 73);
            this.rdbProsrokąt.Name = "rdbProsrokąt";
            this.rdbProsrokąt.Size = new System.Drawing.Size(94, 22);
            this.rdbProsrokąt.TabIndex = 15;
            this.rdbProsrokąt.TabStop = true;
            this.rdbProsrokąt.Text = "Prostokąt";
            this.rdbProsrokąt.UseVisualStyleBackColor = true;
            // 
            // rdbOkrągWypełniony
            // 
            this.rdbOkrągWypełniony.AutoSize = true;
            this.rdbOkrągWypełniony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbOkrągWypełniony.Location = new System.Drawing.Point(151, 45);
            this.rdbOkrągWypełniony.Name = "rdbOkrągWypełniony";
            this.rdbOkrągWypełniony.Size = new System.Drawing.Size(146, 22);
            this.rdbOkrągWypełniony.TabIndex = 14;
            this.rdbOkrągWypełniony.TabStop = true;
            this.rdbOkrągWypełniony.Text = "Okrąg wypełniony";
            this.rdbOkrągWypełniony.UseVisualStyleBackColor = true;
            // 
            // rdbKrzywaBaziera
            // 
            this.rdbKrzywaBaziera.AutoSize = true;
            this.rdbKrzywaBaziera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbKrzywaBaziera.Location = new System.Drawing.Point(14, 184);
            this.rdbKrzywaBaziera.Name = "rdbKrzywaBaziera";
            this.rdbKrzywaBaziera.Size = new System.Drawing.Size(132, 22);
            this.rdbKrzywaBaziera.TabIndex = 13;
            this.rdbKrzywaBaziera.TabStop = true;
            this.rdbKrzywaBaziera.Text = "Krzywa Baziera";
            this.rdbKrzywaBaziera.UseVisualStyleBackColor = true;
            // 
            // rdbLiniaKreślonaMyszą
            // 
            this.rdbLiniaKreślonaMyszą.AutoSize = true;
            this.rdbLiniaKreślonaMyszą.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbLiniaKreślonaMyszą.Location = new System.Drawing.Point(13, 101);
            this.rdbLiniaKreślonaMyszą.Name = "rdbLiniaKreślonaMyszą";
            this.rdbLiniaKreślonaMyszą.Size = new System.Drawing.Size(124, 22);
            this.rdbLiniaKreślonaMyszą.TabIndex = 12;
            this.rdbLiniaKreślonaMyszą.TabStop = true;
            this.rdbLiniaKreślonaMyszą.Text = "Linia kreślona ";
            this.rdbLiniaKreślonaMyszą.UseVisualStyleBackColor = true;
            // 
            // btnCofnij
            // 
            this.btnCofnij.Location = new System.Drawing.Point(21, 216);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(276, 30);
            this.btnCofnij.TabIndex = 11;
            this.btnCofnij.Text = "Cofnij ostatni element";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // gbAtrybutyGraficzne
            // 
            this.gbAtrybutyGraficzne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAtrybutyGraficzne.Controls.Add(this.X);
            this.gbAtrybutyGraficzne.Controls.Add(this.cmbStylLinii);
            this.gbAtrybutyGraficzne.Controls.Add(this.label4);
            this.gbAtrybutyGraficzne.Controls.Add(this.label2);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorTła);
            this.gbAtrybutyGraficzne.Controls.Add(this.btnKolorLinii);
            this.gbAtrybutyGraficzne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbAtrybutyGraficzne.Location = new System.Drawing.Point(1016, 359);
            this.gbAtrybutyGraficzne.Name = "gbAtrybutyGraficzne";
            this.gbAtrybutyGraficzne.Size = new System.Drawing.Size(308, 165);
            this.gbAtrybutyGraficzne.TabIndex = 10;
            this.gbAtrybutyGraficzne.TabStop = false;
            this.gbAtrybutyGraficzne.Text = "Atrybuty graficzne";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(155, 102);
            this.X.Maximum = 7;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(142, 56);
            this.X.TabIndex = 42;
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Kreskowa(Dash)",
            "KreskowoKropkowa(DashDot)",
            "Kropkowa(Dot)",
            "Ciągla(Solid)"});
            this.cmbStylLinii.Location = new System.Drawing.Point(155, 52);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(121, 30);
            this.cmbStylLinii.TabIndex = 41;
            this.cmbStylLinii.Text = "   Styl linii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kolor tła";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kolor linii";
            // 
            // btnKolorTła
            // 
            this.btnKolorTła.BackColor = System.Drawing.Color.Orange;
            this.btnKolorTła.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKolorTła.Location = new System.Drawing.Point(23, 114);
            this.btnKolorTła.Name = "btnKolorTła";
            this.btnKolorTła.Size = new System.Drawing.Size(100, 23);
            this.btnKolorTła.TabIndex = 38;
            this.btnKolorTła.UseVisualStyleBackColor = false;
            this.btnKolorTła.Click += new System.EventHandler(this.btnKolorWypełnienia_Click);
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.BackColor = System.Drawing.Color.Red;
            this.btnKolorLinii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKolorLinii.Location = new System.Drawing.Point(23, 59);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(100, 23);
            this.btnKolorLinii.TabIndex = 37;
            this.btnKolorLinii.UseVisualStyleBackColor = false;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // btnPrzesuń
            // 
            this.btnPrzesuń.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrzesuń.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrzesuń.Location = new System.Drawing.Point(1002, 528);
            this.btnPrzesuń.Name = "btnPrzesuń";
            this.btnPrzesuń.Size = new System.Drawing.Size(290, 64);
            this.btnPrzesuń.TabIndex = 9;
            this.btnPrzesuń.Text = "Przesuń figury heometryczne do nowej lokalizacji";
            this.btnPrzesuń.UseVisualStyleBackColor = true;
            this.btnPrzesuń.Click += new System.EventHandler(this.btnPrzesuń_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "0";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPowrówDoMenu
            // 
            this.btnPowrówDoMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPowrówDoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPowrówDoMenu.Location = new System.Drawing.Point(12, 549);
            this.btnPowrówDoMenu.Name = "btnPowrówDoMenu";
            this.btnPowrówDoMenu.Size = new System.Drawing.Size(124, 43);
            this.btnPowrówDoMenu.TabIndex = 11;
            this.btnPowrówDoMenu.Text = "Powrót";
            this.btnPowrówDoMenu.UseVisualStyleBackColor = true;
            this.btnPowrówDoMenu.Click += new System.EventHandler(this.btnPowrówDoMenu_Click);
            // 
            // btnWłąćPokazFigurGeom
            // 
            this.btnWłąćPokazFigurGeom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWłąćPokazFigurGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWłąćPokazFigurGeom.Location = new System.Drawing.Point(708, 472);
            this.btnWłąćPokazFigurGeom.Name = "btnWłąćPokazFigurGeom";
            this.btnWłąćPokazFigurGeom.Size = new System.Drawing.Size(188, 67);
            this.btnWłąćPokazFigurGeom.TabIndex = 12;
            this.btnWłąćPokazFigurGeom.Text = "Włąć pokaz figur geometrycznych";
            this.btnWłąćPokazFigurGeom.UseVisualStyleBackColor = true;
            this.btnWłąćPokazFigurGeom.Click += new System.EventHandler(this.btnWłąćPokazFigurGeom_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoprzedni.Enabled = false;
            this.btnPoprzedni.Location = new System.Drawing.Point(421, 530);
            this.btnPoprzedni.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(93, 26);
            this.btnPoprzedni.TabIndex = 19;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNastepny.Enabled = false;
            this.btnNastepny.Location = new System.Drawing.Point(533, 530);
            this.btnNastepny.Margin = new System.Windows.Forms.Padding(4);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(93, 26);
            this.btnNastepny.TabIndex = 18;
            this.btnNastepny.Text = "Następny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // gbPokazFigur
            // 
            this.gbPokazFigur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbPokazFigur.Controls.Add(this.btnPrzyciskowy);
            this.gbPokazFigur.Controls.Add(this.btnAuto);
            this.gbPokazFigur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPokazFigur.Location = new System.Drawing.Point(179, 475);
            this.gbPokazFigur.Name = "gbPokazFigur";
            this.gbPokazFigur.Size = new System.Drawing.Size(241, 49);
            this.gbPokazFigur.TabIndex = 20;
            this.gbPokazFigur.TabStop = false;
            this.gbPokazFigur.Text = "Pokaz figur";
            // 
            // btnPrzyciskowy
            // 
            this.btnPrzyciskowy.AutoSize = true;
            this.btnPrzyciskowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrzyciskowy.Location = new System.Drawing.Point(127, 21);
            this.btnPrzyciskowy.Name = "btnPrzyciskowy";
            this.btnPrzyciskowy.Size = new System.Drawing.Size(105, 21);
            this.btnPrzyciskowy.TabIndex = 22;
            this.btnPrzyciskowy.Text = "Przyciskowy";
            this.btnPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.AutoSize = true;
            this.btnAuto.Checked = true;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuto.Location = new System.Drawing.Point(6, 21);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(117, 21);
            this.btnAuto.TabIndex = 21;
            this.btnAuto.TabStop = true;
            this.btnAuto.Text = "Automatyczny";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNumerFigury.Location = new System.Drawing.Point(455, 499);
            this.txtNumerFigury.Multiline = true;
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(135, 24);
            this.txtNumerFigury.TabIndex = 22;
            this.txtNumerFigury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWyłąćPokazFigurGeom
            // 
            this.btnWyłąćPokazFigurGeom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWyłąćPokazFigurGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWyłąćPokazFigurGeom.Location = new System.Drawing.Point(708, 549);
            this.btnWyłąćPokazFigurGeom.Name = "btnWyłąćPokazFigurGeom";
            this.btnWyłąćPokazFigurGeom.Size = new System.Drawing.Size(188, 67);
            this.btnWyłąćPokazFigurGeom.TabIndex = 23;
            this.btnWyłąćPokazFigurGeom.Text = "Wyłąć pokaz figur geometrycznych";
            this.btnWyłąćPokazFigurGeom.UseVisualStyleBackColor = true;
            this.btnWyłąćPokazFigurGeom.Click += new System.EventHandler(this.btnWyłąćPokazFigurGeom_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(472, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Index figury";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWczytaj.Location = new System.Drawing.Point(33, 504);
            this.btnWczytaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(93, 26);
            this.btnWczytaj.TabIndex = 32;
            this.btnWczytaj.Text = "Odczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZapisz.Location = new System.Drawing.Point(33, 470);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(93, 26);
            this.btnZapisz.TabIndex = 33;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // trbSuwakGrubościLinii
            // 
            this.trbSuwakGrubościLinii.Location = new System.Drawing.Point(155, 102);
            this.trbSuwakGrubościLinii.Maximum = 7;
            this.trbSuwakGrubościLinii.Name = "trbSuwakGrubościLinii";
            this.trbSuwakGrubościLinii.Size = new System.Drawing.Size(142, 56);
            this.trbSuwakGrubościLinii.TabIndex = 42;
            // 
            // KreślenieFigurLinii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 703);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWyłąćPokazFigurGeom);
            this.Controls.Add(this.txtNumerFigury);
            this.Controls.Add(this.gbPokazFigur);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.btnWłąćPokazFigurGeom);
            this.Controls.Add(this.btnPowrówDoMenu);
            this.Controls.Add(this.btnPrzesuń);
            this.Controls.Add(this.gbAtrybutyGraficzne);
            this.Controls.Add(this.gbFigury_Linie);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Name = "KreślenieFigurLinii";
            this.Text = "Kreślenie figur linii";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.gbFigury_Linie.ResumeLayout(false);
            this.gbFigury_Linie.PerformLayout();
            this.gbAtrybutyGraficzne.ResumeLayout(false);
            this.gbAtrybutyGraficzne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbPokazFigur.ResumeLayout(false);
            this.gbPokazFigur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakGrubościLinii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.RadioButton rdbLinia;
        private System.Windows.Forms.RadioButton rdbElipsa;
        private System.Windows.Forms.RadioButton rdbOkrąg;
        private System.Windows.Forms.GroupBox gbFigury_Linie;
        private System.Windows.Forms.GroupBox gbAtrybutyGraficzne;
        private System.Windows.Forms.Button btnPrzesuń;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rdbLiniaKreślonaMyszą;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKolorTła;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.TrackBar X;
        private System.Windows.Forms.RadioButton rdbKrzywaBaziera;
        private System.Windows.Forms.Button btnPowrówDoMenu;
        private System.Windows.Forms.Button btnWłąćPokazFigurGeom;
        private System.Windows.Forms.GroupBox gbPokazFigur;
        private System.Windows.Forms.RadioButton btnPrzyciskowy;
        private System.Windows.Forms.RadioButton btnAuto;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Button btnWyłąćPokazFigurGeom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbKwadrat;
        private System.Windows.Forms.RadioButton rdbProstokątWypełniony;
        private System.Windows.Forms.RadioButton rdbProsrokąt;
        private System.Windows.Forms.RadioButton rdbOkrągWypełniony;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.RadioButton rdbKrzywaKardynalna;
        private System.Windows.Forms.TrackBar trbSuwakGrubościLinii;
    }
}