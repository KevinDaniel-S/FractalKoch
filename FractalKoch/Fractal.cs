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
        Pen lapiz = new Pen(Color.GreenYellow, 2);

        public void DibujarKoch(int lados, int nivel, float largo, Graphics g)
        {
            float x = 100;
            float y = 50 + lados * 3;
            float x1;
            float y1;

            for (int i = 0; i < lados; i++)
            {
                x1 = x + largo * (float)(Math.Sin(2*Math.PI/lados * i));
                y1 = y + largo * (float)(Math.Cos(2*Math.PI/lados * i));
                g.DrawLine(lapiz, x, y, x1, y1);
                x = x1;
                y = y1;
            }
            
        }
    }
}
