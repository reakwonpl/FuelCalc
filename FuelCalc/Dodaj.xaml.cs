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
    public partial class Dodaj : PhoneApplicationPage
    {
        private DziennikKosztow dziennik;
        public Dodaj()
        {
            InitializeComponent();
        }

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            double koszt = double.Parse(tb3.Text);
            string typ = tb1.Text;
            string nazwa = tb2.Text;

            dziennik = new DziennikKosztow(typ, nazwa, koszt);
            Global.calkowityKoszt =+ dziennik.calkowityKoszt; 
            using (StreamWriter text = new StreamWriter("dziennik.txt",true))
            {
                text.Write(tb1.Text + "\n" + tb2.Text + "\n" + tb3.Text + "\n" + "\n");
            }
            MessageBox.Show("Pomyślnie dodano dane :)");

        }
    }
}