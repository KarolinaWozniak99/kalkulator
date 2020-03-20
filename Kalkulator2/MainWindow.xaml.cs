using System;
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

namespace Kalkulator2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string liczba1 = "";
        string liczba2 = "";
        float wynik = 0;
        string operacja = "";

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "7";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "7";
                WynikTexBox.Text = liczba2;

            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "8";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "8";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "9";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "9";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "4";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "4";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "5";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "5";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "6";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "6";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "1";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "1";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "2";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "2";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "3";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "3";
                WynikTexBox.Text = liczba2;
            }
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 += "0";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += "0";
                WynikTexBox.Text = liczba2;
            }
        }

        private void BKropka_Click(object sender, RoutedEventArgs e)
        {


            
            if (operacja == "")
            {
                liczba1 += ".";
                WynikTexBox.Text = liczba1;
            }
            else
            {
                liczba2 += ".";
                WynikTexBox.Text = liczba2;
            }
            
        }

        private void BWynik_Click(object sender, RoutedEventArgs e)
        {

            if (liczba1 != "" && liczba2 !="" )
            {
                var l1 = Convert.ToDouble(liczba1);
                var l2 = Convert.ToDouble(liczba2);
                switch (operacja)
                {
                    case "+":
                        WynikTexBox.Text = (l1 + l2).ToString();
                        break;
                    case "-":
                        WynikTexBox.Text = (l1 - l2).ToString();
                        break;
                    case "*":
                        WynikTexBox.Text = (l1 * l2).ToString();
                        break;
                    case "/":
                        if (l2 == 0)
                            WynikTexBox.Text = "Blad";
                        else
                        {
                            wynik = (float)(l1 / l2);
                            WynikTexBox.Text = wynik.ToString();
                        }
                        break;
            
                }
            }
            else
                WynikTexBox.Text = liczba1;
        }

        private void BDodawanie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "+";
            WynikTexBox.Text = "";

        }

        private void BOdejmowanie_Click(object sender, RoutedEventArgs e)
        {

            if (liczba1 == "" && operacja == "")
            {
                liczba1 += "-";
                operacja = "";
                WynikTexBox.Text = liczba1;
            }

            else if (liczba2 == "" && operacja != "")
            {
                liczba2 += "-";
                WynikTexBox.Text = liczba2;
            }
            else
            {
                operacja = "-";
                WynikTexBox.Text = "";

            }
        }

        private void BMnozenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "*";
            WynikTexBox.Text = "";
        }

        private void BDzielenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "/";
            WynikTexBox.Text = "";
        }

        private void BProcent_Click(object sender, RoutedEventArgs e)
        {
            operacja = "%";
            WynikTexBox.Text = "";
        }


        private void BC_Click(object sender, RoutedEventArgs e)
        {
            liczba2 = "";
            liczba1 = "";
            wynik = 0;
            operacja = "";
            WynikTexBox.Text = "";
        }

        private void BAC_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 = "";
                WynikTexBox.Text = "";
            }
            else
            {
                liczba2 = "";
                WynikTexBox.Text = "";
            }

        }
    }
}
