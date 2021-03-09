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
    public partial class Form_Beneficiarios_Beneficiarios_Modificar : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Beneficiarios_Beneficiarios_Modificar()
        {
            InitializeComponent();

            disenioIncial();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonActualizar.MouseEnter += OnMouseEnterbotonActualizar;
            botonActualizar.MouseLeave += OnMouseLeavebotonActualizar;
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
            
            comboBoxTipo.SelectedIndex = 0;

            dateTimeNacimiento.Enabled = false;
            checkBoxMujer.Enabled = false;
            checkBoxHombre.Enabled = false;
            comboBoxTipo.Enabled = false;
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

        private bool validarEntradas()
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
            // Validar campo nombre familiar
            if (textBoxFamiliar.Text.Length > 120 || textBoxFamiliar.Text.Length == 0)
            {
                MessageBox.Show("Campo nombre de familiar tiene que ser menor a 120 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex nfr = new Regex(@"^[A-Za-z\sñÑáéíóú]+$");
            if (!nfr.IsMatch(textBoxFamiliar.Text))
            {
                MessageBox.Show("Nombre de familiar no válido, solo se permite el uso de letras y espacios",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            // Validar campo domicilio familiar
            if (textBoxDomicilio.Text.Length > 120 || textBoxDomicilio.Text.Length == 0)
            {
                MessageBox.Show("Campo domicilio tiene que ser menor a 120 caracteres y no estar vacío", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex domr = new Regex(@"^[A-Za-z0-9\s#ñÑáéíóú]+$");
            if (!domr.IsMatch(textBoxDomicilio.Text))
            {
                MessageBox.Show("Domicilio de familiar no válido, solo se permite el uso de letras, números," +
                    " espacios y el símbolo #",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            //Validar teléfono y que solo se utilicen números
            if (textBoxTel.Text.Length != 10 && textBoxTel.Text.Length != 0)
            {
                MessageBox.Show("Favor de introducir 10 números para el campo teléfono o dejar en blanco", "Advertencia",
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
            // Validar que la cuota no sea mayor a 20 caracteres
            if (textBoxCuota.Text.Length > 20 || textBoxCuota.Text.Length == 0)
            {
                MessageBox.Show("Campo Cargo tiene que ser menor a 20 caracteres y no estar vacío", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Regex cuotar = new Regex(@"^\d{1,20}$");
            if (!cuotar.IsMatch(textBoxCuota.Text))
            {
                MessageBox.Show("Cuota no válida", "Advertencia",
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
        private void OnMouseEnterbotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(101,33);
            botonActualizar.Text = "  Actualizar";
        }
        private void OnMouseLeavebotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(91,33);
            botonActualizar.Text = " Actualizar";
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

                        dateTimeNacimiento.Enabled = true;
                        checkBoxHombre.Enabled = true;
                        checkBoxMujer.Enabled = true;
                        comboBoxTipo.Enabled = true;
                        textBoxFamiliar.Enabled = true;
                        textBoxDomicilio.Enabled = true;
                        textBoxTel.Enabled = true;
                        textBoxCuota.Enabled = true;

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

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (validarEntradas())
            {
                try
                {
                    MySqlCommand act = new MySqlCommand("UPDATE beneficiarios SET Fecha_Nacimiento_B = @fecha_naci, " +
                        "Sexo_B = @sexo, Tipo_B = @tipo, Nombre_Fam_Responsable_B = @nom_fam, Domicilio_Fam_Responsable_B = @dom_fam,"+
                        "Telefono_Fam_Responsable_B=@tel_fam, Cuota_Mensual_B = @cuota "+
                        " WHERE Nombres_B = @nombre AND Apellido_1_B = @ap AND Apellido_2_B = @am AND Fecha_Baja_B IS NULL", conexion);

                    conexion.Open();

                        act.Parameters.AddWithValue("@ap", textBoxAP.Text);
                        act.Parameters.AddWithValue("@am", textBoxAM.Text);
                        act.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        act.Parameters.AddWithValue("@fecha_naci",dateTimeNacimiento.Value.Date);
                        if (comboBoxTipo.SelectedIndex == 0)
                            act.Parameters.AddWithValue("@tipo", "0");
                        else if (comboBoxTipo.SelectedIndex == 1)
                            act.Parameters.AddWithValue("@tipo", "1");
                        else
                            act.Parameters.AddWithValue("@tipo", "2");

                        if(checkBoxHombre.Checked==true)
                            act.Parameters.AddWithValue("@sexo","Hombre");
                        else
                            act.Parameters.AddWithValue("@sexo","Mujer");

                        act.Parameters.AddWithValue("@nom_fam", textBoxFamiliar.Text);
                        act.Parameters.AddWithValue("@dom_fam", textBoxDomicilio.Text);
                        act.Parameters.AddWithValue("@tel_fam", textBoxTel.Text);
                        act.Parameters.AddWithValue("@cuota", textBoxCuota.Text);


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
            disenioIncial();
        }

        private void CheckBoxHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHombre.Checked == true)
                checkBoxMujer.Checked = false;
            else if (checkBoxHombre.Checked == false && checkBoxMujer.Checked == false)
                checkBoxHombre.Checked = true;
        }

        private void CheckBoxMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMujer.Checked == true)
                checkBoxHombre.Checked = false;
            if (checkBoxMujer.Checked == false && checkBoxHombre.Checked == false)
                checkBoxMujer.Checked = true;
        }
    }
}
