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

        public int getvalue() { return value; }
        public int getweight() { return weight; }
        public float getstosunek() { return stosunek; }

        public int getiterator() { return iterator; }
    }
}
