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
    public partial class Modificar : Page
    {   
        conexiones conexion;
        public Modificar()
        {
            conexion = new conexiones();
            InitializeComponent();
            mostrarTabla();
        }

        public void mostrarTabla()
        {
            conexion.tablaProductos3(this);
        }

        public void modificarObjeto(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ID.Text, out int id))
            {
                conexion.modificarProducto(id, nombreProducto.Text, Categoria.Text, this);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
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
