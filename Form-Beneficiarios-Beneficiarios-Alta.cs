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
    public partial class Form_Beneficiarios_Beneficiarios_Alta : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Beneficiarios_Beneficiarios_Alta()
        {
            InitializeComponent();

            botonAlta.MouseEnter += OnMouseEnterbotonAlta;
            botonAlta.MouseLeave += OnMouseLeavebotonAlta;
            disenioIncial();

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
            checkBoxHombre.Checked = true;
            comboBoxTipo.SelectedIndex = 0;
        }

        private bool validarEntradas()
        {
            // Validar campo nombre y que solo se utilicen letras y espacios
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

        #region Animacion del boton
        private void OnMouseEnterbotonAlta(object sender, EventArgs e)
        {
            botonAlta.Size = new Size(101,33);
            botonAlta.Text = " Dar de alta";
        }
        private void OnMouseLeavebotonAlta(object sender, EventArgs e)
        {
            botonAlta.Size = new Size(91,33);
            botonAlta.Text = "Dar de alta";
        }
        #endregion


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

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            if(validarEntradas()){
                try{
                        MySqlCommand agregar = new MySqlCommand("INSERT INTO beneficiarios (Fecha_B, Apellido_1_B, " +
                        "Apellido_2_B, Nombres_B, Fecha_Nacimiento_B, Sexo_B, Tipo_B,Nombre_Fam_Responsable_B,"+
                        "Domicilio_Fam_Responsable_B,Telefono_Fam_Responsable_B,Cuota_Mensual_B,Estatus_B) "+
                        "VALUES (@fecha, @ap, @am, @nombre," +
                        "@fecha_naci, @sexo, @tipo,@nom_fam,@dom_fam,@tel_fam,@cuota,'1')", conexion);
                        
                        conexion.Open();

                        agregar.Parameters.AddWithValue("@fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                        agregar.Parameters.AddWithValue("@ap", textBoxAP.Text);
                        agregar.Parameters.AddWithValue("@am", textBoxAM.Text);
                        agregar.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        agregar.Parameters.AddWithValue("@fecha_naci",dateTimeNacimiento.Value.Date);
                        if (comboBoxTipo.SelectedIndex == 0)
                            agregar.Parameters.AddWithValue("@tipo", "0");
                        else if (comboBoxTipo.SelectedIndex == 1)
                            agregar.Parameters.AddWithValue("@tipo", "1");
                        else
                            agregar.Parameters.AddWithValue("@tipo", "2");

                        if(checkBoxHombre.Checked==true)
                            agregar.Parameters.AddWithValue("@sexo","Hombre");
                        else
                            agregar.Parameters.AddWithValue("@sexo","Mujer");

                        agregar.Parameters.AddWithValue("@nom_fam", textBoxFamiliar.Text);
                        agregar.Parameters.AddWithValue("@dom_fam", textBoxDomicilio.Text);
                        agregar.Parameters.AddWithValue("@tel_fam", textBoxTel.Text);
                        agregar.Parameters.AddWithValue("@cuota", textBoxCuota.Text);
                                       


                        agregar.ExecuteNonQuery();

                        conexion.Close();
                        
                        MessageBox.Show("Registro agregado");
                }
                catch{
                     MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            disenioIncial();
        }
    }
}
