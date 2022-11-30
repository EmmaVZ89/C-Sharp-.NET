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

namespace Aplicacion3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public int PruebaProperty
        //{
        //    get { return (int)GetValue(PruebaDependencyProperty); }
        //    set { SetValue(PruebaDependencyProperty, value); }
        //}

        //// Registrar Property
        //public static readonly DependencyProperty PruebaDependencyProperty = 
        //    DependencyProperty.Register("PruebaProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
