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
    public partial class Landing : Page
    {
        public Landing()
        {
            InitializeComponent();
        }
        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/NewGame.xaml", UriKind.Relative));
        }

        private void LoadGameBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/LoadGame.xaml", UriKind.Relative));
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }
    }
}
