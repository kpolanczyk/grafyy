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
            Queue<Wierzcholek> Queue = new Queue<Wierzcholek>();
            HashSet<Wierzcholek> Visited = new HashSet<Wierzcholek>();
            Queue.Enqueue(startowyWierzcholek);
            Visited.Add(startowyWierzcholek);
            while (Queue.Count > 0)
            {
                Wierzcholek aktualny = Queue.Dequeue();
                wyniki.Add(aktualny.Id);
                foreach (Wierzcholek Sasiad in aktualny.Nastepniki)
                {
                    if (!Visited.Contains(Sasiad))
                    {
                        Queue.Enqueue(Sasiad);
                        Visited.Add(Sasiad);
                    }
                }
            }
            return wyniki;
        }

        public List<int> PrzeszukiwanieWGlab(Wierzcholek startowyWierzcholek)
        {
            List<int> wyniki = new List<int>();
            Stack<Wierzcholek> Stack = new Stack<Wierzcholek>();
            HashSet<Wierzcholek> Visited = new HashSet<Wierzcholek>();
            Stack.Push(startowyWierzcholek);
            Visited.Add(startowyWierzcholek);
            while (Stack.Count > 0)
            {
                Wierzcholek aktualny = Stack.Pop();
                wyniki.Add(aktualny.Id);

                foreach (Wierzcholek Sasiad in aktualny.Nastepniki)
                {
                    if (!Stack.Contains(Sasiad))
                    {
                        Stack.Push(Sasiad);
                        Visited.Add(Sasiad);
                    }
                }
            }
            return wyniki;
        }
    }
}