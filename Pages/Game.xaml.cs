using System;
using System.Windows;
using System.Windows.Controls;

namespace MonopolyCompanion.Pages
{
    public partial class Game : Page
    {

        GameController gameController = NewGame.gameController;
        public static Player? currentPlayer { get; set; }


        public Game()
        {
            DataContext = this;
            InitializeComponent();
            currentPlayer = gameController.players[0];
            currentPlayerLb.Content = currentPlayer;
            moneyLb.Content = currentPlayer.Money + " $";
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Landing.xaml", UriKind.Relative));
        }
        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }
        private void SaveGameBtn_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void BuyEstateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SellEstateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RollDiceBtn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            MessageBox.Show("You rolled " + dice1 + " and " + dice2 + "!");
        }
    }
}
