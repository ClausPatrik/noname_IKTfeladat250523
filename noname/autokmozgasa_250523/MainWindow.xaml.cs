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
using System.IO;

namespace autokmozgasa_250523
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Adat> adatok = new List<Adat>();

        public MainWindow()
        {
            InitializeComponent();
            BetoltAdatok();
            ListaBox.ItemsSource = adatok;

        }

        private void BetoltAdatok()
        {
            var sorok = File.ReadAllLines("jeladas.txt");
            foreach (var sor in sorok)
            {
                var mezok = sor.Split('\t');
                if (mezok.Length == 4)
                {
                    adatok.Add(new Adat
                    {
                        Rendszam = mezok[0],
                        Honap = int.Parse(mezok[1]),
                        Nap = int.Parse(mezok[2]),
                        Ido = int.Parse(mezok[3])
                    });
                }
            }
        }

        private void Kereses_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
