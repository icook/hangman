using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Text;

namespace PhoneApp1
{
    public partial class CountSelect : PhoneApplicationPage
    {
        public CountSelect()
        {
            InitializeComponent();
        }

        private void proceed_Click(object sender, RoutedEventArgs e)
        {
            App main = (App)Application.Current;
            main.charCount = Convert.ToInt32(characters.Text);
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < main.charCount; i++ )
            {
                sb.Append("*");
            }
            main.guessString = sb.ToString();
            MessageBox.Show("Hello world!");
            NavigationService.GoBack();
            characters.Text = "";
        }
    }
}