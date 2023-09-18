using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonopolyCompanion.Pages
{
    public partial class NewGame : Page
    {
        List<Player> PlayerList { get; set; }
        

        public NewGame()
        {
            InitializeComponent();
        }

        private void AddPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            if(playerName.Text != "")
            {
                if(playersLv.Items.Count >= 8)
                {
                    MessageBox.Show("You can't add more than 8 players!");
                    return;
                }
                playersLv.Items.Add(playerName.Text);
            }
            playerName.Clear();
            playerName.Focus();
        }

        private void DeletePlayerBtn_Click(object sender, RoutedEventArgs e)
        {
             int selectedIndex = playersLv.SelectedIndex;
            if (selectedIndex != -1)
            {
                playersLv.Items.RemoveAt(selectedIndex);
            }
        }

        private void ClearPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            playersLv.Items.Clear();
        }

        private void StartGameBtn_Click(object sender, RoutedEventArgs e)
        {
            if(playersLv.Items.Count != 0)
            {
                PlayerList = new List<Player>();

                foreach (string item in playersLv.Items)
                {
                    PlayerList.Add(new Player(item, 1500));
                }

                //pobrać dane graczy do listy i utworzyć obiekty graczy
                GameController gameController = new GameController(PlayerList);

                this.NavigationService.Navigate(new Uri("/Pages/Game.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("You can't start a game without players!");
            }
        }

    }
}
