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
    public partial class MatchSelect : PhoneApplicationPage
    {
        App main = (App)Application.Current;

        public MatchSelect()
        {
            InitializeComponent();
            RowDefinition newRow = new RowDefinition();
            container.RowDefinitions.Add(newRow);
            int j = 0;
            for (int i = 0; i < ((App)Application.Current).charCount; i++)
            {
                if (i % 5 == 0 && i > 0)
                {
                    RowDefinition additionalRow = new RowDefinition();
                    container.RowDefinitions.Add(additionalRow);
                    // Add a new column at the end if we haven't already
                    if (j == 0)
                    {
                        ColumnDefinition col = new ColumnDefinition();
                        container.ColumnDefinitions.Add(col);
                    }
                    TextBox box = new TextBox();
                    box.IsEnabled = false;
                    box.Text = "-";
                    Grid.SetRow(box, j);
                    Grid.SetColumn(box, i + 1 - (j * 5));
                    container.Children.Add(box);

                    j++;
                }
                if (j == 0)
                {
                    ColumnDefinition col = new ColumnDefinition();
                    container.ColumnDefinitions.Add(col);
                }
                Button but1 = new Button();
                but1.Content = main.guessString[i];
                but1.MaxHeight = 100;
                but1.Click += new RoutedEventHandler(CharButtonClick);
                but1.Name = i.ToString();
                Grid.SetRow(but1, j);
                Grid.SetColumn(but1, i-(j*5));
                container.Children.Add(but1);
            }
        }

        private void CharButtonClick(object sender, RoutedEventArgs e)
        {
            // Grab the character that was pressed and pass it back to our previous form
            int index = Convert.ToInt32(((Button)sender).Name);
            if (main.guessString[index] == '*')
            {
                ((Button)sender).Content = main.selectedCharacter;
                StringBuilder sb = new StringBuilder(main.guessString);
                sb[index] = main.selectedCharacter;
                main.guessString = sb.ToString();
            }
            else if (main.guessString[index] == main.selectedCharacter)
            {
                ((Button)sender).Content = "*";
                StringBuilder sb = new StringBuilder(main.guessString);
                sb[index] = '*';
                main.guessString = sb.ToString();
            }
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            main.guesses++;
            NavigationService.RemoveBackEntry();
            NavigationService.GoBack();
        }

    }
}