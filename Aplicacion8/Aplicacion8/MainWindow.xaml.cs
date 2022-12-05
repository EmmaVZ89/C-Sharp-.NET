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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Aplicacion8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conexionSql;

        public MainWindow()
        {
            InitializeComponent();
            // NombreProyecto.Properties.Settings.CadenaConexion
            string cadenaConexion = ConfigurationManager.ConnectionStrings["Aplicacion8.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            this.conexionSql = new SqlConnection(cadenaConexion);

            this.MostrarClientes();
            this.MostrarPedidos();
        }

        private void MostrarClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTES";
                SqlDataAdapter adaptadorSql = new SqlDataAdapter(consulta, this.conexionSql);

                using (adaptadorSql)
                {
                    DataTable tablaClientes = new DataTable();
                    adaptadorSql.Fill(tablaClientes);
                    this.listaClientes.DisplayMemberPath = "nombre";
                    this.listaClientes.SelectedValuePath = "Id";
                    this.listaClientes.ItemsSource = tablaClientes.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarPedidosCliente()
        {
            try
            {
                string consulta = "SELECT * FROM PEDIDOS AS P INNER JOIN CLIENTES AS C ON C.Id=P.cCliente" +
                " WHERE C.Id=@ClienteId";

                SqlCommand sqlComando = new SqlCommand(consulta, this.conexionSql);

                SqlDataAdapter adaptadorSql = new SqlDataAdapter(sqlComando);

                using (adaptadorSql)
                {
                    sqlComando.Parameters.AddWithValue("@ClienteId", this.listaClientes.SelectedValue);

                    DataTable tablaPedidos = new DataTable();
                    adaptadorSql.Fill(tablaPedidos);
                    this.pedidosCliente.DisplayMemberPath = "fechaPedido";
                    this.pedidosCliente.SelectedValuePath = "Id";
                    this.pedidosCliente.ItemsSource = tablaPedidos.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarPedidos()
        {
            try
            {
                //string consulta = "SELECT * FROM PEDIDOS";
                string consulta = "SELECT *, CONCAT(cCliente, ' ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDOS";

                SqlDataAdapter adaptadorSql = new SqlDataAdapter(consulta, this.conexionSql);

                using (adaptadorSql)
                {
                    DataTable tablaPedidos = new DataTable();
                    adaptadorSql.Fill(tablaPedidos);
                    this.listaPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    this.listaPedidos.SelectedValuePath = "Id";
                    this.listaPedidos.ItemsSource = tablaPedidos.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(this.listaClientes.SelectedValue != null)
            {
                this.MostrarPedidosCliente();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show(this.listaPedidos.SelectedValue.ToString());
                string consulta = "DELETE FROM PEDIDOS WHERE Id=@IdPedido";
                SqlCommand sqlCommand = new SqlCommand(consulta, this.conexionSql);

                this.conexionSql.Open();

                sqlCommand.Parameters.AddWithValue("@IdPedido", this.listaPedidos.SelectedValue);

                sqlCommand.ExecuteNonQuery();

                this.conexionSql.Close();

                this.MostrarPedidos();
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show(this.listaPedidos.SelectedValue.ToString());
                string consulta = "INSERT INTO CLIENTES (nombre) VALUES (@nombre)";
                SqlCommand sqlCommand = new SqlCommand(consulta, this.conexionSql);

                this.conexionSql.Open();

                sqlCommand.Parameters.AddWithValue("@nombre", this.txtInsertarCliente.Text);

                sqlCommand.ExecuteNonQuery();

                this.conexionSql.Close();

                this.MostrarClientes();

                this.txtInsertarCliente.Text = "";
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM CLIENTES WHERE Id=@IdCliente";
                SqlCommand sqlCommand = new SqlCommand(consulta, this.conexionSql);

                this.conexionSql.Open();

                sqlCommand.Parameters.AddWithValue("@IdCliente", this.listaClientes.SelectedValue);

                sqlCommand.ExecuteNonQuery();

                this.conexionSql.Close();

                this.MostrarClientes();
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualizacion ventanaActualizar = new Actualizacion(this.listaClientes.SelectedValue.ToString());

            //ventanaActualizar.Show();

            try
            {
                string consulta = "SELECT nombre FROM CLIENTES WHERE Id=@IdCliente";

                SqlCommand sqlCommand = new SqlCommand(consulta, this.conexionSql);

                SqlDataAdapter adaptadorSql = new SqlDataAdapter(sqlCommand);

                using (adaptadorSql)
                {
                    sqlCommand.Parameters.AddWithValue("@IdCliente", this.listaClientes.SelectedValue);

                    DataTable tablaClientes = new DataTable();
                    adaptadorSql.Fill(tablaClientes);
                    ventanaActualizar.txtNombreCliente.Text = tablaClientes.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ventanaActualizar.ShowDialog();
            this.MostrarClientes();
        }
    }
}
