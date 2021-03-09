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
    public partial class Form_Organigrama_Personal_Modificar : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Personal_Modificar()
        {
            InitializeComponent();

            disenioInicial();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonActualizar.MouseEnter += OnMouseEnterbotonActualizar;
            botonActualizar.MouseLeave += OnMouseLeavebotonActualizar;
        }

        #region Diseño inicial y validar datos
        private void disenioInicial()
        {
            textBoxNombre.Text = "";
            textBoxAP.Text = "";
            textBoxAM.Text = "";
            textBoxCargo.Text = "";

            textBoxCargo.Enabled = false;
            textBoxServicio.Enabled = false;
            textBoxServicio.Visible = false;
            comboBoxBase.Enabled = false;
            comboBoxEventual.Enabled = false;
            comboBoxVoluntario.Enabled = false;
            comboBoxServicio.Enabled = false;
            comboBoxServicio.Visible = true;
        }

        private bool validarEntradas()
        {
            //Si es una universidad solo se validan los textbox de la universidad
            if (textBoxAP.Text == "")
            {
                // Validar que el nombre de la universidad no sea mayor a 50 caracteres y que solo se usen letras
                // y números
                if (textBoxNombre.Text.Length > 50 || textBoxNombre.Text.Length == 0)
                {
                    MessageBox.Show("Campo nombre tiene que ser menor a 50 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex nomr = new Regex(@"^[A-Za-z0-9\sñÑáéíóú]+$");
                if (!nomr.IsMatch(textBoxNombre.Text))
                {
                    MessageBox.Show("Nombre no válido, solo se permite el uso de letras, números y espacios",
                        "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
                // Validar que la carrera no sea mayor a 20 caracteres y que solo se usen letras, números y espacios
                if (textBoxCargo.Text.Length > 40 || textBoxCargo.Text.Length == 0)
                {
                    MessageBox.Show("Campo carrea tiene que ser menor a 20 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex carrr = new Regex(@"^[A-Za-z0-9\sñÑáéíóú]+$");
                if (!carrr.IsMatch(textBoxCargo.Text))
                {
                    MessageBox.Show("Nombre de carrera no válida, solo se permite el uso de letras, números y espacios",
                        "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
                // Validar que el servicio solacial no sea mayor a 10 caracteres y solo numeros
                if (textBoxServicio.Text.Length > 3 || textBoxServicio.Text.Length == 0)
                {
                    MessageBox.Show("Campo Servicio social tiene que ser menor a 3 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                Regex serr = new Regex(@"^\d{1,3}$");
                if (!serr.IsMatch(textBoxServicio.Text))
                {
                    MessageBox.Show("Valor no válido de alumnos en servicio", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            else
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
        private void OnMouseEnterbotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(105,33);
            botonActualizar.Text = "  Actualizar";
        }
        private void OnMouseLeavebotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(95,33);
            botonActualizar.Text = " Actualizar";
        }
        #endregion

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand buscar = new MySqlCommand("SELECT * FROM personal WHERE Nombres_P = @nombre AND " +
                    "Apellido_1_P = @ap AND Apellido_2_P = @am AND Estatus_P = 1", conexion);

                conexion.Open();

                buscar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                buscar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                buscar.Parameters.AddWithValue("@am", textBoxAM.Text);

                MySqlDataReader registro = buscar.ExecuteReader();

                if (registro.Read())
                {
                    if (textBoxAP.Text == "")
                    {
                        textBoxCargo.Enabled = true;
                        comboBoxServicio.Enabled = false;
                        comboBoxServicio.Visible = false;
                        textBoxServicio.Enabled = true;
                        textBoxServicio.Visible = true;
                        comboBoxBase.Enabled = false;
                        comboBoxBase.SelectedIndex = 1;
                        comboBoxEventual.Enabled = false;
                        comboBoxEventual.SelectedIndex = 1;
                        comboBoxVoluntario.Enabled = false;
                        comboBoxVoluntario.SelectedIndex = 1;

                        textBoxCargo.Text = registro["Cargo_P"].ToString();
                        textBoxServicio.Text = registro["Servicio_Social_P"].ToString();
                    }
                    else
                    {
                        textBoxCargo.Enabled = true;
                        comboBoxServicio.Enabled = true;
                        comboBoxServicio.Visible = true;
                        textBoxServicio.Enabled = false;
                        textBoxServicio.Visible = false;
                        comboBoxBase.Enabled = true;
                        comboBoxEventual.Enabled = true;
                        comboBoxVoluntario.Enabled = true;

                        textBoxCargo.Text = registro["Cargo_P"].ToString();
                        if (registro["Base_P"].ToString() == "0")
                            comboBoxBase.SelectedIndex = 1;
                        else
                            comboBoxBase.SelectedIndex = 0;
                        if (registro["Eventual_P"].ToString() == "0")
                            comboBoxEventual.SelectedIndex = 1;
                        else
                            comboBoxEventual.SelectedIndex = 0;
                        if (registro["Voluntario_P"].ToString() == "0")
                            comboBoxVoluntario.SelectedIndex = 1;
                        else
                            comboBoxVoluntario.SelectedIndex = 0;
                        if (registro["Servicio_Social_P"].ToString() == "0")
                            comboBoxServicio.SelectedIndex = 1;
                        else
                            comboBoxServicio.SelectedIndex = 0;
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
        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    if(textBoxAP.Text == "")
                    {
                        MySqlCommand act = new MySqlCommand("UPDATE personal SET Cargo_P = @carrera, " +
                            "Servicio_Social_P = @servicio WHERE  Nombres_P = @nombre AND " +
                        "Apellido_1_P = @ap AND Apellido_2_P = @am AND Estatus_P = 1", conexion);
                        conexion.Open();

                        act.Parameters.AddWithValue("@carrera", textBoxCargo.Text);
                        act.Parameters.AddWithValue("@servicio", textBoxServicio.Text);
                        act.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        act.Parameters.AddWithValue("@ap", textBoxAP.Text);
                        act.Parameters.AddWithValue("@am", textBoxAM.Text);

                        act.ExecuteNonQuery();

                        conexion.Close();

                        MessageBox.Show("Registro actualizado...");
                    }
                    else
                    {
                        MySqlCommand act = new MySqlCommand("UPDATE personal SET Cargo_P = @cargo, Base_P = @base, " +
                            "Eventual_P = @eventual, Voluntario_P = @vol, Servicio_Social_P = @servicio WHERE  Nombres_P = @nombre AND " +
                        "Apellido_1_P = @ap AND Apellido_2_P = @am AND Estatus_P = 1", conexion);

                        conexion.Open();
                        act.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        act.Parameters.AddWithValue("@ap", textBoxAP.Text);
                        act.Parameters.AddWithValue("@am", textBoxAM.Text);
                        act.Parameters.AddWithValue("@cargo", textBoxCargo.Text);
                        if(comboBoxBase.SelectedIndex == 0)
                            act.Parameters.AddWithValue("@base", "1");
                        else
                            act.Parameters.AddWithValue("@base", "0");
                        if (comboBoxEventual.SelectedIndex == 0)
                            act.Parameters.AddWithValue("@eventual", "1");
                        else
                            act.Parameters.AddWithValue("@eventual", "0");
                        if (comboBoxVoluntario.SelectedIndex == 0)
                            act.Parameters.AddWithValue("@vol", "1");
                        else
                            act.Parameters.AddWithValue("@vol", "0");
                        if (comboBoxServicio.SelectedIndex == 0)
                            act.Parameters.AddWithValue("@servicio", "1");
                        else
                            act.Parameters.AddWithValue("@servicio", "0");

                        act.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Registro actualizado...");
                    }
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
