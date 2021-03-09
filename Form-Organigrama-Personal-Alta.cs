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
    public partial class Form_Organigrama_Personal_Alta : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Personal_Alta()
        {
            InitializeComponent();

            disenioIncial();
            panelUniversidad.Visible = false;

            botonAgregar.MouseEnter += OnMouseEnterbotonAgregar;
            botonAgregar.MouseLeave += OnMouseLeavebotonAgregar;
        }

        #region  Diseño inicial y validacion de datos
        private void disenioIncial()
        {
            textBoxNomUniversidad.Text = "";
            textBoxCarrera.Text = "";
            textBoxAlumnosSer.Text = "";

            textBoxNombre.Text = "";
            textBoxAP.Text = "";
            textBoxAM.Text = "";
            textBoxCargo.Text = "";

            comboBoxBase.SelectedIndex = 0;
            comboBoxEventual.SelectedIndex = 0;
            comboBoxVoluntario.SelectedIndex = 0;
            comboBoxServicio.SelectedIndex = 0;

        }

        private bool validarEntradas()
        {
            //Si es una universidad solo se validan los textbox de la universidad
            if(checkBoxUniversidad.Checked == true)
            {
                // Validar que el nombre de la universidad no sea mayor a 50 caracteres y que solo se usen letras
                // y números
                if (textBoxNomUniversidad.Text.Length > 50 || textBoxNomUniversidad.Text.Length == 0)
                {
                    MessageBox.Show("Campo nombre tiene que ser menor a 50 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex nomr = new Regex(@"^[A-Za-z0-9\sñÑáéíóú]+$");
                if (!nomr.IsMatch(textBoxNomUniversidad.Text))
                {
                    MessageBox.Show("Nombre no válido, solo se permite el uso de letras, números y espacios",
                        "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
                // Validar que la carrera no sea mayor a 20 caracteres y que solo se usen letras, números y espacios
                if (textBoxCarrera.Text.Length > 40 || textBoxCarrera.Text.Length == 0)
                {
                    MessageBox.Show("Campo carrea tiene que ser menor a 20 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex carrr = new Regex(@"^[A-Za-z0-9\sñÑáéíóú]+$");
                if (!carrr.IsMatch(textBoxCarrera.Text))
                {
                    MessageBox.Show("Nombre de carrera no válida, solo se permite el uso de letras, números y espacios",
                        "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
                // Validar que el servicio solacial no sea mayor a 10 caracteres y solo numeros
                if (textBoxAlumnosSer.Text.Length > 3 || textBoxAlumnosSer.Text.Length == 0)
                {
                    MessageBox.Show("Campo Servicio social tiene que ser menor a 3 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex serr = new Regex(@"^\d{1,3}$");
                if (!serr.IsMatch(textBoxAlumnosSer.Text))
                {
                    MessageBox.Show("Valor no válido de alumnos en servicio", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            else
            {
                // Validar que el nombre no sea mayor a 50 caracteres y solo se usen letras
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
                // Validar que el apellido paterno no sea mayor a 40 caracteres y solo se usen letras
                if (textBoxAP.Text.Length > 40 || textBoxAP.Text.Length == 0)
                {
                    MessageBox.Show("Campo Apellido Paterno tiene que ser menor a 40 caracteres y no estar vacío", "Advertencia",
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
                // Validar que el cargo no sea mayor a 20 caracteres y solo se usen letras
                if (textBoxCargo.Text.Length > 20 || textBoxCargo.Text.Length == 0)
                {
                    MessageBox.Show("Campo Cargo tiene que ser menor a 20 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex cargo = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
                if (!amr.IsMatch(textBoxCargo.Text))
                {
                    MessageBox.Show("Cargo no válido, solo se permite el uso de letras y espacios",
                        "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Animacion del boton
        private void OnMouseEnterbotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(99,33);
            botonAgregar.Text = " Dar de alta";
        }
        private void OnMouseLeavebotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(89,33);
            botonAgregar.Text = "Dar de alta";
        }
        #endregion

        private void CheckBoxUniversidad_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxUniversidad.Checked == true)
            {
                panelPersonal.Visible = false;
                panelUniversidad.Visible = true;
            }
            else
            {
                panelPersonal.Visible = true;
                panelUniversidad.Visible = false;
            }
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                if (checkBoxUniversidad.Checked == true)
                {
                    try
                    {
                        /*AGREGE COMO PARAMETRO Nombre_UNI_P DONDE SI ES UNA UNIVERSIDAD EL REGISTRO, MANDA UN 'Si'
                        CON EL QUE LA BASE SE VA AUXILIAR EN LA GENERACION DEL ARCHIVO PERSONAL*/
                        MySqlCommand agregar = new MySqlCommand("INSERT INTO personal (Fecha_P, Nombres_P, Cargo_P," +
                            "Servicio_Social_P, Estatus_P, Nombre_UNI_P) " +
                            "VALUES(@fecha, @nombre, @carrera, @servicio, 1, 'SI')", conexion);

                        conexion.Open();

                        agregar.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                        agregar.Parameters.AddWithValue("@nombre", textBoxNomUniversidad.Text);
                        agregar.Parameters.AddWithValue("@carrera", textBoxCarrera.Text);
                        agregar.Parameters.AddWithValue("@servicio", textBoxAlumnosSer.Text);

                        agregar.ExecuteNonQuery();

                        conexion.Close();

                        MessageBox.Show("Universidad registrada");
                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    try
                    {
                        MySqlCommand agregar = new MySqlCommand("INSERT INTO personal (Fecha_P, Apellido_1_P," +
                            "Apellido_2_P, Nombres_P, Cargo_P, Base_P, Eventual_P, Voluntario_P, " +
                            "Servicio_Social_P, Estatus_P) VALUES(@fecha, @ap," +
                            "@am, @nombre, @cargo, @base, @eventual, @volu, @servicio, 1)", conexion);

                        conexion.Open();

                        agregar.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                        agregar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                        agregar.Parameters.AddWithValue("@am", textBoxAM.Text);
                        agregar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        agregar.Parameters.AddWithValue("@cargo", textBoxCargo.Text);
                        if (comboBoxBase.SelectedIndex == 0)
                            agregar.Parameters.AddWithValue("@base", "1");
                        else
                            agregar.Parameters.AddWithValue("@base", "0");
                        if (comboBoxEventual.SelectedIndex == 0)
                            agregar.Parameters.AddWithValue("@eventual", "1");
                        else
                            agregar.Parameters.AddWithValue("@eventual", "0");
                        if (comboBoxVoluntario.SelectedIndex == 0)
                            agregar.Parameters.AddWithValue("@volu", "1");
                        else
                            agregar.Parameters.AddWithValue("@volu", "0");
                        if (comboBoxServicio.SelectedIndex == 0)
                            agregar.Parameters.AddWithValue("@servicio", "1");
                        else
                            agregar.Parameters.AddWithValue("@servicio", "0");

                        agregar.ExecuteNonQuery();

                        conexion.Close();

                        MessageBox.Show("Personal registrado");

                    }
                    catch
                    {
                        MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            disenioIncial();
        }
    }
}
