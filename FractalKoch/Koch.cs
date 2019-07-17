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
        public int Lados { get; set; } = 3;
        
        public FractalKoch()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g.TranslateTransform(0, this.Height);
            g.ScaleTransform(1, -1);
        }

        private void botonAumentar_Click(object sender, EventArgs e)
        {
            Nivel++;
            g.Clear(Color.WhiteSmoke);
            f.DibujarKoch(Lados, Nivel, 200, g);
        }

        private void botonDisminuir_Click(object sender, EventArgs e)
        {
            Nivel--;
        }

        private void numeroLados_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.WhiteSmoke);
            Lados = (int)numeroLados.Value;
            f.DibujarKoch(Lados, Nivel, 200, g);
        }
    }
}
