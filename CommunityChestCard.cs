using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCompanion
{
    class CommunityChestCard : ICard
    {
        public string Name { get; set; }
        public EnCardType CardType { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
        public bool GetOutOfJailCard {  get; set; }
        public bool GoToJail { get; set; }
        public bool GoToGo { get; set; }


        public CommunityChestCard(int id, string description, int value, bool getOutOfJailCard = false, bool goToJail = false, bool goToGo = false) 
        {
            Id = id;
            Name = "null";
            Description = description;
            Value = value;
            GetOutOfJailCard = getOutOfJailCard;
            GoToJail = goToJail;
            GoToGo = goToGo;
            CardType = EnCardType.CommunityChest;
        }

    }
}
