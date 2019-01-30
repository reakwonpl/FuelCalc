using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FuelCalc.Resources;
using System.IO;

namespace FuelCalc
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Obliczspalanie.xaml", UriKind.Relative));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Obliczkoszt.xaml", UriKind.Relative));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Historia.xaml", UriKind.Relative));
            
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dziennik.xaml", UriKind.Relative));

        }
               
        
    }
}