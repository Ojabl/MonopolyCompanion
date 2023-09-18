using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    internal class ChanceCard : ICard
    {
        public string Name { get; set; }
        public EnCardType CardType { get; set; }

        public int Id { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public bool GoToGo { get; set; }
        public bool GetOutOfJail { get; set; }
        public bool GoToJail { get; set; }


        public ChanceCard(int id, string description, int value= 0, bool goToGo = false, bool getOutOfJail = false, bool goToJail = false)
        {
            Name = "null";
            Id = id;
            Description = description;
            Value = value;
            GoToGo = goToGo;
            GetOutOfJail = getOutOfJail;
            GoToJail = goToJail;

            CardType = EnCardType.Chance;
        }
    }
}
