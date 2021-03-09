using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
// Librería para la conexión de la base de datos (se tiene que descargar el paquete de MySQL)
using MySql.Data.MySqlClient;

namespace interfazModernaONG
{
    public partial class Form_Organigrama_DatosGenerales_Modificar : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_DatosGenerales_Modificar()
        {
            InitializeComponent();

            disenioInicial();

            //Animación de transiciones del botón Actualizar
            botonActualizar.MouseEnter += OnMouseEnterbotonActualizar;
            botonActualizar.MouseLeave += OnMouseLeavebotonActualizar;
        }

        #region Validar las entradas de los textbox, cargar datos y el diseño inicial del form

        //Función que valida las entradas de los textbox
        private bool validarEntradas()
        {
            //Validar nombre, hasta ahora solo que la longitud sea menor a 128 y que sea válido
            if (textBoxNombre.Text.Length > 128)
            {
                MessageBox.Show("Campo nombre tiene que ser menor a 128 caracteres", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex nomr = new Regex(@"^[A-Za-z0-9\s\.ñÑáéíóú]+$");
            if (!nomr.IsMatch(textBoxNombre.Text))
            {
                MessageBox.Show("Nombre no válido, solo se permite el uso de letras, números, espacios" +
                    " y el símbolo .", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar clave única, longitud no mayor a 20 y solo letras y números
            if (textBoxClave.Text.Length > 20)
            {
                MessageBox.Show("Campo Clave única no válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex cur = new Regex(@"^[A-Za-z0-9\sñÑáéíóú]+$");
            if (!cur.IsMatch(textBoxClave.Text))
            {
                MessageBox.Show("Clave no válida, solo se permite el uso de letras, números y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar código postal, que longitud no sea mayor a 5 y que solo se utilicen números
            if (textBoxCP.Text.Length != 5)
            {
                MessageBox.Show("Longitud de código postal no válida", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex cpr = new Regex(@"^\d{5}$");
            if (!cpr.IsMatch(textBoxCP.Text))
            {
                MessageBox.Show("Código postal no válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar domicilio, por ahora que longitud no sea mayor a 128 y que solo use letras números y espacios
            if (textBoxDomi.Text.Length > 128)
            {
                MessageBox.Show("Campo domicilio tiene que ser menor a 128 caracteres", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex domr = new Regex(@"^[A-Za-z0-9\s#ñÑáéíóú]+$");
            if (!domr.IsMatch(textBoxDomi.Text))
            {
                MessageBox.Show("Domicilio no válido, solo se permite el uso de letras, números, espacios" +
                    " y el símbolo #", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar teléfono, que solo se usen números y que su longitud sea de 10
            if (textBoxTel.Text.Length != 10)
            {
                MessageBox.Show("Favor de introducir 10 números para el campo teléfono", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex telr = new Regex(@"^\d{10}$");
            if (!telr.IsMatch(textBoxTel.Text))
            {
                MessageBox.Show("Número telefónico no válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar celular, que solo se usen números y que su longitud sea de 10 o esté vacío
            if (textBoxCel.Text.Length != 10 && textBoxCel.Text.Length != 0)
            {
                MessageBox.Show("Favor de introducir 10 números para el campo celular o dejar en blanco", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex celr = new Regex(@"^\d{10}$");
            if (!celr.IsMatch(textBoxCel.Text) && textBoxCel.Text.Length != 0)
            {
                MessageBox.Show("Número celular no válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar Email, por ahora que longitud no sea mayor a 64 y que el correo sea válido
            if (textBoxEmail.Text.Length > 64)
            {
                MessageBox.Show("Campo Email tiene que ser menor a 64 caracteres", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex emailr = new Regex(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if (!emailr.IsMatch(textBoxEmail.Text))
            {
                MessageBox.Show("Email no válido", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private void cargarDatos()
        {
            // variable donde se genera la consulta SQL
            MySqlCommand comando = new MySqlCommand("Select * FROM datos_generales", conexion);
            //Se abre la conexion
            conexion.Open();
            //Variable que lee los datos de la consulta SQL
            MySqlDataReader registro = comando.ExecuteReader();

            // Si hay datos en la tabla los guarda, en caso contrario no muestran nada los textbox
            if (registro.Read())
            {
                textBoxNombre.Text = registro["Nombre_ONG"].ToString();
                textBoxClave.Text = registro["Clave_Unica_ONG"].ToString();
                textBoxCP.Text = registro["Codigo_Postal_ONG"].ToString();
                textBoxDomi.Text = registro["Direccion_ONG"].ToString();
                textBoxTel.Text = registro["Telefono_ONG"].ToString();
                textBoxCel.Text = registro["Celular_ONG"].ToString();
                textBoxEmail.Text = registro["Email_ONG"].ToString();
            }
            else
            {
                textBoxNombre.Text = "";
                textBoxClave.Text = "";
                textBoxCP.Text = "";
                textBoxDomi.Text = "";
                textBoxTel.Text = "";
                textBoxCel.Text = "";
                textBoxEmail.Text = "";
            }
            conexion.Close();
        }

        // La función disenioInicial carga los datos de la base de datos y los muestra en los textbox
        private void disenioInicial()
        {
            try
            {
                cargarDatos();
            }
            catch
            {
                textBoxNombre.Text = "";
                textBoxClave.Text = "";
                textBoxCP.Text = "";
                textBoxDomi.Text = "";
                textBoxTel.Text = "";
                textBoxCel.Text = "";
                textBoxEmail.Text = "";

                MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Animación del botón actualizar
        private void OnMouseEnterbotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(95, 43);
            botonActualizar.Text = " Actualizar";
        }
        private void OnMouseLeavebotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(85,33);
            botonActualizar.Text = "Actualizar";
        }

        #endregion

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    //Crear las variables necesarias para la conexión
                    MySqlCommand comando = new MySqlCommand("Select * FROM datos_generales", conexion);
                    conexion.Open();
                    MySqlDataReader registro = comando.ExecuteReader();

                    // Esto sirve para validar si ya están guardados los datos generales de la ONG en la tabla
                    // debido a que esta tabla solo almacena un solo registro, por lo que si ya está guardado se
                    // actualiza el registro, en caso contrario se crea el registro
                    if (registro.Read())
                    {
                        // Se cierra la conexión para reutilizar la variable de conexion
                        conexion.Close();

                        // Se actualizanlos datos actuales de la tabla
                        MySqlCommand actualizar = new MySqlCommand("UPDATE datos_generales SET Nombre_ONG = @nombre, " +
                            " Clave_Unica_ONG = @clave, Codigo_Postal_ONG = @cp, Direccion_ONG = @dir," +
                            "Telefono_ONG = @tel, Celular_ONG = @cel, Email_ONG = @email", conexion);
                        conexion.Open();

                        actualizar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        actualizar.Parameters.AddWithValue("@clave", textBoxClave.Text);
                        actualizar.Parameters.AddWithValue("@cp", textBoxCP.Text);
                        actualizar.Parameters.AddWithValue("@dir", textBoxDomi.Text);
                        actualizar.Parameters.AddWithValue("@tel", textBoxTel.Text);
                        actualizar.Parameters.AddWithValue("@cel", textBoxCel.Text);
                        actualizar.Parameters.AddWithValue("@email", textBoxEmail.Text);

                        actualizar.ExecuteNonQuery();

                    }
                    else
                    {
                        // Se cierra la conexión para reutilizar la variable de conexion
                        conexion.Close();

                        MySqlCommand agregar = new MySqlCommand("INSERT INTO datos_generales VALUES(@Nombre_ONG, " +
                            "@Clave_Unica_ONG, @Codigo_Postal_ONG, @Direccion_ONG, @Telefono_ONG, @Celular_ONG," +
                            "@Email_ONG)", conexion);

                        conexion.Open();

                        agregar.Parameters.AddWithValue("@Nombre_ONG", textBoxNombre.Text);
                        agregar.Parameters.AddWithValue("@Clave_Unica_ONG", textBoxClave.Text);
                        agregar.Parameters.AddWithValue("@Codigo_Postal_ONG", textBoxCP.Text);
                        agregar.Parameters.AddWithValue("@Direccion_ONG", textBoxDomi.Text);
                        agregar.Parameters.AddWithValue("@Telefono_ONG", textBoxTel.Text);
                        agregar.Parameters.AddWithValue("@Celular_ONG", textBoxCel.Text);
                        agregar.Parameters.AddWithValue("@Email_ONG", textBoxEmail.Text);

                        agregar.ExecuteNonQuery();
                    }
                    MessageBox.Show("Registro actualizado");
                    conexion.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            cargarDatos();
        }
    }
}
