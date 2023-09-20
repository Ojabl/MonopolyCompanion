using System.Collections.Generic;

namespace MonopolyCompanion
{
    class GameController
    {
        public List<Player> players = new List<Player> ();
        public List<ICard> cards = new List<ICard>(); 
        public Player currentPlayer;
        
        public GameController(List<Player> players)
        {
            this.players = players;
            currentPlayer = players[0];

            this.cards = new List<ICard> {
                new Estate("Mediterranean Avenue", EnCardColor.Brown, 60, 2, 10, 30, 90, 160, 250, 30, 50, 50),
                new Estate("Baltic Avenue", EnCardColor.Brown, 60, 4, 20, 60, 180, 320, 450, 30, 50, 50),
                new Estate("Oriental Avenue", EnCardColor.LightBlue, 100, 6, 30, 90, 270, 400, 550, 50, 50, 50),
                new Estate("Vermont Avenue", EnCardColor.LightBlue, 100, 6, 30, 90, 270, 400, 550, 50, 50, 50),
                new Estate("Connecticut Avenue", EnCardColor.LightBlue, 120, 8, 40, 100, 300, 450, 600, 60, 50, 50),
                new Estate("St. Charles Place", EnCardColor.Pink, 140, 10, 50, 150, 450, 625, 750, 70, 100, 100),
                new Estate("States Avenue", EnCardColor.Pink, 140, 10, 50, 150, 450, 625, 750, 70, 100, 100),
                new Estate("Virginia Avenue", EnCardColor.Pink, 160, 12, 60, 180, 500, 700, 900, 80, 100, 100),
                new Estate("St. James Place", EnCardColor.Orange, 180, 14, 70, 200, 550, 750, 950, 90, 100, 100),
                new Estate("Tennessee Avenue", EnCardColor.Orange, 180, 14, 70, 200, 550, 750, 950, 90, 100, 100),
                new Estate("New York Avenue", EnCardColor.Orange, 200, 16, 80, 220, 600, 800, 1000, 100, 100, 100),
                new Estate("Kentacky Avenue", EnCardColor.Red, 220, 18, 90, 250, 700, 875, 1050, 110, 150, 150),
                new Estate("Indiana Avenue", EnCardColor.Red, 220, 18, 90, 250, 700, 875, 1050, 110, 150, 150),
                new Estate("Illinois Avenue", EnCardColor.Red, 240, 20, 100, 300, 750, 925, 1100, 120, 150, 150),
                new Estate("Atlantic Avenue", EnCardColor.Yellow, 260, 22, 110, 330, 800, 975, 1150, 130, 150, 150),
                new Estate("Ventnor Avenue", EnCardColor.Yellow, 260, 22, 110, 330, 800, 975, 1150, 130, 150, 150),
                new Estate("Marvin Gardens", EnCardColor.Yellow, 280, 24, 120, 360, 850, 1025, 1200, 140, 150, 150),
                new Estate("Pacific Avenue", EnCardColor.Green, 300, 26, 130, 390, 900, 1100, 1275, 150, 200, 200),
                new Estate("North Carolina Avenue", EnCardColor.Green, 300, 26, 130, 390, 900, 1100, 1275, 150, 200, 200),
                new Estate("Pennsylvania Avenue", EnCardColor.Green, 320, 28, 150, 450, 1000, 1200, 1400, 160, 200, 200),
                new Estate("Park Place", EnCardColor.DarkBlue, 350, 35, 175, 500, 1100, 1300, 1500, 175, 200, 200),
                new Estate("Boardwalk", EnCardColor.DarkBlue, 400, 50, 200, 600, 1400, 1700, 2000, 200, 200, 200),

                new Railroad("Reading Railroad", 200, 25, 50, 100, 200, 100),
                new Railroad("Pennsylvania Railroad", 200, 25, 50, 100, 200, 100),
                new Railroad("B. & O. Railroad", 200, 25, 50, 100, 200, 100),
                new Railroad("Short Line", 200, 25, 50, 100, 200, 100),

                new Utility("Electric Company", "If one utility card is owned, rent is 4 times amount shown on dice. If both utilities are owned rent is 10 times amount shown on dice.", 150, 75),
                new Utility("Electric Company", "If one utility card is owned, rent is 4 times amount shown on dice. If both utilities are owned rent is 10 times amount shown on dice.", 150, 75),

                new CommunityChestCard(1, "You set aside time every week to hang out with your elderly neighbour - you've heard some amazing stories! Collect 100$.", 100),
                new CommunityChestCard(2, "You organize a group to clean up your town's footpaths. Collect 50$", 50),
                new CommunityChestCard(3, "You volunteered at a blood donation. There were free cookies! Collect 10$", 10),
                new CommunityChestCard(4, "You buy a few bags of cookies from that school bake sale. Yum! Pay 50$", -50),
                new CommunityChestCard(5, "You rescue a puppy - and you feel rescued, too! Get out of jail free. Keep this card until needed, traded or sold.", 0, getOutOfJailCard: true),
                new CommunityChestCard(6, "You organize a street party so people on your road can get to know each other. Collect 10$ from each player", 10 * players.Count),
                new CommunityChestCard(7, "Blasting music late at night? Your neighbours do not approve. Go to jail. Do not pass Go. Do not collect 200$", 0, goToJail: true),
                new CommunityChestCard(8, "You help your neighbour bring in the groceries. She makes youi lunch to say thanks! Collect 20$", 20),
                new CommunityChestCard(9, "You help build a new school playground - then you get to test the slide! Collect 100$", 100),
                new CommunityChestCard(10, "You spend the day playing games with kids at local children's hospital. Collect 100$", 100),
                new CommunityChestCard(11, "You go to the local school's car wash fundraiser - but you forget to close your windows! Pay 100$", -100),
                new CommunityChestCard(12, "Just when you think you can't go another step, you finish that foot race - and raise money for your local hospital! Advance to Go. Collect 200$", 0, goToGo: true),
                new CommunityChestCard(13, "You help your neighbours clean up their Gardens after a big storm. Collect 200$", 200),
                new CommunityChestCard(14, "Your fuzzy friends at the animal shelter will be thankful for your donation.", -50),
                new CommunityChestCard(15, "You should have volunteered for that home improvement project - you would have learned valuable skills! For each house you own, pay 40$. For each hotel you own, pay 115$", 0), // TODO IDK HOW TO DO IT
                new CommunityChestCard(16, "You organize a bake sale for your local school! collect 25$", 25),

                new ChanceCard(1, "Advance to Boardwalk."),
                new ChanceCard(2, "Advance to Go.", goToGo: true),
                new ChanceCard(3, "Advance to Illinois Avenue."),
                new ChanceCard(4, "Advance to St. Charles Place."),
                new ChanceCard(5, "Advance to the nearest Railroad. If unowned, you may buy it from the bank. If owned, pay wonder twice the rental to which they are otherwise entitled."),
                new ChanceCard(6, "Advance to the nearest Railroad. If unowned, you may buy it from the bank. If owned, pay wonder twice the rental to which they are otherwise entitled."),
                new ChanceCard(7, "Advance token to nearest Utility. If unowned, you may buy it from the Bank. If owned, throw dice and pay owner a total ten times amount thrown."),
                new ChanceCard(8, "Bank pays you dividend of $50.", value: 50),
                new ChanceCard(9, "Get out of jail free", getOutOfJail: true),
                new ChanceCard(10, "Go Back 3 spaces."),
                new ChanceCard(11, "Go to Jail. Do not pass Go. Do not collect 200$", goToJail: true),
                new ChanceCard(12, "Make general repairs on all your property. For each house pay 25$. For each hotel pay 100$.", value: 0), // TODO IDK HOW TO DO IT
                new ChanceCard(13, "Speeding fine $15.", value: -15),
                new ChanceCard(14, "Take a trip to Reading Railroad. If you pass Go, collect 200$"),
                new ChanceCard(15, "You have been elected Chairman of the Board. Pay each player 50$.", value: -50 * players.Count),
                new ChanceCard(16, "Your building loan matures. Receive 150$.", value: 150)
            };   
        }
    }
}
