using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    class Utility : ICard
    {
        public string Name { get; set; }
        public EnCardType CardType { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }
        public int Mortgage { get; set; }

        public Utility(string name, string description, int price, int mortgage) 
        {
            Name = name;
            Description = description;
            CardType = EnCardType.Utility;
            Price = price;
            Mortgage = mortgage;
        }

    }
}
