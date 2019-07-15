using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalKoch
{
    public class Fractal
    {
        Pen lapiz = new Pen(Color.DarkBlue,10);
        

        public void DibujarKoch(int lados, int nivel,Graphics g)
        {
            g.DrawLine(lapiz,10,10,100,100);
        }
    }
}
