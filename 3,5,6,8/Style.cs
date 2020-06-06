using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public struct DataStud
    {
        public int NatMaterial;
        public int SynthMaterial;
    }

    class Style : Characteristics, ICustomerRating, IComparable<Style>, ICloneable
    {
        public delegate void CharacteristicsSt(string message);
        public event CharacteristicsSt NotifyMark;
        public event CharacteristicsSt NotifyRetake;

        DataStud dataStud;
        public string St { get; set; }
        public int Quality { get; set; }
        public int PositiveFeedback { get; set; }
       
        public Style() : base()
        {
            St = "Classic";
            dataStud.NatMaterial = 90;
            dataStud.SynthMaterial = 7;
            PositiveFeedback = 10;
            Quality = 8;
           
        }
        public Style(string name, int age, string country, string shop, EnvironFr enfr, string style, int coeff, int chance, int qual, int pf) : base(name, age, country, shop, enfr)
        {
            St = style;
            dataStud.NatMaterial = coeff;
            dataStud.SynthMaterial = chance;
            Quality = qual;
            PositiveFeedback = pf;
          
        }
        public int CompareTo(Style obj)
        {
            if (this.Cost > obj.Cost)
            {
                return 1;
            }
            if (this.Cost < obj.Cost)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public object Clone()
        {
            return (Style)this.MemberwiseClone();
        }
        public override void Print(int i)
        {
            Console.WriteLine($"{i}. Name: {Name}\n" +
                $"Cost: {Cost}\n" +
                $"Country of production: {Country}\n" +
                $"Shop: {Shop}\n" +
                $"Style: {St}\n" +
                $"Envirnonment friendly: {(int)EnvironFr}\n" +
                $"Natural materials: {dataStud.NatMaterial}%\n" +
                $"Synthetic materials: {dataStud.SynthMaterial}%");
            NotifyMark?.Invoke($"Customer Rating: {customerRating()}");
            NotifyRetake?.Invoke($"Feedback: {checkFeedback()}");
            Console.ResetColor();
            Console.WriteLine("\n");
        }
        public string customerRating()
        {
            if (Quality < 0 || PositiveFeedback < 0 )
            {
                return "Grades must be positive";
            }
            else
            {
                double customerRating = 0;
                customerRating = (Quality + PositiveFeedback ) / 2.0;
                return customerRating.ToString("0.00");
            }
        }
        public string checkFeedback()
        {
            if (Quality >= 8 && PositiveFeedback >= 8 )
            {
                return "Cool!";
            }
            else if (Quality >= 0 && PositiveFeedback >= 0)
            {
                return "Ugh, so bad";
            }
            else
            {
                return "So-so";
            }
        }
    }
}
