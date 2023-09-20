using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public EnPlayerToken PlayerToken { get; set; }
        public List<ICard> Hand { get; set; }
        public List<Estate> MortgagedEstates { get; set; }
        public bool hasGetOutOfJailCard { get; set; }
        

        public Player(string name, int money)
        {
            Name = name;
            Money = money;
            Hand = new List<ICard>();
            MortgagedEstates = new List<Estate>();
            hasGetOutOfJailCard = false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
