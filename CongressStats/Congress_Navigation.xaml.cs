﻿using System;
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

namespace CongressStats
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Congress_Navigation : Page
    {
        public Congress_Navigation()
        {
            InitializeComponent();
        }

        private void Browse_Representatives_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CongressListing("representative"));
        }

        private void Browse_Senators_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CongressListing("senator"));
        }

        private void Prev_Page(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomePage());
        }

        private void View_All_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CongressListing());
        }
    }
}
