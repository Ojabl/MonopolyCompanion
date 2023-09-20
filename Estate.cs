using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    public class Estate : ICard
    {
        public string Name { get; set; }
        public EnCardType CardType { get; set; }
        public EnCardColor CardColor { get; set; }
        public int Price { get; set; }
        public int Rent0h { get; set; }
        public int Rent1h { get; set; }
        public int Rent2h { get; set; }
        public int Rent3h { get; set; }
        public int Rent4h { get; set; }
        public int RentH { get; set; }
        public int Mortgage { get; set; }
        public int HouseCost { get; set; }
        public int HotelCost { get; set; }
        public int Houses { get; set; }
        public int Hotels { get; set; }
        public bool Mortgaged { get; set; }

        public Estate(string name, EnCardColor cardColor, int price, int Rent0h, int Rent1h, int Rent2h, int Rent3h, int Rent4h, int RentH, int mortgage, int houseCost, int hotelCost)
        {
            this.Name = name;
            this.CardColor = cardColor;
            this.Price = price;
            this.Rent0h = Rent0h;
            this.Rent1h = Rent1h;
            this.Rent2h = Rent2h;
            this.Rent3h = Rent3h;
            this.Rent4h = Rent4h;
            this.RentH = RentH;
            this.Mortgage = mortgage;
            this.HouseCost = houseCost;
            this.HotelCost = hotelCost;
            this.CardType = EnCardType.Estate;
            this.Houses = 0;
            this.Hotels = 0;
            this.Mortgaged = false;
        }
    }
}
