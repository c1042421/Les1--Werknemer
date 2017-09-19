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

namespace oefWerknemer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            double verdiensten;
            string voornaam = txtVoornaam.Text;
            string achternaam = txtAchternaam.Text;

            if (double.TryParse(txtVerdiensten.Text, out verdiensten) && voornaam.Length != 0 && achternaam.Length != 0)
            {
                txtOutput.Text += string.Format("{0} {1} {2} €\n", achternaam.PadRight(20), voornaam.PadRight(20), verdiensten.ToString().PadLeft(20));
            } else
            {
                if (achternaam.Length == 0)
                {
                    toonMessageBox("Geef voornaam in!");
                }
                else if(voornaam.Length == 0)
                {
                    toonMessageBox("Geef een voornaam in!");
                } else
                {
                    toonMessageBox("Geef een numerieke waarde in bij verdiensten!");
                }
            }
        }

        private void toonMessageBox(string message)
        {
            MessageBox.Show(message, "Fout!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
