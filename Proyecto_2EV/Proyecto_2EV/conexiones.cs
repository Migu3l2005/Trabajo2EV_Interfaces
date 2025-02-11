using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace Proyecto_2EV
{
    public class conexiones
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=root;database=northwind";

        public bool comprobarUsuario(string usuario, string contraseña)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT 1 FROM useraccounts WHERE Username=@Usuario AND Password=@Contraseña LIMIT 1;";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contraseña", contraseña);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Ventana2 ventana2 = new Ventana2();
                                ventana2.Show();
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la conexión: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            return false;
        }

        public void tablaProductos(Inicio inicio)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                
                    conexion.Open();
                    string query = "SELECT * FROM productos";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);
                        inicio.tabla.ItemsSource = dataTable.DefaultView;
                    }
           
                
            }
        }

        public void tablaProductos2(Agregar agregar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {

                conexion.Open();
                string query = "SELECT * FROM productos";
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                {
                    DataTable dataTable = new DataTable();
                    adaptador.Fill(dataTable);
                    agregar.tabla.ItemsSource = dataTable.DefaultView;
                }


            }
        }

        public void tablaProductos3(Modificar modificar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {

                conexion.Open();
                string query = "SELECT * FROM productos";
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                {
                    DataTable dataTable = new DataTable();
                    adaptador.Fill(dataTable);
                    modificar.tabla.ItemsSource = dataTable.DefaultView;
                }


            }
        }

        public void tablaProductos4(Borrar borrar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {

                conexion.Open();
                string query = "SELECT * FROM productos";
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                {
                    DataTable dataTable = new DataTable();
                    adaptador.Fill(dataTable);
                    borrar.tabla.ItemsSource = dataTable.DefaultView;
                }


            }
        }

        public void modificarProducto(int idProducto, string nuevoNombre, string nuevaCategoria, Modificar modificar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE productos SET Nombre = @nuevoNombre, Categoria = @nuevaCategoria WHERE ID = @idProducto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@nuevaCategoria", nuevaCategoria);
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto modificado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el ID especificado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }

                    tablaProductos3(modificar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void borrarProducto(int idProducto, Borrar borrar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM productos WHERE ID = @idProducto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el ID especificado", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }

                    tablaProductos4(borrar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void cerrarSesion(Window ventanaActual)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?",
                                                          "Cerrar sesión",
                                                          MessageBoxButton.YesNo,
                                                          MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    using (var conexion = new MySqlConnection(connectionString))
                    {
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                    }

                    MainWindow mainWindow= new MainWindow();
                    mainWindow.Show();

                    ventanaActual.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar sesión: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        public void meterProductos(string nombreProducto, string categoria,Agregar agregar)
        {
            using (var conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO productos (Nombre, Categoria) VALUES (@nombre, @categoria)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                    tablaProductos2(agregar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
