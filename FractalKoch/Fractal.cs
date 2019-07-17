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
            float x = 10;
            float y = 50;
            float x1;
            float y1;

            for (int i = 0; i < lados; i++)
            {
                x1 = x + largo * (float)(Math.Sin(Math.PI/2 * i));
                y1 = y + largo * (float)(Math.Cos(Math.PI/2 * i));
                g.DrawLine(lapiz, x, y, x1, y1);
                x = x1;
                y = y1;
            }
            
        }
    }
}
