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

namespace MenuDigitale
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
        List<string> comanda = new List<string>();

        private void add_primi_1_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Tagliatelle al ragu");
            lbl_conferma.Content = "Aggiunte le taggliatelle ala ragu !";

        }

        private void add_primi_2_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Penne all'arrabbiata");
            lbl_conferma.Content = "Aggiunte le Penne all'arrabbiata !";

        }

        private void add_primi_3_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Gnocchi al pomodoro");
            lbl_conferma.Content = "Aggiunti gli Gnocchi al pomodoro !";

        }

        private void add_primi_4_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Tortellini alla norcina");
            lbl_conferma.Content = "Aggiunti  i tortellini alla norcina !";

        }

        private void add_primi_5_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Spaghetti alla carbonara");
            lbl_conferma.Content = "Aggiunti gli spaghetti alla carbonara!";

        }

        private void add_secondi_1_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Tagliata");
            lbl_conferma.Content = "Aggiunta la tagliata !";

        }

        private void add_secondi_2_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Filetto al pepe rosa");
            lbl_conferma.Content = "Aggiunto il filetto al pepe rosa !";

        }

        private void add_secondi_3_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Bistecca alla fiorentina");
            lbl_conferma.Content = "Aggiunta la bistecca alla fiorentina !";

        }

        private void add_secondi_4_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Grigliata mista");
            lbl_conferma.Content = "Aggiunta la grigliata mista!";
        }

        private void add_secondi_5_Click(object sender, RoutedEventArgs e)
        {
            comanda.Add("Tartare di vitello");
            lbl_conferma.Content = "Aggiunta la tartare di vitello !";

        }

        private void Comanda_Click(object sender, RoutedEventArgs e)
        {
            new ConfermaComanda(comanda).ShowDialog();
        }
    }
}

