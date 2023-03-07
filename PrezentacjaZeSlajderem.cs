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
    public partial class PrezentacjaZeSlajderem : Form
    {
        //deklaracje zmiennych
        Graphics Rysownica;
        Punkt[] TFG;
        int IndexTFG;
        const int Margines = 10;
        const int MarginesFoormularza = 20;
        int nsNumerFigury = 0;
        List<Punkt> LFG = new List<Punkt>();
        Bitmap nsKopiaRysownicy;
        List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();
        Pen pióro;


        public PrezentacjaZeSlajderem()
        {
            InitializeComponent();
            
            this.Left = Screen.PrimaryScreen.Bounds.X + MarginesFoormularza;
            this.Top = Screen.PrimaryScreen.Bounds.Y + MarginesFoormularza;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.85F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75F);
            //ustawenie StartPosition
            this.StartPosition = FormStartPosition.Manual;
            //dodatkowe ustawienie atrybutów
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pbRysownica.Location = new Point(btnStart.Location.X + btnStart.Width + Margines, txtN.Top);
            pbRysownica.Width = (int)(this.Width * 0.65F);
            pbRysownica.Height = (int)(this.Height * 0.55F);
            pbRysownica.BackColor = Color.Beige;
            pbRysownica.BorderStyle = BorderStyle.Fixed3D;
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            Rysownica = Graphics.FromImage(pbRysownica.Image);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //deklaracje pomocnicze
            ushort N;
            errorProvider1.Dispose();

            if (string.IsNullOrEmpty(txtN.Text.Trim()))
            {
                errorProvider1.SetError(txtN, "ERROR: musisz podać liczbę figur geometrycznych!");
                return;
            }
            if (!ushort.TryParse(txtN.Text, out N))
            {
                errorProvider1.SetError(txtN, "ERROR: niedozwolony znak w zapisie");
                return;
            }

            TFG = new Punkt[N];
            IndexTFG = 0;

            if (chlbFiguryGeometryczne.CheckedItems.Count <= 0)
            {
                errorProvider1.SetError(chlbFiguryGeometryczne, "ERROR: musisz wybrać co najmnej 1 figurę!");
                return;
            }
            CheckedListBox.CheckedItemCollection WybraneFigury = chlbFiguryGeometryczne.CheckedItems;

            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;

            int X, Y;
            Color KolorLinii;
            Color KolorWypełneniaFiguryGeometrycznej;
            int GruboścLinii;
            DashStyle StylLinii;
            int RozmiarPunktu;
            int WylosowanyIndexFiguryGeometrycznej;
            int Xk, Yk;
            int OśDuża, OśMała;
            int Promień;
            int Szerokośc, Wysokość;
          

            for (int i = 0; i < N; i++)
            {
                X = rnd.Next(Margines, Xmax - Margines);
                Y = rnd.Next(Margines, Ymax - Margines);
                //wylosowanie koloru linii
                KolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                KolorWypełneniaFiguryGeometrycznej = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                //wylosowanie grubości linii
                GruboścLinii = rnd.Next(1, 10);
                //...stylu
                switch (rnd.Next(1, 6))
                {
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.DashDot; break;
                    case 3: StylLinii = DashStyle.DashDotDot; break;
                    case 4: StylLinii = DashStyle.Dot; break;
                    case 5: StylLinii = DashStyle.Solid; break;
                    default: StylLinii = DashStyle.Solid; break;
                }
                //wylosowanie figur
                WylosowanyIndexFiguryGeometrycznej = rnd.Next(WybraneFigury.Count);

                //rozpoznanie figury
                switch (WybraneFigury[WylosowanyIndexFiguryGeometrycznej].ToString())
                {
                    case "Punkt": TFG[IndexTFG] = new Punkt(X, Y);
                        RozmiarPunktu = rnd.Next(3, Margines);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, RozmiarPunktu);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Linia":
                        Xk = rnd.Next(Margines, Xmax - Margines);
                        Yk = rnd.Next(Margines, Ymax - Margines);

                        TFG[IndexTFG] = new Linia(X, Y, Xk, Yk);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Elipsa":
                        OśDuża = rnd.Next(Margines, Xmax / 4 - Margines);
                        OśMała = rnd.Next(Margines, Ymax / 4 - Margines);
                        TFG[IndexTFG] = new Elipsa(X, Y, OśDuża, OśMała);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Okrąg":
                        Promień = rnd.Next(Margines, Xmax / 4 - Margines);
                        TFG[IndexTFG] = new Okrąg(X, Y,Promień);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Okrąg wypełniony":        
                        Promień = rnd.Next(Margines, Xmax / 4 - Margines);
                        
                        TFG[IndexTFG] = new OkrągWypełniony(X, Y, Promień, KolorWypełneniaFiguryGeometrycznej, StylLinii,GruboścLinii);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;                     
                        break;
                    case "Prostokąt":
                        Szerokośc = rnd.Next(Margines, Xmax / 4 - Margines);
                        Wysokość = rnd.Next(Margines, Ymax / 4 - Margines);
                        TFG[IndexTFG] = new Prostokąt(X, Y, Szerokośc, Wysokość);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Prostokąt wypełniony":
                        Szerokośc = rnd.Next(Margines, Xmax / 4 - Margines);
                        Wysokość = rnd.Next(Margines, Ymax / 4 - Margines);
                        TFG[IndexTFG] = new ProstokątWypełniony(X, Y, Szerokośc, Wysokość);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);

                        TFG[IndexTFG].UstalAtrybutuGraficzne(KolorWypełneniaFiguryGeometrycznej);

                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "Kwadrat":
                        Szerokośc = rnd.Next(Margines, Xmax / 4 - Margines);
                        
                        TFG[IndexTFG] = new Kwadrat(X, Y, Szerokośc);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                    case "KrzywaBaziera":
                        var PunktyKontrolneKrzywejBeziera = new Point(rnd.Next(1,100),rnd.Next(1,100));
                        TFG[IndexTFG] = new KrzywaBeziera(Rysownica, pióro , PunktyKontrolneKrzywejBeziera);
                        TFG[IndexTFG].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                        TFG[IndexTFG].Wykreśl(Rysownica);
                        IndexTFG++;
                        break;
                       
                }
            }
            pbRysownica.Refresh();
            txtN.Enabled = false;
            chlbFiguryGeometryczne.Enabled = false;
            btnStart.Enabled = false;

            btnPrzesyńFG.Enabled = true;
            btnWłąćSjaderFigurGeom.Enabled = true;
            grbPokazFigur.Enabled = true;
            txtNumerFigury.Enabled = true;
        }

        private void PrezentacjaZeSlajderem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Wynik = MessageBox.Show("Czy rzeczewiście chcesz zakończyć działanie programu?",this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
                ,MessageBoxDefaultButton.Button3);
            if (Wynik != DialogResult.Yes)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void PrezentacjaZeSlajderem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrzesyńFG_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);
            Random rnd = new Random();
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            int x, y;

            for (int i = 0; i < IndexTFG - 1; i++)
            {
                x = rnd.Next(Margines, Xmax - Margines);
                y = rnd.Next(Margines, Ymax - Margines);

                TFG[i].PrzesuńDoNowegoXY(pbRysownica, Rysownica, x, y);

            }
            pbRysownica.Refresh();
        }

        private void btnZmianaAtrybutówGraficznych_Click(object sender, EventArgs e)
        {
            Rysownica.Clear(pbRysownica.BackColor);

            Color KolorLinii;
            Color KolorWypełneniaFiguryGeometrycznej;
            DashStyle StylLinii;
            int GruboścLinii;

            Random rnd = new Random();

            for (int i = 0; i < IndexTFG; i++)
            {
                KolorLinii = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                KolorWypełneniaFiguryGeometrycznej = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                switch (rnd.Next(1, 6))
                {
                    case 1: StylLinii = DashStyle.Dash; break;
                    case 2: StylLinii = DashStyle.DashDot; break;
                    case 3: StylLinii = DashStyle.DashDotDot; break;
                    case 4: StylLinii = DashStyle.Dot; break;
                    case 5: StylLinii = DashStyle.Solid; break;
                    default: StylLinii = DashStyle.Solid; break;
                }
                GruboścLinii = rnd.Next(1, 10);
                TFG[i].UstalAtrybutyGraficzne(KolorLinii, StylLinii, GruboścLinii);
                TFG[i].UstalAtrybutuGraficzne(KolorWypełneniaFiguryGeometrycznej);
                TFG[i].Wykreśl(Rysownica);

            }
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

        private void btnWłąćPokazFigurGeom_Click(object sender, EventArgs e)
        {

            Rysownica = Graphics.FromImage(pbRysownica.Image);
            nsKopiaRysownicy = pbRysownica.Image.Clone() as Bitmap;
            Rysownica.Clear(pbRysownica.BackColor);
            if (rdbAuto.Checked)
            {
                timer1.Enabled = true;
                timer1.Tag = nsNumerFigury;
                btnNastepny.Enabled = false;
                btnPoprzedni.Enabled = false;
            }
            if (rdbPrzyciskowy.Checked)
            {
                timer1.Enabled = false;
                txtNumerFigury.Text = "1";
                TFG[0].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width / 2, pbRysownica.Height / 2);
                pbRysownica.Refresh();
                btnPoprzedni.Enabled = true;
                btnNastepny.Enabled = true;
            }
            pbRysownica.Refresh();
            btnWyłąćSlajderFigurGeom.Enabled = true;
            btnWłąćSjaderFigurGeom.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // wymazanie Rysownicy
            Rysownica.Clear(pbRysownica.BackColor);
            // wyznaczenie rozmiarów Rysownicy
            int Xmax = pbRysownica.Width;
            int Ymax = pbRysownica.Height;
            /* wykreslenie pośrodku Rysownicy figury geometrycznej, której indeks
            w tablicy TFG został wpisany do pola Tag zegara: timer1*/
            TFG[(int)timer1.Tag].PrzesuńDoNowegoXY(pbRysownica, Rysownica,
            Xmax / 2, Ymax / 2);
            /* wyznaczenie indeksu w polu timer1.Tag dla figury, która będzie
            wykreślona przy następnym zdarzeniu: Tick */
            timer1.Tag = ((int)timer1.Tag + 1) % (IndexTFG - 1);
            // odświeżenie powierzchni graficznej
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

            TFG[nsNumerFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width /2 , pbRysownica.Height / 2);

            pbRysownica.Refresh();

        }

        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            
            if (nsNumerFigury == 0)
            {
                nsNumerFigury = LFG.Count - 1;
            }
            else nsNumerFigury--;

            int puWyświetlanaFigura = nsNumerFigury + 1;
            txtNumerFigury.Text = puWyświetlanaFigura.ToString();

            TFG[nsNumerFigury].PrzesuńDoNowegoXY(pbRysownica, Rysownica, pbRysownica.Width >> 1, pbRysownica.Height >> 1);

            pbRysownica.Refresh();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog puOknoZapisuPliku = new SaveFileDialog();
            puOknoZapisuPliku.Filter = "bmp|*.bmp";
            if (puOknoZapisuPliku.ShowDialog() == DialogResult.OK)
                if (puOknoZapisuPliku.FileName != "")
                    pbRysownica.Image.Save(puOknoZapisuPliku.FileName);
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog puOknoOpenFile = new OpenFileDialog();

            if (puOknoOpenFile.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.Image = Image.FromFile(puOknoOpenFile.FileName);
                pbRysownica.Refresh();
                nsKopiaRysownicy = pbRysownica.Image.Clone() as Bitmap;
            }
        }

       
    }
}
