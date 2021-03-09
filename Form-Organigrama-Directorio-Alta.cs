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
    public partial class Form_Organigrama_Directorio_Alta : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Directorio_Alta()
        {
            InitializeComponent();
            disenioInicial();

            botonAgregar.MouseEnter += OnMouseEnterbotonAgregar;
            botonAgregar.MouseLeave += OnMouseLeavebotonAgregar;
        }

        #region Diseño inicial y validación de datos
        private void disenioInicial()
        {
            textBoxNombre.Text = "";
            textBoxAP.Text = "";
            textBoxAM.Text = "";
            textBoxCargo.Text = "";
            textBoxTel.Text = "";
            textBoxEmail.Text = "";

        }

        private bool validarEntradas()
        {
            // Validar campo nombre, longitud y solo letras y espacios
            if(textBoxNombre.Text.Length > 50 || textBoxNombre.Text.Length == 0)
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
        #endregion

        #region Animación del botón actualizar
        private void OnMouseEnterbotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(99, 43);
            botonAgregar.Text = " Dar de alta";
        }
        private void OnMouseLeavebotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(89, 33);
            botonAgregar.Text = "Dar de alta";
        }

        #endregion

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    MySqlCommand agregar = new MySqlCommand("INSERT INTO directorio (Fecha_D, Apellido_1_D, " +
                        "Apellido_2_D, Nombres_D, Cargo_D, Telefono_D, Email_D) VALUES (@fecha, @ap, @am, @nombre," +
                        "@cargo, @tel, @email)", conexion);

                    conexion.Open();

                    agregar.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                    agregar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                    agregar.Parameters.AddWithValue("@am", textBoxAM.Text);
                    agregar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    agregar.Parameters.AddWithValue("@cargo", textBoxCargo.Text);
                    agregar.Parameters.AddWithValue("@tel", textBoxTel.Text);
                    agregar.Parameters.AddWithValue("@email", textBoxEmail.Text);

                    agregar.ExecuteNonQuery();

                    conexion.Close();

                    MessageBox.Show("Registro agregado");
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
