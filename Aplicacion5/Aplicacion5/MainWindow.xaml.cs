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

namespace Aplicacion5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblacion> listaPob = new List<Poblacion>();
            listaPob.Add(new Poblacion() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17 });
            listaPob.Add(new Poblacion() { Poblacion1 = "Buenos Aires", Poblacion2 = "Cordoba", Temperatura1 =23, Temperatura2 = 21 });
            listaPob.Add(new Poblacion() { Poblacion1 = "Paris", Poblacion2 = "Florencia", Temperatura1 = 12, Temperatura2 = 10 });
            listaPob.Add(new Poblacion() { Poblacion1 = "Washington", Poblacion2 = "Cdad Mexico", Temperatura1 = 17, Temperatura2 = 27 });

            this.listaPoblacion.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.listaPoblacion.SelectedItem != null)
            {
                string poblacion1 = (this.listaPoblacion.SelectedItem as Poblacion).Poblacion1;
                string poblacion2 = (this.listaPoblacion.SelectedItem as Poblacion).Poblacion2;
                string temperatura1 = (this.listaPoblacion.SelectedItem as Poblacion).Temperatura1 + " °C";
                string temperatura2 = (this.listaPoblacion.SelectedItem as Poblacion).Temperatura2 + " °C";
                MessageBox.Show($"{poblacion1} {temperatura1} {poblacion2} {temperatura1}");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un elemento!!");
            }
                
        }
    }

    public class Poblacion
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemp
        {
            get 
            {
                int rtn = this.Temperatura1 - this.Temperatura2;
                if(rtn < 0)
                {
                    rtn = rtn * -1;
                }
                return rtn; 
            }
            set { }
        }
    }
}
