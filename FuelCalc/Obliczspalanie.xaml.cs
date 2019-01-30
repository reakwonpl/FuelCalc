using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Storage;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using Windows.Storage;
using System.IO;


namespace FuelCalc
{
    
    public partial class Obliczspalanie : PhoneApplicationPage
    {
        
        private Spalanie spalanie;

        public Obliczspalanie()
        {
            InitializeComponent();
        }
        double wynik = 0;
        private void btnlicz_Click(object sender, RoutedEventArgs e)
        {
            double iloscPaliwa;
            double przejechaneKilometry;
            

            try
            {
                iloscPaliwa = double.Parse(txtbox1.Text);
                przejechaneKilometry = double.Parse(txtbox2.Text);
                 if (iloscPaliwa < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (przejechaneKilometry < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                                
                spalanie = new Spalanie(iloscPaliwa, przejechaneKilometry);

                txtbox5.Text = Math.Round(spalanie.wynikSpalania, 2) + "L na 100 km";
                wynik = Math.Round(spalanie.wynikSpalania, 2);
                Global.data = wynik;
                

                string time = DateTime.Now.ToShortDateString();

                using (StreamWriter text = new StreamWriter("myfile.txt", true))
                {
                    text.Write( " " + txtbox5.Text + " " + time + "\n");
                }

            }
                 catch (Exception )
                 {
                      MessageBox.Show("Wpisz prawidłowo liczby!");
                 }

        }
                  

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
         }

        private void txtbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox1.Text, "[^0-9.-]+"))
            {

                MessageBox.Show("Prosze wpisywać tylko liczby i kropki!");
                txtbox1.Text = txtbox1.Text.Remove(txtbox1.Text.Length - 1);
            }
        }

        private void txtbox2_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox1.Text, "[^0-9.-]+"))
            {

                MessageBox.Show("Prosze wpisywać tylko liczby i kropki!");
                txtbox1.Text = txtbox1.Text.Remove(txtbox1.Text.Length - 1);
            }
        }
               
    }
}