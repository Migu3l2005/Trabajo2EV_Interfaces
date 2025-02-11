using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System;
using System.Printing;

namespace Proyecto_2EV
{
  
    public partial class MainWindow : Window
    {
        private conexiones conexion;
        public MainWindow()
        {
            InitializeComponent();
            conexion = new conexiones();

        }

        public void loggin(object sender, RoutedEventArgs e) {
            if (conexion.comprobarUsuario(usuario.Text, contraseña.Password)==false)
            {

                mensajeError.Text = "Nombre de usuario o contraseña incorrecta";

            }
            else {
                this.Close();
            }

        }

        private void MinimizarVentana(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CerrarVentana(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }



    }
}