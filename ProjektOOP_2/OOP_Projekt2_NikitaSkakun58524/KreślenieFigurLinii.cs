using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Projekt2_NikitaSkakun58524.FiguryGeometryczne;

namespace OOP_Projekt2_NikitaSkakun58524
{
    public partial class KreślenieFigurLinii : Form
    {
        Point Punkt;
        const ushort Margines = 10;
        const ushort MarginesFormularza = 20;
        Graphics Rysownica;
        Graphics RysownicaTymczasowa;
        Pen Pióro;
        SolidBrush Pędzel;
        SolidBrush solidBrush;
        Pen PióroTymczasowe;
        List<Punkt> LFG = new List<Punkt>();
        Color nsKolor;
        int nsNumerFigury = 0;
        Bitmap nsKopiaRysownicy;
        Color KolorWypełnienia;
     

        public KreślenieFigurLinii()
        {
            InitializeComponent();

            this.Location = new Point(Screen.PrimaryScreen.Bounds.X + MarginesFormularza, Screen.PrimaryScreen.Bounds.Y + 2 * MarginesFormularza);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);
            this.StartPosition = FormStartPosition.Manual;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            pbRysownica.Location = new Point(Left + MarginesFormularza, Top + MarginesFormularza);
            pbRysownica.Width = (int)(this.Width * 0.7F);
            pbRysownica.Height = (int)(this.Height * 0.6F);
            pbRysownica.BackColor = Color.Beige;
            pbRysownica.BorderStyle = BorderStyle.FixedSingle;
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);

            gbFigury_Linie.Location = new Point(pbRysownica.Left + pbRysownica.Width + Margines, pbRysownica.Top);
            gbAtrybutyGraficzne.Location = new Point(gbFigury_Linie.Left, gbFigury_Linie.Top + gbFigury_Linie.Height + Margines);

            Rysownica = Graphics.FromImage(pbRysownica.Image);
            RysownicaTymczasowa = pbRysownica.CreateGraphics();


            Punkt = Point.Empty;
            Pióro = new Pen(Color.Red, 1F);
            Pióro.DashStyle = DashStyle.Solid;
            Pióro.StartCap = LineCap.Round;
            Pióro.EndCap = LineCap.Round;
            PióroTymczasowe = new Pen(Color.Blue, 1);
            solidBrush = new SolidBrush(Color.Green);
            Pędzel = new SolidBrush(Color.Blue);
        }

        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //wypisanie wspólrzędnych X i Y
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //osługa zdarzeń dla lewego przycisku 
            if (e.Button == MouseButtons.Left)
            {
                Punkt = e.Location;
                if (rdbLiniaKreślonaMyszą.Checked)
                {
                    //LFG.Add(new LiniaKreślonaMyszą(Punkt));
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new LiniaKreślonaMyszą(Punkt, Pióro.Color, Pióro.DashStyle, (int)Pióro.Width));
                }
                
            }

        }
        DashStyle WybranyStylLinii(int i)
        {
            switch (i)
            {
                case 0: return DashStyle.Solid;
                case 1: return DashStyle.Dash;
                case 2: return DashStyle.DashDot;
                case 3: return DashStyle.Dot;
                default:
                    return DashStyle.Solid;

            }
        }
        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wypisanie wspólrzędnych X i Y
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                lblX.Text = e.Location.X.ToString();
                lblY.Text = e.Location.Y.ToString();

                int lewyGórnyNarożnikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
                int lewyGórnyNarożnikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
                int Szerokość = Math.Abs(Punkt.X - e.Location.X);
                int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);
                if (rdbPunkt.Checked) { }
                if (rdbLinia.Checked)
                {
                    RysownicaTymczasowa.DrawLine(PióroTymczasowe, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                }
                if (rdbElipsa.Checked)
                {
                    RysownicaTymczasowa.DrawEllipse(PióroTymczasowe, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rdbOkrąg.Checked)
                {
                    RysownicaTymczasowa.DrawEllipse(PióroTymczasowe, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Wysokość, Wysokość));
                }
                if (rdbLiniaKreślonaMyszą.Checked)
                {
                    ((LiniaKreślonaMyszą)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);

                    Rysownica.DrawLine(Pióro, Punkt, e.Location);
                    Punkt = e.Location;
                }
                if (rdbOkrągWypełniony.Checked)
                {
                    solidBrush = new SolidBrush(KolorWypełnienia);
                    RysownicaTymczasowa.FillEllipse(solidBrush, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Wysokość, Wysokość));
                }
                if (rdbProsrokąt.Checked)
                {
                    RysownicaTymczasowa.DrawRectangle(PióroTymczasowe, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rdbProstokątWypełniony.Checked)
                {
                    solidBrush = new SolidBrush(KolorWypełnienia);
                    RysownicaTymczasowa.FillRectangle(solidBrush, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                if (rdbKwadrat.Checked)
                {
                    RysownicaTymczasowa.DrawRectangle(PióroTymczasowe, new Rectangle(lewyGórnyNarożnikX, lewyGórnyNarożnikY, Szerokość, Wysokość));
                }
                pbRysownica.Refresh();
            }
        }

        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            //wypisanie wspólrzędnych X i Y
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            //deklaracje zmiennych pomocniczych i wyznaczenie parametrów prostokąta w którym ędzie wykreślona figura
            int lewyGórnyNatożnikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGórnyNatożnikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int szerokość = Math.Abs(Punkt.X - e.Location.X);
            int wysokość = Math.Abs(Punkt.Y - e.Location.Y);

            //rozpoznanie
            if (e.Button == MouseButtons.Left)
            {
                //rozpoznanie figury geometrycznej
                if (rdbPunkt.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Punkt(Punkt.X, Punkt.Y));
                    //utworzeniw egzeplarza i dodanie go referencji do LFG
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbLinia.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Linia(Punkt.X, Punkt.Y, e.Location.X, e.Location.Y));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbElipsa.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Elipsa(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość, wysokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbOkrąg.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Okrąg(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbOkrągWypełniony.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;

                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new OkrągWypełniony(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
     
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);

                }
                if (rdbProsrokąt.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Prostokąt(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość, wysokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbProstokątWypełniony.Checked)
                {
                    solidBrush.Color = btnKolorLinii.ForeColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new ProstokątWypełniony(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość, wysokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(solidBrush.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbLiniaKreślonaMyszą.Checked)
                {

                    ((LiniaKreślonaMyszą)LFG[LFG.Count - 1]).DodajNowyPunktKreslonejLinii(e.Location);
                    Rysownica.DrawLine(Pióro, Punkt, e.Location);
                }
                if (rdbKrzywaBaziera.Checked)
                {
                    if (gbFigury_Linie.Enabled)
                    {
                        LFG.Add(new KrzywaBeziera(Rysownica, Pióro, Punkt));
                        gbFigury_Linie.Enabled = false;
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych = 0;
                    }
                    else
                    {
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).DodajNowyPunktKontrolnych(e.Location, Rysownica);
                        ((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych++;
                    }
                    if (((KrzywaBeziera)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych == 3)
                    {
                        gbFigury_Linie.Enabled = true;
                        LFG[LFG.Count - 1].Wykreśl(Rysownica);
                    }
                }
                if (rdbKwadrat.Checked)
                {
                    Pióro.Color = btnKolorLinii.BackColor;
                    Pióro.DashStyle = WybranyStylLinii(cmbStylLinii.SelectedIndex);
                    Pióro.Width = X.Value;
                    LFG.Add(new Kwadrat(lewyGórnyNatożnikX, lewyGórnyNatożnikY, szerokość));
                    LFG[LFG.Count - 1].UstalAtrybutyGraficzne(Pióro.Color, Pióro.DashStyle, (int)Pióro.Width);
                    LFG[LFG.Count - 1].Wykreśl(Rysownica);
                }
                if (rdbKrzywaKardynalna.Checked)
                {
                    if (gbFigury_Linie.Enabled)
                    {
                        LFG.Add(new KrzywaKardynalna(Rysownica, Pióro, Punkt));
                        gbFigury_Linie.Enabled = false;
                        ((KrzywaKardynalna)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych = 0;
                    }
                    else
                    {
                        ((KrzywaKardynalna)LFG[LFG.Count - 1]).DodajNowyPunktKontrolnych(e.Location, Rysownica);
                        ((KrzywaKardynalna)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych++;
                    }
                    if (((KrzywaKardynalna)LFG[LFG.Count - 1]).LiczbaPunktówKontrolnych == 4)
                    {
                        gbFigury_Linie.Enabled = true;
                        LFG[LFG.Count - 1].Wykreśl(Rysownica);
                    }
                }
            }
            pbRysownica.Refresh();
        }

        private void btnPrzesuń_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int X, Y;
            Random rnd = new Random();

            for (int i = 0; i < LFG.Count; i++)
            {
                X = rnd.Next(Margines, Xmax - Margines);
                Y = rnd.Next(Margines, Ymax - Margines);

                LFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, X, Y);
                LFG[i].UaktualnijXY(X, Y);

            }
            pbRysownica.Refresh();
        }
        private void btnKolorWypełnienia_Click(object sender, EventArgs e)
        {

            ColorDialog OknoKolorów = new ColorDialog();

            OknoKolorów.Color = nsKolor;
            if (OknoKolorów.ShowDialog() == DialogResult.OK)
            {
                nsKolor = OknoKolorów.Color;
            }
            pbRysownica.BackColor = nsKolor;

        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            if (LFG.Count <= 0)
            {
                errorProvider1.SetError(btnCofnij, "ERROR: lista była pusta i 'COFNIJ' nie może być zrealizowana");
                return;
            }
            LFG.RemoveAt(LFG.Count - 1);
            Rysownica.Clear(pbRysownica.BackColor);
            for (int i = 0; i < LFG.Count; i++)
            {
                LFG[i].Wykreśl(Rysownica);

            }
            pbRysownica.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            int puWyświetlanaFigura;
            // użyjemy zmiennej globalnej IndeksFigury bo także jest używana przy sterowaniu ręcznym
            // można by także użyć timer1.Tag jak było na wykładzie
            LFG[nsNumerFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width >> 1, pbRysownica.Height >> 1);
            puWyświetlanaFigura = nsNumerFigury + 1;
            txtNumerFigury.Text = puWyświetlanaFigura.ToString();
            if (nsNumerFigury == LFG.Count - 1) nsNumerFigury = 0;
            else nsNumerFigury++;

            pbRysownica.Refresh();
        }

        private void btnKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog KolorDialog = new ColorDialog();
            KolorDialog.Color = Pióro.Color;

            if (KolorDialog.ShowDialog() == DialogResult.OK)
            {
                btnKolorLinii.BackColor = KolorDialog.Color;
                Pióro.Color = KolorDialog.Color;

            }
            KolorDialog.Dispose();

        }

        private void btnWłąćPokazFigurGeom_Click(object sender, EventArgs e)
        {
            if (LFG.Count == 0)
            {
                errorProvider1.SetError(btnWłąćPokazFigurGeom, "Nie masz figur");
                return;
            }
            else
                errorProvider1.Dispose();
            Rysownica = Graphics.FromImage(pbRysownica.Image); 
            nsKopiaRysownicy = pbRysownica.Image.Clone() as Bitmap;        
            Rysownica.Clear(pbRysownica.BackColor);

            if (btnAuto.Checked)
            {
                timer1.Enabled = true;
                timer1.Tag = nsNumerFigury;
                btnNastepny.Enabled = false;
                btnPoprzedni.Enabled = false;
            }
            if (btnPrzyciskowy.Checked)
            {
                timer1.Enabled = false;
                txtNumerFigury.Text = "1";
                LFG[0].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                pbRysownica.Refresh();
                btnPoprzedni.Enabled = true;
                btnNastepny.Enabled = true;
            }
            pbRysownica.Refresh();
            
        }



        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);

            if (nsNumerFigury == 0)
            {
                nsNumerFigury = LFG.Count - 1;
            }
            else nsNumerFigury--;

            int puWyświetlanaFigura = nsNumerFigury + 1;
            txtNumerFigury.Text = puWyświetlanaFigura.ToString();

            LFG[nsNumerFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width >> 1, pbRysownica.Height >> 1);

            pbRysownica.Refresh();
        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);

            if (nsNumerFigury == LFG.Count - 1)
            {
                nsNumerFigury = 0;
            }
            else nsNumerFigury++;

            int puWyświetlanaFigura = nsNumerFigury + 1;
            txtNumerFigury.Text = puWyświetlanaFigura.ToString();

            LFG[nsNumerFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width >> 1, pbRysownica.Height >> 1);

            pbRysownica.Refresh();
        }

        private void btnWyłąćPokazFigurGeom_Click(object sender, EventArgs e)
        {
            if (LFG.Count == 0) return;
            nsNumerFigury = 0;
            txtNumerFigury.Text = "";
            pbRysownica.Image = nsKopiaRysownicy.Clone() as Bitmap;
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            timer1.Enabled = false;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog OknoZapisuPliku = new SaveFileDialog();
            OknoZapisuPliku.Filter = "bmp|*.bmp";
            if (OknoZapisuPliku.ShowDialog() == DialogResult.OK)
                if (OknoZapisuPliku.FileName != "")
                    pbRysownica.Image.Save(OknoZapisuPliku.FileName);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog OknoWczytajFile = new OpenFileDialog();

            if (OknoWczytajFile.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.Image = Image.FromFile(OknoWczytajFile.FileName);
                pbRysownica.Refresh();
                nsKopiaRysownicy = pbRysownica.Image.Clone() as Bitmap;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            
            pbRysownica.BackColor = Color.White;
            pbRysownica.Refresh();
            LFG.Clear();
            this.Invalidate();
               
        }

        private void btnPowrówDoMenu_Click(object sender, EventArgs e)
        {
            Prezenter formPrezenter = new Prezenter();
            formPrezenter.Show();
            Hide();
        }

   
    }
}