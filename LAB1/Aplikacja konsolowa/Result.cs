using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa
{
    internal class Result
    {
        List<Item> dodane;
        int sum_weight;
        int sum_value;
        string dane;



        public Result(List<Item> dodane, int sum_weight, int sum_value, string dane)
        {

            this.dodane = new List<Item>(dodane);
            this.sum_weight = sum_weight;
            this.sum_value = sum_value;
            this.dane = dane;
        }

        public  List<Item> getdodane() { return dodane;}
        public  int getsum_weight() { return sum_weight; }
        public  int getsum_value() { return sum_value; }

        public override string ToString()
        {   

            if (this.dodane.Count == 0)
            {
                return "Brak elementów w plecaku";
            }

            string wyjscie = dane; 
            wyjscie+= "\nTo elementy dodane do plecaka:\nWagi: ";

            foreach (var item in dodane)
            {
               
                    wyjscie += item.getweight() + " ";
                
            }

            wyjscie += "\nWartosci: ";
            foreach (var item in dodane)
            {
                
                    wyjscie += item.getvalue() + " ";
                
            }

            wyjscie += "\nNumery: ";
            foreach (var item in dodane)
            {

                wyjscie += item.getiterator() + " ";

            }

            wyjscie += "\nTotalna suma wag elementow: ";
            wyjscie += this.sum_weight;
            wyjscie += "\nTotalna suma wartosci elementow: ";
            wyjscie += this.sum_value;

            return wyjscie;
        }

    }
}
