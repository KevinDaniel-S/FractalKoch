using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalKoch
{
    public partial class FractalKoch : Form
    {
        Graphics g = null;
        Fractal f = new Fractal();

        public int Nivel { get; set; } = 0;
        public int Lados { get; set; } = 0;

        public FractalKoch()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g.TranslateTransform(0,this.Height);
            g.ScaleTransform(1,-1);
        }

        private void botonAumentar_Click(object sender, EventArgs e)
        {
            Nivel++;
            f.DibujarKoch(4, 1, 200, g);
        }

        private void botonDisminuir_Click(object sender, EventArgs e)
        {
            Nivel--;
        }
    }
}
