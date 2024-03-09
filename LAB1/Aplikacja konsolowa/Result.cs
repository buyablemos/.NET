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

        public List<Item> Dodane { get=> dodane;}
        public  int Sum_weight { get => sum_weight; }
        public  int Sum_value { get => sum_value; }

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
               
                    wyjscie += item.Weight + " ";
                
            }

            wyjscie += "\nWartosci: ";
            foreach (var item in dodane)
            {
                
                    wyjscie += item.Value + " ";
                
            }

            wyjscie += "\nNumery: ";
            foreach (var item in dodane)
            {

                wyjscie += item.Iterator + " ";

            }

            wyjscie += "\nTotalna suma wag elementow: ";
            wyjscie += this.sum_weight;
            wyjscie += "\nTotalna suma wartosci elementow: ";
            wyjscie += this.sum_value;

            return wyjscie;
        }

    }
}
