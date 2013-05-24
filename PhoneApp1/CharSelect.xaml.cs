using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Diagnostics;
using System.Windows.Media;

namespace PhoneApp1
{
    public partial class CharSelect : PhoneApplicationPage
    {
        public MainPage parent = null;

        public CharSelect()
        {
            InitializeComponent();
        }

        private void CharButtonClick(object sender, RoutedEventArgs e)
        {
            // Grab the character that was pressed and pass it back to our previous form
            App main = Application.Current as App;
            string letter = (string)((Button)sender).Content;
            main.selectedCharacter = letter[0];
            //NavigationService.GoBack();
            NavigationService.Navigate(new Uri("/MatchSelect.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Debug.WriteLine(e.ToString());
        }

    }
}