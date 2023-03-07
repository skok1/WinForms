
namespace OOP_Projekt2_NikitaSkakun58524
{
    partial class PrezentacjaZeSlajderem
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnPowrót = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chlbFiguryGeometryczne = new System.Windows.Forms.CheckedListBox();
            this.btnPrzesyńFG = new System.Windows.Forms.Button();
            this.btnZmianaAtrybutówGraficznych = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnWyłąćSlajderFigurGeom = new System.Windows.Forms.Button();
            this.btnWłąćSjaderFigurGeom = new System.Windows.Forms.Button();
            this.grbPokazFigur = new System.Windows.Forms.GroupBox();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.rdbPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.txtNumerFigury = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnWczytaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grbPokazFigur.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(52, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 80);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "START\r\n(rozpoczęcie prezentacji)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(80, 79);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(135, 24);
            this.txtN.TabIndex = 19;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Podaj liczbę figur\r\ngeometrycznych";
            // 
            // pbRysownica
            // 
            this.pbRysownica.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.pbRysownica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRysownica.BackColor = System.Drawing.SystemColors.Info;
            this.pbRysownica.Location = new System.Drawing.Point(363, 53);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(661, 448);
            this.pbRysownica.TabIndex = 17;
            this.pbRysownica.TabStop = false;
            // 
            // btnPowrót
            // 
            this.btnPowrót.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPowrót.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPowrót.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPowrót.Location = new System.Drawing.Point(1085, 53);
            this.btnPowrót.Name = "btnPowrót";
            this.btnPowrót.Size = new System.Drawing.Size(222, 53);
            this.btnPowrót.TabIndex = 16;
            this.btnPowrót.Text = "Powrót";
            this.btnPowrót.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPowrót.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chlbFiguryGeometryczne
            // 
            this.chlbFiguryGeometryczne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chlbFiguryGeometryczne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chlbFiguryGeometryczne.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.chlbFiguryGeometryczne, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.chlbFiguryGeometryczne.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Okrąg wypełniony",
            "Prostokąt",
            "Prostokąt wypełniony",
            "Kwadrat"});
            this.chlbFiguryGeometryczne.Location = new System.Drawing.Point(1094, 141);
            this.chlbFiguryGeometryczne.Name = "chlbFiguryGeometryczne";
            this.chlbFiguryGeometryczne.Size = new System.Drawing.Size(237, 422);
            this.chlbFiguryGeometryczne.TabIndex = 21;
            // 
            // btnPrzesyńFG
            // 
            this.btnPrzesyńFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrzesyńFG.Location = new System.Drawing.Point(52, 219);
            this.btnPrzesyńFG.Name = "btnPrzesyńFG";
            this.btnPrzesyńFG.Size = new System.Drawing.Size(200, 84);
            this.btnPrzesyńFG.TabIndex = 22;
            this.btnPrzesyńFG.Text = "Przesuń figury heometryczne do nowej lokalizacji";
            this.btnPrzesyńFG.UseVisualStyleBackColor = true;
            this.btnPrzesyńFG.Click += new System.EventHandler(this.btnPrzesyńFG_Click);
            // 
            // btnZmianaAtrybutówGraficznych
            // 
            this.btnZmianaAtrybutówGraficznych.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZmianaAtrybutówGraficznych.Location = new System.Drawing.Point(52, 321);
            this.btnZmianaAtrybutówGraficznych.Name = "btnZmianaAtrybutówGraficznych";
            this.btnZmianaAtrybutówGraficznych.Size = new System.Drawing.Size(200, 84);
            this.btnZmianaAtrybutówGraficznych.TabIndex = 23;
            this.btnZmianaAtrybutówGraficznych.Text = "Zmień atrybuty graficzne ";
            this.btnZmianaAtrybutówGraficznych.UseVisualStyleBackColor = true;
            this.btnZmianaAtrybutówGraficznych.Click += new System.EventHandler(this.btnZmianaAtrybutówGraficznych_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnWyłąćSlajderFigurGeom
            // 
            this.btnWyłąćSlajderFigurGeom.Enabled = false;
            this.btnWyłąćSlajderFigurGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWyłąćSlajderFigurGeom.Location = new System.Drawing.Point(52, 513);
            this.btnWyłąćSlajderFigurGeom.Name = "btnWyłąćSlajderFigurGeom";
            this.btnWyłąćSlajderFigurGeom.Size = new System.Drawing.Size(200, 86);
            this.btnWyłąćSlajderFigurGeom.TabIndex = 25;
            this.btnWyłąćSlajderFigurGeom.Text = "Wyłąć slajder figur geometrycznych";
            this.btnWyłąćSlajderFigurGeom.UseVisualStyleBackColor = true;
            this.btnWyłąćSlajderFigurGeom.Click += new System.EventHandler(this.btnWyłąćPokazFigurGeom_Click);
            // 
            // btnWłąćSjaderFigurGeom
            // 
            this.btnWłąćSjaderFigurGeom.Enabled = false;
            this.btnWłąćSjaderFigurGeom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWłąćSjaderFigurGeom.Location = new System.Drawing.Point(52, 421);
            this.btnWłąćSjaderFigurGeom.Name = "btnWłąćSjaderFigurGeom";
            this.btnWłąćSjaderFigurGeom.Size = new System.Drawing.Size(200, 80);
            this.btnWłąćSjaderFigurGeom.TabIndex = 24;
            this.btnWłąćSjaderFigurGeom.Text = "Włąć slajder figur geometrycznych";
            this.btnWłąćSjaderFigurGeom.UseVisualStyleBackColor = true;
            this.btnWłąćSjaderFigurGeom.Click += new System.EventHandler(this.btnWłąćPokazFigurGeom_Click);
            // 
            // grbPokazFigur
            // 
            this.grbPokazFigur.Controls.Add(this.rdbAuto);
            this.grbPokazFigur.Controls.Add(this.rdbPrzyciskowy);
            this.grbPokazFigur.Enabled = false;
            this.grbPokazFigur.Location = new System.Drawing.Point(431, 529);
            this.grbPokazFigur.Name = "grbPokazFigur";
            this.grbPokazFigur.Size = new System.Drawing.Size(236, 86);
            this.grbPokazFigur.TabIndex = 26;
            this.grbPokazFigur.TabStop = false;
            this.grbPokazFigur.Text = "Pokaz figur";
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Location = new System.Drawing.Point(6, 21);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(117, 21);
            this.rdbAuto.TabIndex = 27;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "Automatyczny";
            this.rdbAuto.UseVisualStyleBackColor = true;
            // 
            // rdbPrzyciskowy
            // 
            this.rdbPrzyciskowy.AutoSize = true;
            this.rdbPrzyciskowy.Location = new System.Drawing.Point(6, 48);
            this.rdbPrzyciskowy.Name = "rdbPrzyciskowy";
            this.rdbPrzyciskowy.Size = new System.Drawing.Size(100, 21);
            this.rdbPrzyciskowy.TabIndex = 28;
            this.rdbPrzyciskowy.TabStop = true;
            this.rdbPrzyciskowy.Text = "Pzyciskowy";
            this.rdbPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Enabled = false;
            this.btnPoprzedni.Location = new System.Drawing.Point(692, 566);
            this.btnPoprzedni.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(93, 26);
            this.btnPoprzedni.TabIndex = 28;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.Enabled = false;
            this.btnNastepny.Location = new System.Drawing.Point(692, 529);
            this.btnNastepny.Margin = new System.Windows.Forms.Padding(4);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(93, 26);
            this.btnNastepny.TabIndex = 27;
            this.btnNastepny.Text = "Następny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // txtNumerFigury
            // 
            this.txtNumerFigury.Enabled = false;
            this.txtNumerFigury.Location = new System.Drawing.Point(810, 563);
            this.txtNumerFigury.Multiline = true;
            this.txtNumerFigury.Name = "txtNumerFigury";
            this.txtNumerFigury.Size = new System.Drawing.Size(135, 24);
            this.txtNumerFigury.TabIndex = 29;
            this.txtNumerFigury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(820, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Index figury";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(963, 529);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(93, 26);
            this.btnZapisz.TabIndex = 35;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(963, 563);
            this.btnWczytaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(93, 26);
            this.btnWczytaj.TabIndex = 34;
            this.btnWczytaj.Text = "Odczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // PrezentacjaZeSlajderem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 637);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumerFigury);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.grbPokazFigur);
            this.Controls.Add(this.btnWyłąćSlajderFigurGeom);
            this.Controls.Add(this.btnWłąćSjaderFigurGeom);
            this.Controls.Add(this.btnZmianaAtrybutówGraficznych);
            this.Controls.Add(this.btnPrzesyńFG);
            this.Controls.Add(this.chlbFiguryGeometryczne);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnPowrót);
            this.Name = "PrezentacjaZeSlajderem";
            this.Text = "Prezentacja figur ze slajderem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrezentacjaZeSlajderem_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrezentacjaZeSlajderem_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grbPokazFigur.ResumeLayout(false);
            this.grbPokazFigur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnPowrót;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chlbFiguryGeometryczne;
        private System.Windows.Forms.Button btnPrzesyńFG;
        private System.Windows.Forms.Button btnZmianaAtrybutówGraficznych;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnWyłąćSlajderFigurGeom;
        private System.Windows.Forms.Button btnWłąćSjaderFigurGeom;
        private System.Windows.Forms.GroupBox grbPokazFigur;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.RadioButton rdbPrzyciskowy;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumerFigury;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnWczytaj;
    }
}