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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Aplicacion8
{
    /// <summary>
    /// Lógica de interacción para Actualizacion.xaml
    /// </summary>
    public partial class Actualizacion : Window
    {
        SqlConnection conexionSql;
        private string idCliente;

        public Actualizacion(string idCliente)
        {
            InitializeComponent();

            this.idCliente = idCliente;

            string cadenaConexion = ConfigurationManager.ConnectionStrings["Aplicacion8.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            this.conexionSql = new SqlConnection(cadenaConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = $"UPDATE CLIENTES SET nombre=@nombre WHERE Id={this.idCliente}";

                SqlCommand sqlCommand = new SqlCommand(consulta, this.conexionSql);

                this.conexionSql.Open();

                sqlCommand.Parameters.AddWithValue("@nombre", this.txtNombreCliente.Text);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Cliente actualizado!!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conexionSql.Close();
            }
        }
    }
}
