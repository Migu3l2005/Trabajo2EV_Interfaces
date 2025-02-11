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

namespace Proyecto_2EV
{
    public partial class Borrar : Page
    {
        conexiones conexion;

        public Borrar()
        {   
            conexion = new conexiones();
            InitializeComponent();
            mostrarTabla();        
        }

        public void borrarObjeto(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ID.Text, out int id))
            {
                conexion.borrarProducto(id, this);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void mostrarTabla()
        {
            conexion.tablaProductos4(this);
        }

         private void MinimizarVentana(object sender, MouseButtonEventArgs e)
        {
            Window ventana = Window.GetWindow(this);
            if (ventana != null)
            {
                ventana.WindowState = WindowState.Minimized;
            }
        }

        private void CerrarVentana(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
