using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafyy
{
    public class PrzeszukiwanieGrafu
    {
        public List<int> PrzeszukiwanieWszerz(Wierzcholek startowyWierzcholek)
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

        public List<int> PrzeszukiwanieWGlab(Wierzcholek startowyWierzcholek)
        {
            List<int> wyniki = new List<int>();
            Stack<Wierzcholek> stos = new Stack<Wierzcholek>();
            HashSet<Wierzcholek> odwiedzone = new HashSet<Wierzcholek>();

            stos.Push(startowyWierzcholek);
            odwiedzone.Add(startowyWierzcholek);

            while (stos.Count > 0)
            {
                Wierzcholek aktualny = stos.Pop();
                wyniki.Add(aktualny.Id);

                foreach (Wierzcholek sasiad in aktualny.Nastepniki)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        stos.Push(sasiad);
                        odwiedzone.Add(sasiad);
                    }
                }
            }

            return wyniki;
        }
    }
}
