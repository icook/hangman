﻿#pragma checksum "c:\users\t-iscook\documents\visual studio 2012\Projects\PhoneApp1\PhoneApp1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4056778489A7C62D21DD48AE55672786"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock title;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox puzzleName;
        
        internal System.Windows.Controls.ListBox potentialMatches;
        
        internal System.Windows.Controls.TextBox guessBox;
        
        internal System.Windows.Controls.Button guess;
        
        internal System.Windows.Controls.TextBlock matchedNotice;
        
        internal System.Windows.Controls.ListBox letterDistribution;
        
        internal System.Windows.Controls.TextBlock lettersTitle;
        
        internal System.Windows.Controls.TextBlock potentialTitle;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.title = ((System.Windows.Controls.TextBlock)(this.FindName("title")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.puzzleName = ((System.Windows.Controls.TextBox)(this.FindName("puzzleName")));
            this.potentialMatches = ((System.Windows.Controls.ListBox)(this.FindName("potentialMatches")));
            this.guessBox = ((System.Windows.Controls.TextBox)(this.FindName("guessBox")));
            this.guess = ((System.Windows.Controls.Button)(this.FindName("guess")));
            this.matchedNotice = ((System.Windows.Controls.TextBlock)(this.FindName("matchedNotice")));
            this.letterDistribution = ((System.Windows.Controls.ListBox)(this.FindName("letterDistribution")));
            this.lettersTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lettersTitle")));
            this.potentialTitle = ((System.Windows.Controls.TextBlock)(this.FindName("potentialTitle")));
        }
    }
}

