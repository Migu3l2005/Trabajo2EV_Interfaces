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
   
    public partial class Inicio : Page
    {
        conexiones conexion;

        public Inicio()
        {
            
            InitializeComponent();
            conexion = new conexiones();    
            mostrarProductos();
        }

        public void mostrarProductos() {
            conexion.tablaProductos(this);
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
