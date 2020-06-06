using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    enum EnvironFr//экологичность(шкала оценивания от одного до пяти)
    {
        One = 1,
        Two,
        Three,
        Four,
        Five
        
    }
    abstract class Characteristics : Furniture
    {
        public string Shop { get; set; }
        public EnvironFr EnvironFr { get; set; }
        public Characteristics() : base()
        {
            Shop = "DomMebeli";
            EnvironFr = EnvironFr.Four;
        }
        public Characteristics(string name, int cost, string country, string shop, EnvironFr enfr) : base(name, cost, country)
        {
            Shop = shop;
            EnvironFr = enfr;
        }
    }
}