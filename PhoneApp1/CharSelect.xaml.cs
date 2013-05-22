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

namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CharButtonClick(object sender, RoutedEventArgs e)
        {
            // Grab the character that was pressed and pass it back to our previous form
            NavigationService.Navigate(new Uri("/MainPage.xaml?val=" + ((Button)sender).Content, UriKind.Relative));
        }
    }
}