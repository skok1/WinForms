using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace OOP_Projekt2_NikitaSkakun58524
{
    class FiguryGeometryczne
    {
        public class Punkt
        {//deklaracje 
            const int DomyślnyRozmiarPunktu = 20;
            protected int X;
            protected int Y;
            protected Color Kolor;
            //derlaracje atrybutów
            protected DashStyle StylLinii;
            protected int GrubośćLinii;
            protected bool Widoczny;
            protected Color KolorTła;
            public Punkt(int x, int y)
            {
                X = x; Y = y;
                Kolor = Color.Black;
                KolorTła = Color.White;
                StylLinii = DashStyle.Solid;
                GrubośćLinii = DomyślnyRozmiarPunktu;
                Widoczny = false;
            }
            //drugi konstruktor
            public Punkt(int x, int y, Color Kolor) : this(x, y)
            {
                this.Kolor = Kolor;

            }
            public Punkt(int x, int y, Color Kolor, int RozmiarPunktu) : this(x, y, Kolor)
            {
                GrubośćLinii = RozmiarPunktu;
            }
            public Punkt(int X, int Y, Color Kolor, DashStyle StylLinii, int RozmiarPunktu) : this(X, Y, Kolor)
            {
                this.StylLinii = StylLinii;
                GrubośćLinii = RozmiarPunktu;
            }
            //deklaracja zmiennych prywatnych
            public virtual void UaktualnijXY(int X, int Y)
            {
                this.X = X;
                this.Y = Y;

            }
            //preciążenie metody
            private void UaktualnijXY(Point NowaLokalizacja)
            {
                X = NowaLokalizacja.X;
                Y = NowaLokalizacja.Y;

            }
            //deklaracje metod publicznych
            public void UstalAtrybutyGraficzne(Color KolorLinii, DashStyle StylLinii, int GrubośćLinii)
            {
                Kolor = KolorLinii;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            public void UstalAtrybutuGraficzne(Color KolorTła)
            {
                this.KolorTła = KolorTła;
            }
            protected void UstalStylLinii(DashStyle StylLinii)
            {
                this.StylLinii = StylLinii;
            }
            public virtual void Wykreśl(Graphics Rysownica)
            {
                //deklaracja pędzla
                SolidBrush Pędzel = new SolidBrush(this.Kolor);
                Rysownica.FillEllipse(Pędzel, X - GrubośćLinii / 2, Y - GrubośćLinii / 2, GrubośćLinii, GrubośćLinii);
                //zwolnenie pędzla 
                Widoczny = true;
                Pędzel.Dispose();
            }
            public virtual void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (this.Widoczny)
                {
                    //deklaracja pędzla
                    SolidBrush Pędzel = new SolidBrush(Kontrolka.BackColor);
                    //punkty
                    Rysownica.FillEllipse(Pędzel, X - GrubośćLinii / 2, Y - GrubośćLinii / 2, GrubośćLinii, GrubośćLinii);
                    //zwolnenie pędzla 
                    this.Widoczny = false;
                    Pędzel.Dispose();
                }

            }
            public virtual void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, Point NowaLokalizacja)
            {
                UaktualnijXY(NowaLokalizacja);
                Wykreśl(Rysownica);
            }
            public virtual void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                UaktualnijXY(x, y);
                Wykreśl(Rysownica);
            }
        }
        public class Linia : Punkt
        {
            int Xk, Yk;
            //deklaracja konstruktora 
            public Linia(int Xp, int Yp, int Xk, int Yk) : base(Xp, Yp)
            {
                //przechowania współrzędnych końca linii
                this.Xk = Xk;
                this.Yk = Yk;
                int aa = X;

            }
            public Linia(int Xp, int Yp, int Xk, int Yk, Color Kolor, int GrubośćLinii, DashStyle StylLinii) : base(Xp, Yp, Kolor)
            {
                //przychowanie pozostałych atrybutów 
                base.GrubośćLinii = GrubośćLinii;
                base.StylLinii = StylLinii;
            }
            //deklaracje metod klasy Linia
            public override void Wykreśl(Graphics Rysownica)
            {
                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = StylLinii;
                Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                Widoczny = true;
                Pióro.Dispose();
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii);
                    Pióro.DashStyle = StylLinii;
                    Rysownica.DrawLine(Pióro, X, Y, Xk, Yk);
                    Widoczny = false;
                    Pióro.Dispose();
                }
            }
            public override void PrzesuńDoNowegoXY(Control Kontrolka, Graphics Rysownica, int x, int y)
            {
                int dx, dy;

                if (x > X)
                    dx = x - X;
                else
                    dx = X - x;

                if (y > Y)
                    dy = y - Y;
                else
                    dy = Y - y;

                X = x; Y = y;
                Xk = (Xk + dx) % Kontrolka.Width;
                Yk = (Yk + dy) % Kontrolka.Height;
                Wykreśl(Rysownica);
            }
        }
        //deklaracja klasy Elipsa
        public class Elipsa : Punkt
        {
            protected int OśDuża, OśMała;
            //deklaracja konstruktorów
            public Elipsa(int x, int y, int OśDuża, int OśMała) : base(x, y)
            {
                this.OśDuża = OśDuża;
                this.OśMała = OśMała;

            }
            public Elipsa(int x, int y, int OśDuża, int OśMała, Color Kolor,
          DashStyle StylLinii, int GrubośćLinii) : base(x, y, Kolor)
            {
                this.OśDuża = OśDuża;
                this.OśMała = OśMała;
                base.GrubośćLinii = GrubośćLinii;
                base.StylLinii = StylLinii;
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = this.StylLinii;
                Rysownica.DrawEllipse(Pióro, X, Y, OśDuża, OśMała);
                Widoczny = true;
                Pióro.Dispose();
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (this.Widoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.GrubośćLinii);
                    Pióro.DashStyle = this.StylLinii;
                    Rysownica.DrawEllipse(Pióro, X, Y, OśDuża, OśDuża);
                    Widoczny = false;
                    Pióro.Dispose();
                }
            }
        }
        //deklaracja klasy Okrąg
        public class Okrąg : Elipsa
        {
            protected int Promień;
            //deklaracja konstruktora
            public Okrąg(int x, int y, int Promień) : base(x, y, 2 * Promień, 2 * Promień)
            {
                this.Promień = Promień;
            }
            public Okrąg(int Xp, int Yp, int Szerokość, Color Kolor,
           DashStyle StylLinii, int GrubośćLinii) : base(Xp, Yp, Szerokość, Szerokość, Kolor, StylLinii, GrubośćLinii)
            {

                this.Promień = Szerokość;
            }

            // nadpisanie metod virtualnych
            public override void Wykreśl(Graphics PowierzchniaGraficzna)
            {
                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = this.StylLinii;
                PowierzchniaGraficzna.DrawEllipse(Pióro, X, Y, 2 * Promień, 2 * Promień);
                Widoczny = true;
                Pióro.Dispose();
            }

            public override void Wymaż(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.Widoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.GrubośćLinii);
                    Pióro.DashStyle = this.StylLinii;
                    PowierzchniaGraficzna.DrawEllipse(Pióro, X, Y, 2 * Promień, 2 * Promień);
                    Widoczny = false;
                    Pióro.Dispose();
                }
            }
        }
        public class LiniaKreślonaMyszą : Punkt
        {
            List<Point> ListaPunktów = new List<Point>();
            
            public LiniaKreślonaMyszą(Point PoczątekLinii) : base(PoczątekLinii.X, PoczątekLinii.Y)
            {
                ListaPunktów.Add(PoczątekLinii);
            }
            public void DodajNowyPunktKreslonejLinii(Point NowyPunkt)
            {
                ListaPunktów.Add(NowyPunkt);
            }
            public LiniaKreślonaMyszą(Point PoczątekLinii, Color Kolor, DashStyle StylLinii, int GrubośćLinii) : base(PoczątekLinii.X, PoczątekLinii.Y,
                                      Kolor, StylLinii, GrubośćLinii)
            {
                ListaPunktów.Add(PoczątekLinii);
            }
            public override void UaktualnijXY(int x, int y)
            {
                if (ListaPunktów.Count < 1)
                    return;

                int PrzyrostX = ListaPunktów[0].X - x;
                int PrzyrostY = ListaPunktów[0].Y - y;

                for (int i = 0; i < ListaPunktów.Count; i++)
                    ListaPunktów[i] = new Point(ListaPunktów[i].X - PrzyrostX, ListaPunktów[i].Y - PrzyrostY);

            }
            public override void Wykreśl(Graphics Rysownica)
            {
                Point[] TablicaPunktów = new Point[ListaPunktów.Count];
                for (int i = 0; i < ListaPunktów.Count; i++)
                    TablicaPunktów[i] = ListaPunktów[i];

                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = StylLinii;
                Rysownica.DrawLines(Pióro, TablicaPunktów);
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                Point[] TablicaPunktów = new Point[ListaPunktów.Count];
                for (int i = 0; i < ListaPunktów.Count; i++)
                    TablicaPunktów[i] = ListaPunktów[i];

                Pen PióroGumka = new Pen(Kontrolka.BackColor, GrubośćLinii);
                PióroGumka.DashStyle = StylLinii;
                Rysownica.DrawLines(PióroGumka, TablicaPunktów);
            }
        }
        public class KrzywaBeziera : Punkt
        {
            public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();
            int PromieńPunktuKontrolnego = 5;
            public ushort LiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            Font FontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            public KrzywaBeziera(Graphics Rysownica, Pen Pióro, Point XYpunkty) :
                base(XYpunkty.X, XYpunkty.Y, Pióro.Color, (int)Pióro.Width)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunkty);
                using (SolidBrush Pędzel = new SolidBrush(Pióro.Color))
                {
                    Rysownica.FillEllipse(Pędzel, XYpunkty.X - PromieńPunktuKontrolnego, XYpunkty.Y - PromieńPunktuKontrolnego,
                        2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);

                }
            }
            public void DodajNowyPunktKontrolnych(Point XYpunkty, Graphics Rysownica)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunkty);
                using (SolidBrush Pędzel = new SolidBrush(Color.Red))
                {

                    if ((PunktyKontrolneKrzywejBeziera.Count == 1) || (PunktyKontrolneKrzywejBeziera.Count == 4))
                    {
                        Pędzel.Color = Kolor;
                    }

                    Rysownica.FillEllipse(Pędzel, XYpunkty.X - PromieńPunktuKontrolnego, XYpunkty.Y - PromieńPunktuKontrolnego,
                        2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);


                }
                if (PunktyKontrolneKrzywejBeziera.Count == 4)
                    Wykreśl(Rysownica);
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    Pióro.DashStyle = StylLinii;
                    Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];
                    for (ushort i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                        PunktyKontrolne[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);

                    Rysownica.DrawBezier(Pióro, PunktyKontrolne[0], PunktyKontrolne[1], PunktyKontrolne[2], PunktyKontrolne[3]);
                    Widoczny = true;

                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Point[] PunktyKrzywejBaziera = new Point[PunktyKontrolneKrzywejBeziera.Count];
                        for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                            PunktyKontrolneKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);

                        Rysownica.DrawBezier(Pióro, PunktyKrzywejBaziera[0], PunktyKrzywejBaziera[1], PunktyKrzywejBaziera[2], PunktyKrzywejBaziera[3]);

                        Widoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int X, int Y)
            {
                int PrzyrostX = PunktyKontrolneKrzywejBeziera[0].X - X;
                int PrzyrostY = PunktyKontrolneKrzywejBeziera[0].Y - Y;

                for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                {
                    PunktyKontrolneKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X - PrzyrostX, PunktyKontrolneKrzywejBeziera[i].Y - PrzyrostY);
                }
            }
           
        }
        public class KrzywaKardynalna : Punkt
        {
            public List<Point> PunktyKontrolneKrzywejBeziera = new List<Point>();
            int PromieńPunktuKontrolnego = 5;
            public ushort LiczbaPunktówKontrolnych
            {
                get;
                set;
            }
            Font FontOpisuPunktów = new Font("Arial", 8, FontStyle.Italic);
            public KrzywaKardynalna(Graphics Rysownica, Pen Pióro, Point XYpunkty) :
                base(XYpunkty.X, XYpunkty.Y, Pióro.Color, (int)Pióro.Width)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunkty);
                using (SolidBrush Pędzel = new SolidBrush(Pióro.Color))
                {
                    Rysownica.FillEllipse(Pędzel, XYpunkty.X - PromieńPunktuKontrolnego, XYpunkty.Y - PromieńPunktuKontrolnego,
                        2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);

                }
            }
            public void DodajNowyPunktKontrolnych(Point XYpunkty, Graphics Rysownica)
            {
                PunktyKontrolneKrzywejBeziera.Add(XYpunkty);
                using (SolidBrush Pędzel = new SolidBrush(Color.Red))
                {

                    if ((PunktyKontrolneKrzywejBeziera.Count == 1) || (PunktyKontrolneKrzywejBeziera.Count == 5))
                    {
                        Pędzel.Color = Kolor;
                    }

                    Rysownica.FillEllipse(Pędzel, XYpunkty.X - PromieńPunktuKontrolnego, XYpunkty.Y - PromieńPunktuKontrolnego,
                        2 * PromieńPunktuKontrolnego, 2 * PromieńPunktuKontrolnego);
                    Rysownica.DrawString("p" + (PunktyKontrolneKrzywejBeziera.Count - 1).ToString(), FontOpisuPunktów, Pędzel,
                        PunktyKontrolneKrzywejBeziera[PunktyKontrolneKrzywejBeziera.Count - 1]);


                }
                if (PunktyKontrolneKrzywejBeziera.Count == 5)
                    Wykreśl(Rysownica);
            }
            public override void Wykreśl(Graphics Rysownica)
            {
                using (Pen Pióro = new Pen(Kolor, GrubośćLinii))
                {
                    Pióro.DashStyle = StylLinii;
                    Point[] PunktyKontrolne = new Point[PunktyKontrolneKrzywejBeziera.Count];
                    for (ushort i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                        PunktyKontrolne[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);

                    Rysownica.DrawCurve(Pióro, PunktyKontrolne);
                    Widoczny = true;

                }
            }
            public override void Wymaż(Control Kontrolka, Graphics Rysownica)
            {
                if (Widoczny)
                {
                    using (Pen Pióro = new Pen(Kontrolka.BackColor, GrubośćLinii))
                    {
                        Pióro.DashStyle = StylLinii;
                        Point[] PunktyKrzywejBaziera = new Point[PunktyKontrolneKrzywejBeziera.Count];
                        for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                            PunktyKontrolneKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X, PunktyKontrolneKrzywejBeziera[i].Y);

                        Rysownica.DrawCurve(Pióro, PunktyKrzywejBaziera);

                        Widoczny = false;
                    }
                }
            }
            public override void UaktualnijXY(int X, int Y)
            {
                int PrzyrostX = PunktyKontrolneKrzywejBeziera[0].X - X;
                int PrzyrostY = PunktyKontrolneKrzywejBeziera[0].Y - Y;

                for (int i = 0; i < PunktyKontrolneKrzywejBeziera.Count; i++)
                {
                    PunktyKontrolneKrzywejBeziera[i] = new Point(PunktyKontrolneKrzywejBeziera[i].X - PrzyrostX, PunktyKontrolneKrzywejBeziera[i].Y - PrzyrostY);
                }
            }

        }
        public class Prostokąt : Punkt
        {
            int Szerokość, Wysokość;
            //deklaracja konstruktora
            public Prostokąt(int Xp, int Yp, int Szerokość, int Wysokość) : base(Xp, Yp)
            {

                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
            }
            public Prostokąt(int Xp, int Yp, int Szerokość, int Wysokość, Color Kolor,
             DashStyle StylLinii, int GrubośćLinii) : base(Xp, Yp, Kolor, StylLinii, GrubośćLinii)
            {

                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
            }
            // nadpisanie metod virtualnych
            public override void Wykreśl(Graphics PowierzchniaGraficzna)
            {
                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = this.StylLinii;
                PowierzchniaGraficzna.DrawRectangle(Pióro, X, Y, Szerokość, Wysokość);
                Widoczny = true;
                Pióro.Dispose();
            }

            public override void Wymaż(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.Widoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.GrubośćLinii);
                    Pióro.DashStyle = this.StylLinii;
                    PowierzchniaGraficzna.DrawEllipse(Pióro, X, Y, Szerokość, Wysokość);
                    Widoczny = false;
                    Pióro.Dispose();
                }
            }
        }
        public class ProstokątWypełniony : Punkt
        {
            int Szerokość, Wysokość;
         
            //deklaracja konstruktora
            public ProstokątWypełniony(int Xp, int Yp, int Szerokość, int Wysokość) : base(Xp, Yp)
            {

                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
            }
            public ProstokątWypełniony(int Xp, int Yp, int Szerokość, int Wysokość, Color Kolor,
             DashStyle StylLinii, int GrubośćLinii) : base(Xp, Yp, Kolor, StylLinii, GrubośćLinii)
            {

                this.Szerokość = Szerokość;
                this.Wysokość = Wysokość;
                this.KolorTła = Kolor;
            }
            // nadpisanie metod virtualnych
            public override void Wykreśl(Graphics PowierzchniaGraficzna)
            {
                SolidBrush solidBrush = new SolidBrush(KolorTła);              
                PowierzchniaGraficzna.FillRectangle(solidBrush, X, Y, Szerokość, Wysokość);
                Widoczny = true;
                solidBrush.Dispose();
            }

            public override void Wymaż(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.Widoczny)
                {
                    SolidBrush solidBrush = new SolidBrush(Kontrolka.BackColor);
                    PowierzchniaGraficzna.FillRectangle(solidBrush, X, Y, Szerokość, Wysokość);
                    Widoczny = false;
                    solidBrush.Dispose();
                }
            }
        }

        public class OkrągWypełniony : Okrąg
        {
            protected new int Promień;
          
            //deklaracja konstruktora
            public OkrągWypełniony(int x, int y, int Promień) : base(x, y, Promień)
            {
                this.Promień = Promień;
            }
            public OkrągWypełniony(int Xp, int Yp, int Szerokość, Color Kolor,
            DashStyle StylLinii, int GrubośćLinii) : base(Xp, Yp, Szerokość, Kolor, StylLinii, GrubośćLinii)
            {

                this.Promień = Szerokość;
                this.KolorTła = Kolor;
            }

            // nadpisanie metod virtualnych
            public override void Wykreśl(Graphics PowierzchniaGraficzna)
            {
                SolidBrush solidBrush = new SolidBrush(KolorTła);
                PowierzchniaGraficzna.FillEllipse(solidBrush, X, Y, Promień, Promień);
                Widoczny = true;
                solidBrush.Dispose();
            }
            public override void Wymaż(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.Widoczny)
                {
                    SolidBrush solidBrush = new SolidBrush(Kontrolka.BackColor);
                    PowierzchniaGraficzna.FillEllipse(solidBrush, this.X, this.Y, Promień, Promień);
                    Widoczny = false;
                    solidBrush.Dispose();
                }
            }
        }
        public class Kwadrat : Prostokąt
        {
            int Szerokość;

            public Kwadrat(int Xp, int Yp, int Szerokość) : base(Xp, Yp, Szerokość, Szerokość)
            {
               
                this.Szerokość = Szerokość;
            }

            public Kwadrat(int Xp, int Yp, int Szerokość, Color Kolor,
                DashStyle StylLinii, int GrubośćLinii) : base(Xp, Yp, Szerokość, Szerokość, Kolor, StylLinii, GrubośćLinii)
            {
         
                this.Szerokość = Szerokość;
            }

            // nadpisanie metod virtualnych
            public override void Wykreśl(Graphics PowierzchniaGraficzna)
            {
                Pen Pióro = new Pen(Kolor, GrubośćLinii);
                Pióro.DashStyle = this.StylLinii;
                PowierzchniaGraficzna.DrawRectangle(Pióro, X, Y, Szerokość, Szerokość);
                Widoczny = true;
                Pióro.Dispose();
            }

            public override void Wymaż(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (this.Widoczny)
                {
                    Pen Pióro = new Pen(Kontrolka.BackColor, this.GrubośćLinii);
                    Pióro.DashStyle = this.StylLinii;
                    PowierzchniaGraficzna.DrawRectangle(Pióro, X, Y, Szerokość, Szerokość);
                    Widoczny = false;
                    Pióro.Dispose();
                }
                
            }
        }
    }
}
