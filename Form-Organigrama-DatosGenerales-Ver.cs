using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Librería para la conexión de la base de datos (se tiene que descargar el paquete de MySQL)
using MySql.Data.MySqlClient;

namespace interfazModernaONG
{
    public partial class Form_Organigrama_DatosGenerales_Ver : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_DatosGenerales_Ver()
        {
            InitializeComponent();

            disenioInicial();
        }

        // La función disenioInicial carga los datos de la base de datos y los muestra en los textbox
        private void disenioInicial()
        {
            textBoxNombre.Enabled = false;
            textBoxClave.Enabled = false;
            textBoxCP.Enabled = false;
            textBoxDomi.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxCel.Enabled = false;
            textBoxEmail.Enabled = false;

            try
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
    }
}
