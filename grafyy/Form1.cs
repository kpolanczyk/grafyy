using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafyy
{
    public partial class Form1 : Form
    {
        private const int r = 10;
        private Graphics g;
        private Pen pWierzcholek;
        private Pen pWierzcholekAktywny;
        private Pen pKrawedz;
        private Wierzcholek MouseDownWierzcholek;
        private List<Wierzcholek> wierzcholki = new List<Wierzcholek>();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(450, 500);

            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            pWierzcholek = new Pen(Color.DarkGreen);
            pWierzcholek.Width = 3;
            pWierzcholekAktywny = new Pen(Color.Red);
            pWierzcholekAktywny.Width = 3;

            pKrawedz = new Pen(Color.LawnGreen);
            pKrawedz.Width = 5;
            pKrawedz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownWierzcholek = null;
                foreach (Wierzcholek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek = w;
                    }
                }
                odrysujGraf();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek != null)
            {
                foreach (Wierzcholek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek.Nastepniki.Add(w);
                    }
                }
                MouseDownWierzcholek = null;
                odrysujGraf();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                wierzcholki.Add(new Wierzcholek(e.Location));
                odrysujGraf();
            }
        }

        private void odrysujGraf()
        {
            g.Clear(Color.White);
            foreach (Wierzcholek w in wierzcholki)
            {

                g.DrawEllipse(pWierzcholek, w.Polozenie.X - r, w.Polozenie.Y - r, 2 * r, 2 * r);
                g.DrawString(w.Id.ToString(),
                             new System.Drawing.Font("Microsoft Sans Serif", r),
                             new SolidBrush(Color.Red),
                             w.Polozenie.X + r,
                             w.Polozenie.Y + r);
                if (w == MouseDownWierzcholek)
                {
                    g.DrawEllipse(pWierzcholekAktywny, w.Polozenie.X - r, w.Polozenie.Y - r, 2 * r, 2 * r);
                }
                foreach (Wierzcholek wn in w.Nastepniki)
                {
                    g.DrawLine(pKrawedz, w.Polozenie, wn.Polozenie);
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek != null)
            {
                odrysujGraf();
                g.DrawLine(pKrawedz, MouseDownWierzcholek.Polozenie, e.Location);
                pictureBox1.Refresh();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pierwszy_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void szukanie_Click(object sender, EventArgs e)
        {
            Wynik.Items.Clear();

            int numerWierzcholka;
            if (int.TryParse(pierwszy.Text, out numerWierzcholka))
            {
                Wierzcholek startowyWierzcholek = wierzcholki.FirstOrDefault(w => w.Id == numerWierzcholka);

                if (startowyWierzcholek != null)
                {
                    List<int> wyniki;

                    if (wszerz.Checked)
                    {
                        wyniki = PrzeszukiwanieWszerz(startowyWierzcholek);
                    }
                    else
                    {
                        MessageBox.Show("Zaznacz algorytm przeszukiwania.", "Błąd");
                        return;
                    }

                    foreach (int wynik in wyniki)
                    {
                        Wynik.Items.Add(wynik);
                    }
                }
                else
                {
                    MessageBox.Show("Podany numer wierzchołka nie istnieje.", "Błąd");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawny numer wierzchołka.", "Błąd");
            }
        }
        private List<int> PrzeszukiwanieWszerz(Wierzcholek startowyWierzcholek)
        {
            List<int> wyniki = new List<int>();
            Queue<Wierzcholek> kolejka = new Queue<Wierzcholek>();
            HashSet<Wierzcholek> odwiedzone = new HashSet<Wierzcholek>();

            kolejka.Enqueue(startowyWierzcholek);
            odwiedzone.Add(startowyWierzcholek);

            while (kolejka.Count > 0)
            {
                Wierzcholek aktualny = kolejka.Dequeue();
                wyniki.Add(aktualny.Id);

                foreach (Wierzcholek sasiad in aktualny.Nastepniki)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        kolejka.Enqueue(sasiad);
                        odwiedzone.Add(sasiad);
                    }
                }
            }

            return wyniki;
        }

        private void Wynik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
