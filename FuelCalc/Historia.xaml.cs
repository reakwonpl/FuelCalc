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
    public partial class Historia : PhoneApplicationPage
    {
        public Historia()
        {
            InitializeComponent();
        }

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnPokaz_Click(object sender, RoutedEventArgs e)
        {
            

            using (StreamReader sr = new StreamReader("myfile.txt"))
            {
                string line;
                int x = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    x++;
                    textblock.Text += x +"." +line + "\n";
                }
            }
            btnPokaz.IsEnabled = false;

        }


       

       
    }
}