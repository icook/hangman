using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Resources;
using System.Text.RegularExpressions;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<string> dictionary = new List<string>();
        App main = (App)Application.Current;

        // Public variables that get set by other screens
        public char selected = ' ';

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Load up a stream reader to go through our internal text dictionary
            StreamResourceInfo words = Application.GetResourceStream(new Uri("/PhoneApp1;component/words.txt", UriKind.Relative));
            if (words == null)
                Debug.WriteLine("Unable to load word list!");
            else
            {
                Stream txtStream = words.Stream;
                using (StreamReader sr = new StreamReader(txtStream))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        dictionary.Add(line);
                    }
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (main.charCount == -1)
            {
                NavigationService.Navigate(new Uri("/CountSelect.xaml", UriKind.Relative));
            }
            // For now just assume they're returning from character selection
            Recalculate();
        }

        private void GuessClick2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CharSelect.xaml", UriKind.Relative));
        }

        private void Recalculate()
        {
            // Compile our regex ahead of time for speeds
            string regex = main.guessString.Replace("*", ".");
            Regex pattern = new Regex("^" + regex + "$", RegexOptions.Compiled);

            // book keeping on the matching statistics
            int matchCount = 0;
            int[] lettMatch = new int[26];
            List<string> matches = new List<string>();
            foreach (string word in dictionary)
            {
                if (pattern.IsMatch(word))
                {
                    matchCount++;
                    foreach (char c in word)
                    {
                        // TODO: Check for in bounds character. Shouldn't occur, but it will unless we carefully 
                        // filter the dictionary. On the todo list
                        if ((int)c >= 97 && (int)c < 123)
                            lettMatch[(int)c - 97]++;
                    }

                    if (matchCount < 100)
                        matches.Add(word);
                }
            }
            letterDistribution.Items.Clear();
            potentialMatches.Items.Clear();
            for (int i = 0; i < 26; i++) {
                char upperChar = (char)(i + 65);
                letterDistribution.Items.Add(upperChar.ToString() + ": " + lettMatch[i]);
            }
            if (matchCount <= 100)
            {
                potentialMatches.FontSize = 14;
                foreach (string item in matches)
                    potentialMatches.Items.Add(item);
            }
            else
            {
                potentialMatches.FontSize = 18;
                potentialMatches.Items.Add("Too Many to Show");
            }
            matchedNotice.Text = "words matched: " + matchCount.ToString();
        }
    }
}