using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Projekt2_NikitaSkakun58524.FiguryGeometryczne;
using System.Drawing.Drawing2D;

namespace OOP_Projekt2_NikitaSkakun58524
{
    public partial class Prezenter : Form
    {
        public Prezenter()
        {
            InitializeComponent();
        }

        private void btnPrezentacjaFigurZeSlajderem_Click(object sender, EventArgs e)
        {
            PrezentacjaZeSlajderem formPrezentacjaZeSlajderem = new PrezentacjaZeSlajderem();
            formPrezentacjaZeSlajderem.Show();
            Hide();
        }

        private void btnKreślenieFigurILinii_Click(object sender, EventArgs e)
        {
            KreślenieFigurLinii formKreślenieFigurLinii = new KreślenieFigurLinii();
            formKreślenieFigurLinii.Show();
            Hide();
        }
    }
}