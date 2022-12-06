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

namespace Aplicacion10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string conexion = ConfigurationManager.ConnectionStrings["Aplicacion10.Properties.Settings.CrudLinqSql"].ConnectionString;

            this.dataContext = new DataClasses1DataContext(conexion);

            // CRUD con LINQ ORM
            //this.CrearEmpresa();
            //this.CrearEmpleado();
            //this.CrearCargo();
            //this.RelacionarEmpleadoCargo();
            //this.ActualizarEmpleado();
            //this.EliminarEmpleado();
        }


        public void CrearEmpresa()
        {
            //this.dataContext.ExecuteCommand("DELETE FROM empresas");

            empresas empresa = new empresas();
            empresa.Nombre = "Twitter";

            this.dataContext.empresas.InsertOnSubmit(empresa);
            this.dataContext.SubmitChanges();//se confirman los cambios

            this.Principal.ItemsSource = this.dataContext.empresas;
        }

        public void CrearEmpleado()
        {
            empresas empresa1 = this.dataContext.empresas.First(emp => emp.Nombre.Equals("Google"));
            empresas empresa2 = this.dataContext.empresas.First(emp => emp.Nombre.Equals("Facebook"));

            List<empleados> listaEmpleados = new List<empleados>();
            listaEmpleados.Add(new empleados { Nombre = "Emma", Apellido = "Perez", IdEmpresa = empresa1.Id });
            listaEmpleados.Add(new empleados { Nombre = "Juan", Apellido = "Gomez", IdEmpresa = empresa2.Id });
            listaEmpleados.Add(new empleados { Nombre = "Maria", Apellido = "Torrez", IdEmpresa = empresa1.Id });
            listaEmpleados.Add(new empleados { Nombre = "Pedro", Apellido = "Dias", IdEmpresa = empresa2.Id });

            this.dataContext.empleados.InsertAllOnSubmit(listaEmpleados);
            this.dataContext.SubmitChanges();

            this.Principal.ItemsSource = this.dataContext.empleados;
        }

        public void CrearCargo()
        {
            cargos cargo = new cargos();
            cargo.Cargo = "Administrativo";

            this.dataContext.cargos.InsertOnSubmit(cargo);
            this.dataContext.SubmitChanges();//se confirman los cambios

            this.Principal.ItemsSource = this.dataContext.cargos;
        }

        public void RelacionarEmpleadoCargo()
        {
            //empleados emp1 = this.dataContext.empleados.First(emp => emp.Nombre.Equals("Emma"));
            //empleados emp2 = this.dataContext.empleados.First(emp => emp.Nombre.Equals("Juan"));
            //cargos empDirector = this.dataContext.cargos.First(car => car.Cargo.Equals("Director"));
            //cargos empAdministrativo = this.dataContext.cargos.First(car => car.Cargo.Equals("Administrativo"));
            //cargos_empleados cargoEmp1 = new cargos_empleados();
            //cargoEmp1.empleados = emp1;
            //cargoEmp1.IdCargo = empDirector.Id;
            //cargos_empleados cargoEmp2 = new cargos_empleados();
            //cargoEmp2.empleados = emp2;
            //cargoEmp2.IdCargo = empAdministrativo.Id;

            List<cargos_empleados> listaCargosEmpleados = new List<cargos_empleados>();
            listaCargosEmpleados.Add(new cargos_empleados { IdCargo = 1, IdEmpleado = 3 });
            listaCargosEmpleados.Add(new cargos_empleados { IdCargo = 3, IdEmpleado = 4 });

            this.dataContext.cargos_empleados.InsertAllOnSubmit(listaCargosEmpleados);

            this.dataContext.SubmitChanges();

            this.Principal.ItemsSource = this.dataContext.cargos_empleados;
            
        }

        public void ActualizarEmpleado()
        {
            empleados empleado = this.dataContext.empleados.First(emp => emp.Nombre.Equals("Emma"));
            empleado.Nombre = "Emma Victor";

            this.dataContext.SubmitChanges();

            this.Principal.ItemsSource = this.dataContext.empleados;
        }

        public void EliminarEmpleado()
        {
            empleados empleado = this.dataContext.empleados.First(emp => emp.Nombre.Equals("Juan"));

            this.dataContext.empleados.DeleteOnSubmit(empleado);
            this.dataContext.SubmitChanges();

            this.Principal.ItemsSource = this.dataContext.empleados;
        }
    }
}
