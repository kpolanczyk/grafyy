using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafyy
{
    public class Wierzcholek
    {
        public Point Polozenie { get; }
        public Int32 Id { get; }

        private List<Wierzcholek> nastepniki = new List<Wierzcholek>();
        public List<Wierzcholek> Nastepniki
        {
            get
            {
                return nastepniki;
            }
        }
        private static int newId = 0;
        private static int NewId
        {
            get { return ++newId; }
        }
        public Wierzcholek(Point Polozenie)
        {
            this.Polozenie = Polozenie;
            this.Id = NewId;
        }
        internal int Odleglosc(Point p)
        {
            return (int)Math.Sqrt(Math.Pow(Polozenie.X - p.X, 2) + Math.Pow(Polozenie.Y - p.Y, 2));
        }
        public static void ResetujLicznikID()
        {
            newId = 0;
        }
    }
}