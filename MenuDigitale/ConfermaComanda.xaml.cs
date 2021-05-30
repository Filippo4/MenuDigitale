using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MenuDigitale
{
    /// <summary>
    /// Logica di interazione per ConfermaComanda.xaml
    /// </summary>
    public partial class ConfermaComanda : Window
    {
        List<string> comanda = new List<string>();
        public ConfermaComanda(List<string> comanda)
        {
            InitializeComponent();
            this.comanda = comanda;
            for (int i = 0; i < comanda.Count; i++)
                ltb_comanda.Items.Add(comanda[i].ToString());
        }

        private void btn_inviacomanda_Click(object sender, RoutedEventArgs e)
        {
            if (comanda.Count != 0)
            {
                MessageBox.Show("la comanda è stata inviata!", "Informazione", MessageBoxButton.OK, MessageBoxImage.Information);
                ltb_comanda.Items.Clear();
                comanda.Clear();
                this.Close();
            }else
                MessageBox.Show("la comanda non può essere inviata vuota!", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void btn_esci_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_cancellaComanda_Click(object sender, RoutedEventArgs e)
        {
            
            ltb_comanda.Items.Clear();
            comanda.Clear();
            this.Close();
        }
    }
}
