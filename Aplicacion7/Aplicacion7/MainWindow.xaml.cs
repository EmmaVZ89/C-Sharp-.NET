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

namespace Aplicacion7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Rojo.Visibility = Visibility.Visible;
            this.Amarillo.Visibility = Visibility.Hidden;
            this.Verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Rojo.Visibility = Visibility.Hidden;
            this.Amarillo.Visibility = Visibility.Visible;
            this.Verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Rojo.Visibility = Visibility.Hidden;
            this.Amarillo.Visibility = Visibility.Hidden;
            this.Verde.Visibility = Visibility.Visible;
        }
    }
}
