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
    public partial class Form_Organigrama_Directorio_Modificar : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Directorio_Modificar()
        {
            InitializeComponent();

            disenioInicial();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;

            botonModificar.MouseEnter += OnMouseEnterbotonModificar;
            botonModificar.MouseLeave += OnMouseLeavebotonModificar;
        }

        #region Diseño inicial y validar entradas

        private bool validarNombres()
        {
            // Validar campo nombre, longitud y solo letras y espacios
            if (textBoxNombre.Text.Length > 50 || textBoxNombre.Text.Length == 0)
            {
                MessageBox.Show("Campo nombre tiene que ser menor a 50 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex nombr = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!nombr.IsMatch(textBoxNombre.Text))
            {
                MessageBox.Show("Nombre no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar apellido paterno
            if (textBoxAP.Text.Length > 40 || textBoxAP.Text.Length == 0)
            {
                MessageBox.Show("Campo Apellido paterno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex apr = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!apr.IsMatch(textBoxAP.Text))
            {
                MessageBox.Show("Apellido paterno no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar apellido materno
            if (textBoxAM.Text.Length > 40)
            {
                MessageBox.Show("Campo Apellido materno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex amr = new Regex(@"^[A-Za-z\sñÑáéíóú]*$");
            if (!amr.IsMatch(textBoxAM.Text))
            {
                MessageBox.Show("Apellido materno no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private bool validarEntradas()
        {
            // Validar campo nombre, longitud y solo letras y espacios
            if (textBoxNombre.Text.Length > 50 || textBoxNombre.Text.Length == 0)
            {
                MessageBox.Show("Campo nombre tiene que ser menor a 50 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex nombr = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!nombr.IsMatch(textBoxNombre.Text))
            {
                MessageBox.Show("Nombre no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar apellido paterno
            if (textBoxAP.Text.Length > 40 || textBoxAP.Text.Length == 0)
            {
                MessageBox.Show("Campo Apellido paterno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex apr = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!apr.IsMatch(textBoxAP.Text))
            {
                MessageBox.Show("Apellido paterno no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar apellido materno
            if (textBoxAM.Text.Length > 40)
            {
                MessageBox.Show("Campo Apellido materno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex amr = new Regex(@"^[A-Za-z\sñÑáéíóú]*$");
            if (!amr.IsMatch(textBoxAM.Text))
            {
                MessageBox.Show("Apellido materno no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar campo cargo
            if (textBoxCargo.Text.Length > 40 || textBoxCargo.Text.Length == 0)
            {
                MessageBox.Show("Campo cargo tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex cargo = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!cargo.IsMatch(textBoxCargo.Text))
            {
                MessageBox.Show("Cargo no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar email
            if (textBoxEmail.Text.Length > 128)
            {
                MessageBox.Show("Campo Apellido materno tiene que ser menor a 128 caracteres", "Advertencia",
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
            //Validar teléfono
            if (textBoxTel.Text.Length != 10 && textBoxTel.Text.Length != 0)
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
            return true;
        }
        private void disenioInicial()
        {
            textBoxNombre.Text = "";
            textBoxAP.Text = "";
            textBoxAM.Text = "";
            textBoxCargo.Text = "";
            textBoxTel.Text = "";
            textBoxEmail.Text = "";

            textBoxCargo.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxEmail.Enabled = false;
        }
        #endregion

        #region Animación de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(101, 33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(91, 33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonModificar(object sender, EventArgs e)
        {
            botonModificar.Size = new Size(101, 33);
            botonModificar.Text = "  Actualizar";
        }
        private void OnMouseLeavebotonModificar(object sender, EventArgs e)
        {
            botonModificar.Size = new Size(91, 33);
            botonModificar.Text = " Actualizar";
        }
        #endregion
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (validarNombres())
            {
                try
                {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM directorio WHERE Nombres_D = @nombre AND " +
                        "Apellido_1_D = @ap AND Apellido_2_D = @am AND Fecha_Baja_D IS NULL", conexion);
                    conexion.Open();

                    buscar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    buscar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                    buscar.Parameters.AddWithValue("@am", textBoxAM.Text);

                    MySqlDataReader registro = buscar.ExecuteReader();

                    if (registro.Read())
                    {
                        textBoxCargo.Text = registro["Cargo_D"].ToString();
                        textBoxTel.Text = registro["Telefono_D"].ToString();
                        textBoxEmail.Text = registro["Email_D"].ToString();

                        textBoxCargo.Enabled = true;
                        textBoxTel.Enabled = true;
                        textBoxEmail.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        disenioInicial();
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    MySqlCommand act = new MySqlCommand("UPDATE directorio SET Cargo_D = @cargo, " +
                        "Telefono_D = @tel, Email_D = @email WHERE Nombres_D = @nombre AND Apellido_1_D = @ap AND Apellido_2_D = @am AND Fecha_Baja_D IS NULL", conexion);

                    conexion.Open();

                    act.Parameters.AddWithValue("@cargo", textBoxCargo.Text);
                    act.Parameters.AddWithValue("@tel", textBoxTel.Text);
                    act.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    act.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    act.Parameters.AddWithValue("@ap", textBoxAP.Text);
                    act.Parameters.AddWithValue("@am", textBoxAM.Text);


                    act.ExecuteNonQuery();

                    conexion.Close();

                    MessageBox.Show("Registro actualizado");
                }
                catch
                {
                    MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            disenioInicial();
        }
    }
}
