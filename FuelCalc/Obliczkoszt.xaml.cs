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
    public partial class Obliczkoszt : PhoneApplicationPage
    {
        private koszt Koszt;
        bool check = false;
        public Obliczkoszt()
        {
            InitializeComponent();
        }

        private void txtbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox1.Text, "[^0-9.-]+"))
            {

                MessageBox.Show("Prosze wpisywać tylko liczby i kropki!");
                txtbox1.Text = txtbox1.Text.Remove(txtbox1.Text.Length - 1);
            }
        }

        private void txtbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox2.Text, "[^0-9.-]+"))
            {

                MessageBox.Show("Prosze wpisywać tylko liczby i kropki!");
                txtbox2.Text = txtbox2.Text.Remove(txtbox2.Text.Length - 1);
            }
        }

        private void txtbox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox3.Text, "[^0-9.-]+"))
            {

                MessageBox.Show("Prosze wpisywać tylko liczby i kropki!");
                txtbox3.Text = txtbox3.Text.Remove(txtbox3.Text.Length - 1);
            }
        }
        

        private void btnlicz_Click(object sender, RoutedEventArgs e)
        {
            double dlugoscTrasy;
            double cenaPaliwa;
            double srednieSpalanie;
            try
            {
                if (check == true && Global.data > 0)
                {
                    srednieSpalanie = Global.data;
                } else  srednieSpalanie = double.Parse(txtbox2.Text);

                dlugoscTrasy = double.Parse(txtbox1.Text);
                cenaPaliwa = double.Parse(txtbox3.Text);
               
                if (dlugoscTrasy < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (cenaPaliwa < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (srednieSpalanie < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Koszt = new koszt(dlugoscTrasy, srednieSpalanie, cenaPaliwa);
                tb1.Text = " Koszt trasy wyniesie : " + Koszt.wynikKosztu + " zł";
                tb2.Text = " Ilość potrzebnego paliwa : " + Koszt.iloscPaliwa + "L";

                string time = DateTime.Now.ToShortDateString();

                using (StreamWriter text = new StreamWriter("myfile.txt", true))
                {
                    text.Write(tb1.Text +"\n" + tb2.Text + " " + time + "\n");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wpisz prawidłowo liczby!");
            }
        }


        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            check = true;

			

        }

		private void chkbox_Click(object sender, RoutedEventArgs e)
		{
			txtbox2.Text = Global.data.ToString();
		}

    }
}