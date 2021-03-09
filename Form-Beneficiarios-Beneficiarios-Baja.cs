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
    public partial class Form_Beneficiarios_Beneficiarios_Baja : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Beneficiarios_Beneficiarios_Baja()
        {
            InitializeComponent();

            disenioIncial();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonBaja.MouseEnter += OnMouseEnterbotonBaja;
            botonBaja.MouseLeave += OnMouseLeavebotonBaja;

        }

        #region Diseño inicial y validación de datos
        private void disenioIncial()
        {
            textBoxFamiliar.Text = "";
            textBoxNombre.Text = "";
            textBoxDomicilio.Text = "";
            textBoxCuota.Text = "";
            textBoxTel.Text = "";
            textBoxAM.Text = "";
            textBoxAP.Text = "";
            
            comboBoxTipo.Enabled = false;
            dateTimeNacimiento.Enabled = false;
            checkBoxHombre.Enabled = false;
            checkBoxMujer.Enabled = false;
            textBoxFamiliar.Enabled = false;
            textBoxDomicilio.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxCuota.Enabled = false;

        }
        
        private bool validarNombres()
        {
            // Validar campo nombre y que solo se utilicen letras y espacios
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
            //Validar apellido paterno y que solo se utilicen letras y espacios
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
            //Validar apellido materno y que solo se utilicen letras y espacios
            if (textBoxAM.Text.Length > 40)
            {
                MessageBox.Show("Campo Apellido materno tiene que ser menor a 40 caracteres", "Advertencia",
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
        #endregion

        #region Animacion de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(101,33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(91,33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonBaja(object sender, EventArgs e)
        {
            botonBaja.Size = new Size(101,33);
            botonBaja.Text = " Dar de baja";
        }
        private void OnMouseLeavebotonBaja(object sender, EventArgs e)
        {
            botonBaja.Size = new Size(91,33);
            botonBaja.Text = "Dar de baja";
        }
        #endregion

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (validarNombres())
            {
                try
                {
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM beneficiarios WHERE Nombres_B = @nombre AND " +
                        "Apellido_1_B = @ap AND Apellido_2_B = @am AND Estatus_B = 1", conexion);

                    conexion.Open();

                    buscar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                    buscar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                    buscar.Parameters.AddWithValue("@am", textBoxAM.Text);

                    MySqlDataReader registro = buscar.ExecuteReader();

                    if (registro.Read())
                    {


                        if (registro["Sexo_B"].ToString() == "Hombre")
                            checkBoxHombre.Checked = true;
                        else
                            checkBoxMujer.Checked = true;

                        if (registro["Tipo_B"].ToString() == "0")
                            comboBoxTipo.SelectedIndex = 0;
                        else if (registro["Tipo_B"].ToString() == "1")
                            comboBoxTipo.SelectedIndex = 1;
                        else if (registro["Tipo_B"].ToString() == "2")
                            comboBoxTipo.SelectedIndex = 2;

                        dateTimeNacimiento.Value = DateTime.Parse(registro["Fecha_Nacimiento_B"].ToString());
                        textBoxFamiliar.Text = registro["Nombre_Fam_Responsable_B"].ToString();
                        textBoxDomicilio.Text = registro["Domicilio_Fam_Responsable_B"].ToString();
                        textBoxTel.Text = registro["Telefono_Fam_Responsable_B"].ToString();
                        textBoxCuota.Text = registro["Cuota_Mensual_B"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        disenioIncial();
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
            if(textBoxFamiliar.Text == "")
                MessageBox.Show("Buscar registro a eliminar...", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar este registro?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                    try
                    {
                        MySqlCommand eliminar = new MySqlCommand("UPDATE beneficiarios SET Estatus_B = 0, " +
                            "Fecha_Baja_B = @fecha " +
                            "WHERE Nombres_B = @nombre AND Apellido_1_B = @ap AND Apellido_2_B = @am AND " +
                            "Estatus_B = 1", conexion);

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

                disenioIncial();
            }
        }
    }
}
