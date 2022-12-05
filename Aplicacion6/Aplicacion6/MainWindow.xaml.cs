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

namespace Aplicacion6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capital> listaCapitales = new List<Capital>();

            listaCapitales.Add(new Capital { NombreCapital = "Buenos Aires" });
            listaCapitales.Add(new Capital { NombreCapital = "Madrid" });
            listaCapitales.Add(new Capital { NombreCapital = "Lima" });
            listaCapitales.Add(new Capital { NombreCapital = "Santiago de Chile" });
            listaCapitales.Add(new Capital { NombreCapital = "Bogota" });

            this.Capitales.ItemsSource = listaCapitales;
        }

        private void vistasCapitales_Checked(object sender, RoutedEventArgs e)
        {
            this.bsAs.IsChecked = true;
            this.madrid.IsChecked = true;
            this.lima.IsChecked = true;
            this.sgoChile.IsChecked = true;
            this.bogota.IsChecked = true;
        }

        private void vistasCapitales_Unchecked(object sender, RoutedEventArgs e)
        {
            this.bsAs.IsChecked = false;
            this.madrid.IsChecked = false;
            this.lima.IsChecked = false;
            this.sgoChile.IsChecked = false;
            this.bogota.IsChecked = false;
        }

        private void singleChecked(object sender, RoutedEventArgs e)
        {
            if (this.bsAs.IsChecked == true && this.madrid.IsChecked == true && this.lima.IsChecked == true &&
                this.sgoChile.IsChecked == true && this.bogota.IsChecked == true)
            {
                this.vistasCapitales.IsChecked = true;
            }
            else
            {
                this.vistasCapitales.IsChecked = null;
            }
        }

        private void singleUnchecked(object sender, RoutedEventArgs e)
        {
            if (this.bsAs.IsChecked == false && this.madrid.IsChecked == false && this.lima.IsChecked == false &&
                this.sgoChile.IsChecked == false && this.bogota.IsChecked == false)
            {
                this.vistasCapitales.IsChecked = false;
            }
            else
            {
                this.vistasCapitales.IsChecked = null;
            }
        }
    }

    public class Capital
    {
        public string NombreCapital
        {
            get; set;
        }
    }
}
