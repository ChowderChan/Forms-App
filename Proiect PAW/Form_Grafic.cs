using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form_Grafic : Form
    {
        int nr_obs;
        //double[] y;
        int[] prices; // y
        int[] iduri; // x

        public Form_Grafic(int nr_observatii, int[] preturi, int[] id_uri)
        {
            InitializeComponent();

            textBox1.Text = nr_observatii.ToString();
            nr_obs = nr_observatii;
            prices = preturi;
            iduri = id_uri;

            //y = new double[] { 45, 56, 75, 36, 65 };
            //prices = new double[] { 1542, 1235, 9654, 5464, 7553 };
        }

        public static int nr_observatii { get; private set; }

        private void Form_Grafic_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaPret = e.ClipRectangle;

            Brush fundal = new SolidBrush(Color.LightGray);

            g.FillRectangle(fundal, zonaPret);

            zonaPret.X += 2;
            zonaPret.Y += 2;
            zonaPret.Height -= 20;
            zonaPret.Width -= 5;

            int vl = zonaPret.Left;
            int vr = zonaPret.Right;
            int vt = zonaPret.Top;
            int vb = zonaPret.Bottom;

            Pen creionRosu = new Pen(Color.Red, 2);
            g.DrawRectangle(creionRosu, zonaPret);

            int lat, dist;
            string denx = "";
            float rap_dis_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[] { new SolidBrush(Color.DeepPink), new SolidBrush(Color.Aquamarine), new SolidBrush(Color.Purple), new SolidBrush(Color.Blue), new SolidBrush(Color.Green), new SolidBrush(Color.Orange) };

            Pen[] creioane = new Pen[] { new Pen(Color.Moccasin), new Pen(Color.Yellow), new Pen(Color.Blue), new Pen(Color.HotPink), new Pen(Color.DarkGreen), new Pen(Color.LightPink) };

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            if (nr_obs != 0)
            {
                lat = (int)((vr - vl) / (int)((nr_obs + 1) * rap_dis_lat + nr_obs) * 0.95);
                dist = (int)(lat * rap_dis_lat);

                int i;
                // EROARE daca deschidem graficul iar dupa ce am modificat numarul de items din listview => NU MAI ESTE !!!
                for (max = prices[0], i = 1; i < nr_obs; i++)
                {
                    if (max < prices[i])
                    {
                        max = prices[i];
                    }
                }

                creionCurent = creioane[0];
                g.DrawLine(creionCurent, vl, vt, vl, vb);
                g.DrawLine(creionCurent, vl, vb, vr, vb);

                // DE AICI EROARE cand deschid graficul !!! => NU MAI E EROARE!!!
                for (i = 0; i < nr_obs; i++)
                {
                    pensulaCurenta = pensule[i % pensule.Length];

                    PointF pnt = new PointF(vl + i * (lat + dist) + rap_dis_lat + dist, vb - 0.95f * prices[i] * (vb - vt) / max);

                    SizeF sz = new SizeF(lat, 0.95f * prices[i] * (vb - vt) / max);

                    g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

                    denx = "" + iduri[i];
                    g.DrawString(denx, Font, pensulaCurenta, vl + dist + lat / 2 + i * (lat + dist), vb + 5);
                    g.DrawString(prices[i].ToString(), Font, pensulaCurenta, vl + dist + lat / 2 + i * (lat + dist), vb - 0.95f * prices[i] * (vb - vt) / max - 15);
                }
            }
        }
    }
}
