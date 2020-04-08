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
        string wynik2 = "";
        bool czywynik = false;
        string operacja = "";

       
        private void Bloc()
        {
            BKropka.IsEnabled = false;
            B0.IsEnabled = false;
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            B4.IsEnabled = false;
            B5.IsEnabled = false;
            B6.IsEnabled = false;
            B7.IsEnabled = false;
            B8.IsEnabled = false;
            B9.IsEnabled = false;
        }

        private void Unblock()
        {
            BKropka.IsEnabled = true;
            B0.IsEnabled = true;
            B1.IsEnabled = true;
            B2.IsEnabled = true;
            B3.IsEnabled = true;
            B4.IsEnabled = true;
            B5.IsEnabled = true;
            B6.IsEnabled = true;
            B7.IsEnabled = true;
            B8.IsEnabled = true;
            B9.IsEnabled = true;
        }

        private void BlockOp()
        {
            BOdejmowanie.IsEnabled = false;
            BDodawanie.IsEnabled = false;
            BMnozenie.IsEnabled = false;
            BDzielenie.IsEnabled = false;
        }
        private void UnBlockOp()
        {
            BOdejmowanie.IsEnabled = true;
            BDodawanie.IsEnabled = true;
            BMnozenie.IsEnabled = true;
            BDzielenie.IsEnabled = true;
        }

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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
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
                BlockOp();
            }
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            
            if (operacja == "")
            {
                if (liczba1 == "")
                {
                    liczba1 += "0";
                    B0.IsEnabled = false;
                    WynikTexBox.Text = liczba1;
                    
                }
                else
                {
                    B0.IsEnabled = true;
                    liczba1 += "0";
                    WynikTexBox.Text = liczba1;
                    
                }
            }
            else
            {
                if (liczba2 == "")
                {
                    liczba2 += "0";
                    B0.IsEnabled = false;
                    WynikTexBox.Text = liczba2;
                    BlockOp();
                }
                else
                {
                    B0.IsEnabled = true;
                    liczba2 += "0";
                    WynikTexBox.Text = liczba2;
                    BlockOp();
                }
            }
        }

        private void BKropka_Click(object sender, RoutedEventArgs e)
        {
            if (liczba1 != "")
            {

                if (operacja == "")
                {
                    liczba1 += ".";
                    BKropka.IsEnabled = false;
                    WynikTexBox.Text = liczba1;                  
                }
                else
                {
                    if (liczba2 != "")
                    {
                        liczba2 += ".";
                        BKropka.IsEnabled = false;
                        WynikTexBox.Text = liczba2;
                    }                  
                }
            }
            B0.IsEnabled = true;
        }

        private void BWynik_Click(object sender, RoutedEventArgs e)
        {

            if (liczba1 != "" && liczba2 != "")
            {
                var l1 = Convert.ToDouble(liczba1);
                var l2 = Convert.ToDouble(liczba2);
                switch (operacja)
                {
                    case "+":
                        wynik2 = (l1 + l2).ToString();
                        WynikTexBox.Text = wynik2;
                        wynik2 = liczba1;
                        break;
                    case "-":
                        WynikTexBox.Text = (l1 - l2).ToString();
                        liczba1 = WynikTexBox.Text;
                        break;
                    case "*":
                        WynikTexBox.Text = (l1 * l2).ToString();
                        liczba1 = WynikTexBox.Text;
                        break;
                    case "/":
                        if (l2 == 0)
                            WynikTexBox.Text = "Blad";
                        else
                        {
                            wynik = (float)(l1 / l2);
                            WynikTexBox.Text = wynik.ToString();
                            liczba1 = WynikTexBox.Text;
                        }
                        break;

                }
            }
            else if (operacja == "")
            {
                WynikTexBox.Text = liczba1;
                BKropka.IsEnabled = false;
                
            }
            liczba1 = WynikTexBox.Text;
            wynik = 0;
            liczba2 = "";
            operacja = "";
            Bloc();
            UnBlockOp();
        }

        private void BDodawanie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "+";
            WynikTexBox.Text = "";
            Unblock();
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
                Unblock();
            }
        }

        private void BMnozenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "*";
            WynikTexBox.Text = "";
            Unblock();  
        }

        private void BDzielenie_Click(object sender, RoutedEventArgs e)
        {
            operacja = "/";
            WynikTexBox.Text = "";
            Unblock();
        }



        private void BC_Click(object sender, RoutedEventArgs e)
        {
            liczba2 = "";
            liczba1 = "";
            wynik = 0;
            operacja = "";
            WynikTexBox.Text = "";
            Unblock();

        }

        private void BAC_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "")
            {
                liczba1 = "";
                WynikTexBox.Text = "";
                Unblock();

            }
            else
            {
                liczba2 = "";
                WynikTexBox.Text = "";
                Unblock();

            }

        }
    }
}
