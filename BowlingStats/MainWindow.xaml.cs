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
namespace BowlingStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }



        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "0";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "1";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "2";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "3";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "4";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "5";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "6";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "7";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "8";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "9";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Scoring1.Text = "10";
            }
            else
            {
                Scoring1.Text = "";
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e) //Done//
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e) //Done//
        {
            yourName.Text = "";
            Scoring1.Text = "";
            Scoring2.Text = "";
            FinalScoreFrom1.Text = "";
            Scoring3.Text = "";
            Scoring4.Text = "";
            FinalScoreFrom2.Text = "";
            Scoring5.Text = "";
            Scoring6.Text = "";
            FinalScoreFrom3.Text = "";
            Scoring7.Text = "";
            Scoring8.Text = "";
            FinalScoreFrom4.Text = "";
            Scoring9.Text = "";
            Scoring10.Text = "";
            FinalScoreFrom5.Text = "";
            Scoring11.Text = "";
            Scoring12.Text = "";
            FinalScoreFrom6.Text = "";
            Scoring13.Text = "";
            Scoring14.Text = "";
            FinalScoreFrom7.Text = "";
            Scoring15.Text = "";
            Scoring16.Text = "";
            FinalScoreFrom8.Text = "";
            Scoring17.Text = "";
            Scoring18.Text = "";
            FinalScoreFrom9.Text = "";
            Scoring19.Text = "";
            Scoring20.Text = "";
            FinalScoreFrom10.Text = "";
        } 
    }
}