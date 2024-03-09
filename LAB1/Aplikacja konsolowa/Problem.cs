using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

[assembly: InternalsVisibleTo("TestyJednostkowe")]
[assembly: InternalsVisibleTo("AplikacjaDesktopowa")]

namespace Konsolowa
{
    internal class Problem
    {
        string dane="";

        List<Item> items = new List<Item>();
        List<Item> added = new List<Item>();

        public Problem(int n, int seed)
        {
            Random random = new Random(seed);
            


            for (int i = 0; i < n; i++)
            {
                int rnd_value = random.Next(1,11);
                int rnd_weight = random.Next(1,11);

                Item tmp = new Item(rnd_weight,rnd_value,i);

                
                string wyjscie = "";

                wyjscie += "no: ";
                wyjscie += i;
                wyjscie += " v: ";
                wyjscie += rnd_value;
                wyjscie += " w: ";
                wyjscie += rnd_weight;
                wyjscie += "\n";

                dane += wyjscie;

                items.Add(tmp);
            }


        }


        public Result Solve(int capacity, bool if_sorted)
        {
            List<Item> sorted= new List<Item>(items);

            if (if_sorted == true)
            {
                sorted = items.OrderByDescending(x => x.Stosunek).ToList();
            }



            int i = 0;

            while (i < sorted.Count)
            {

                if (this.policz_wage() + sorted[i].Weight <= capacity)
                {
                    added.Add(sorted[i]);
                }

                i++;
            }


            Result wyjscie = new Result(this.added, this.policz_wage(), this.policz_wartosc(), dane);
            added.Clear();
            return wyjscie;
        }

        public int policz_wage()
        {
            int aktualna = 0;

            if (this.added.Count == 0)
            {
                return 0;
            }

            foreach (var item in added)
            {
                
                    aktualna = aktualna + item.Weight;
                
            }
            return aktualna;
        }
        public int policz_wartosc()
        {
            int aktualna = 0;

            if (this.added.Count == 0)
            {
                return 0;
            }

            foreach (var item in added)
            {

                aktualna = aktualna + item.Value;

            }
            return aktualna;
        }

        public List<Item> Items { set=> items = value; }
    }
}
