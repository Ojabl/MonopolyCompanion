using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    class Railroad : ICard
    {
        public string Name { get; set; }
        public EnCardType CardType { get; set; }
        public int Price { get; set; }
        public int Rent { get; set; }
        public int Rent2R { get; set; }
        public int Rent3R { get; set; }
        public int Rent4R { get; set; }
        public int Mortgage { get; set; }

        public Railroad(string name, int price, int rent, int rent2r, int rent3r, int rent4r, int mortgage) 
        {
            Name = name;
            Price = price;
            Rent = rent;
            Rent2R = rent2r;
            Rent3R = rent3r;
            Rent4R = rent4r;
            Mortgage = mortgage;
            CardType = EnCardType.Station;
        }


    }
}
