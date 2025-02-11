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
using static System.Collections.Specialized.BitVector32;

namespace Proyecto_2EV
{
    public partial class Ventana2 : Window
    {
        Inicio inicio=new Inicio();
        Modificar modificar=new Modificar();
        Borrar borrar=new Borrar();
        Agregar agregar=new Agregar();
        conexiones conexion;

        public Ventana2()
        {   
            InitializeComponent();
            ContentFrame.Navigate(inicio);
            conexion=new conexiones();
        }
        private void inicioClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Inicio());
        }

        private void modificarClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate( new Modificar());
        }

        private void agregarClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Agregar());
        }

        private void borrarClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Borrar());
        }

        private void cerrarSesion(object sender, RoutedEventArgs e)
        {
            conexion.cerrarSesion(this);
        }

    }
}
