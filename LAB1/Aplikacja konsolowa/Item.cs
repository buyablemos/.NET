using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa
{
    internal class Item
    {
        int weight;
        int value;
        float stosunek;
        int iterator;

        public Item(int weight, int value, int iterator)
        {
            this.weight = weight;
            this.value = value;
            this.stosunek = (float) value/weight;
            this.iterator = iterator;
        }
        //setery zakomentowane - hermetyzacja danych w strukturze
        public int Value { get=>value; /*set=>this.value=value;*/ }
        public int Weight {get=>weight;/* set=>this.weight=value;*/ }
        public float Stosunek {get => stosunek; /*set => this.stosunek = value;*/}

        public int Iterator { get => iterator; /*set => iterator = value;*/ }
    }
}
