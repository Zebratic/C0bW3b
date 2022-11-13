using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C0bW3b.Utils
{
    internal class Rendering
    {
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public static void DrawActivityCircle(object sender, PaintEventArgs e, int pensize, Color statusColor)
        {
            GraphicsPath p = new GraphicsPath();
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle area = ((PictureBox)sender).ClientRectangle;
            area.Location = new Point(area.X - 1, area.Y - 1);
            p.AddEllipse(area);
            e.Graphics.DrawPath(new Pen(statusColor, pensize), p);
        }

        public static List<T> CustomSortAlgorithm<T>(List<T> list, bool orderbydescending = true, string propname = null)
        {
            List<T> templist = list;

            if (propname != null)
            {
                PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(T)).Find(propname, true);
                if (prop != null)
                {
                    if (orderbydescending)
                        return templist.OrderBy(x => prop.GetValue(x)).ToList();
                    else
                        return templist.OrderByDescending(x => prop.GetValue(x)).ToList();
                }
            }
            else
            {
                if (orderbydescending)
                    return templist.OrderBy(x => x.ToString().Length).ToList();
                else
                    return templist.OrderByDescending(x => x.ToString().Length).ToList();
            }

            return list;
        }
    }
}
