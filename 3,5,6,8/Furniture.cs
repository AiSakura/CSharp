using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    class Furniture
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Furniture[] data;
        // Конструкторы
        public Furniture()
        {
            Name = "Sofa,<Pro>";
            Cost = 1197;
            Country = "Belarus";
        }
        public Furniture(int number)
        {
            data = new Furniture[number];
        }
        public Furniture(string name, int cost, string country)
        {
            Cost = cost;
            Name = name;
            Country = country;
        }
        // Индексатор
        public Furniture this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        // Методы
        public virtual void Print(int i)
        {
            Console.WriteLine($"{i}. Name: {Name}, Cost: {Cost}, CountryOfProduction: {Country}\n");
        }
    }
}