using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;

namespace FuelCalc
{
    public partial class Dziennik : PhoneApplicationPage
    {
        public Dziennik()
        {
            InitializeComponent();
        }

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dodaj.xaml", UriKind.Relative));
        }

        private void btnSprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (Global.calkowityKoszt <= 0)
            {
                tbc.Text = "Brak wydatków :>";
            } else tbc.Text = "Całkowity koszt wydatków wynosi :" + Global.calkowityKoszt;
        }

        private void btnPokaz_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader("dziennik.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    txtb.Text += line + "\n";
                }
                btnPokaz.IsEnabled = false;
            }
        }
    }
}