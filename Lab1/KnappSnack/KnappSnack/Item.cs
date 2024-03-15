using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnappSnack
{
    internal class Item
    {

        public int value { get; set; }
        public int weight { get; set; }

        public float ratio { get; set; }

        public int id { get; set; }
        public Item(int value, int weight, int id)
        {
            this.value = value;
            this.weight = weight;
            this.id = id; 
            this.ratio = this.value / this.weight;
        }

        public override string ToString()
        {
            return "Number: " + this.id + " value = " + this.value + " " + "weight = " + this.weight + " id = " + this.id + "\n";
        }

    }
}
