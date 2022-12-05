using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion4
{
    class DatosUsuario : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value;
                OnPropertyChanged("NombreCompleto");
            }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value;
                OnPropertyChanged("NombreCompleto");
            }
        }
        public string NombreCompleto
        {
            get { return this.nombre + " " + this.apellido; }
            set { }
        }
    }
}
