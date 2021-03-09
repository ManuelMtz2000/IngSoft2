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
    public partial class Form_Organigrama_Personal_Baja : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Personal_Baja()
        {
            InitializeComponent();

            disenioInicial();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonBaja.MouseEnter += OnMouseEnterbotonBaja;
            botonBaja.MouseLeave += OnMouseLeavebotonBaja;
        }

        #region Diseño inicial y validar entradas

        private bool validarEntradas()
        {
            // Validar que el nombre no sea mayor a 50 caracteres y solo se usen letras
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
            // Validar que el apellido paterno no sea mayor a 40 caracteres y solo se usen letras
            if (textBoxAP.Text.Length > 40)
            {
                MessageBox.Show("Campo Apellido Paterno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex apr = new Regex(@"^[A-Za-z\sñÑáéíóú]*$");
            if (!apr.IsMatch(textBoxAP.Text))
            {
                MessageBox.Show("Apellido paterno no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar que el apellido materno no sea mayor a 40 caracteres
            if (textBoxAM.Text.Length > 40)
            {
                MessageBox.Show("Campo Apellido Materno tiene que ser menor a 50 caracteres", "Advertencia",
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

        private void disenioInicial()
        {
            textBoxNombre.Text = "";
            textBoxAP.Text = "";
            textBoxAM.Text = "";
            textBoxCargo.Text = "";
            textBoxBase.Text = "";
            textBoxEventual.Text = "";
            textBoxVoluntario.Text = "";
            textBoxServicio.Text = "";


            textBoxCargo.Enabled = false;
            textBoxBase.Enabled = false;
            textBoxEventual.Enabled = false;
            textBoxVoluntario.Enabled = false;
            textBoxServicio.Enabled = false;
        }

        #endregion

        #region Animacion de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(99,33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(89,33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonBaja(object sender, EventArgs e)
        {
            botonBaja.Size = new Size(105,33);
            botonBaja.Text = " Dar de baja";
        }
        private void OnMouseLeavebotonBaja(object sender, EventArgs e)
        {
            botonBaja.Size = new Size(95,33);
            botonBaja.Text = "Dar de baja";
        }
        #endregion

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM personal WHERE Nombres_P = @nombre AND " +
                        "Apellido_1_P = @ap AND Apellido_2_P = @am AND Fecha_Baja_P IS NULL", conexion);

                    conexion.Open();

                    buscar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    buscar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                    buscar.Parameters.AddWithValue("@am", textBoxAM.Text);

                    MySqlDataReader registro = buscar.ExecuteReader();

                    if (registro.Read())
                    {
                        if (textBoxAP.Text == "")
                        {
                            textBoxCargo.Text = registro["Cargo_P"].ToString();
                            textBoxBase.Text = "No";
                            textBoxEventual.Text = "No";
                            textBoxVoluntario.Text = "No";
                            textBoxServicio.Text = registro["Servicio_Social_P"].ToString();
                        }
                        else
                        {
                            textBoxCargo.Text = registro["Cargo_P"].ToString();

                            if (registro["Base_P"].ToString() == "0")
                                textBoxBase.Text = "No";
                            else
                                textBoxBase.Text = "Si";
                            if (registro["Eventual_P"].ToString() == "0")
                                textBoxEventual.Text = "No";
                            else
                                textBoxEventual.Text = "Si";
                            if (registro["Voluntario_P"].ToString() == "0")
                                textBoxVoluntario.Text = "No";
                            else
                                textBoxVoluntario.Text = "Si";
                            if (registro["Servicio_Social_P"].ToString() == "0")
                                textBoxServicio.Text = "No";
                            else
                                textBoxServicio.Text = "Si";
                        }
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

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                if (textBoxCargo.Text == "")
                    MessageBox.Show("Buscar registro a eliminar...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Desea eliminar este registro?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                        try
                        {
                            MySqlCommand eliminar = new MySqlCommand("UPDATE personal SET Estatus_P = 0, " +
                                "Fecha_Baja_P = @fecha WHERE Nombres_P = @nombre AND " +
                            "Apellido_1_P = @ap AND Apellido_2_P = @am", conexion);

                            conexion.Open();

                            eliminar.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                            eliminar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                            eliminar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                            eliminar.Parameters.AddWithValue("@am", textBoxAM.Text);

                            eliminar.ExecuteNonQuery();

                            conexion.Close();

                            MessageBox.Show("Registro eliminado");

                        }
                        catch
                        {
                            MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    else if (dialogResult == DialogResult.No)
                        MessageBox.Show("Operación cancelada");

                    disenioInicial();
                }
            }
        }
    }
}
