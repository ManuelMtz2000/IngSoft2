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
    public partial class Form_Organigrama_Directorio_Ver : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Directorio_Ver()
        {
            InitializeComponent();
            disenioInicial();

            botonFiltrar.MouseEnter += OnMouseEnterbotonFiltrar;
            botonFiltrar.MouseLeave += OnMouseLeavebotonFiltrar;
        }

        #region Animacion del boton
        private void OnMouseEnterbotonFiltrar(object sender, EventArgs e)
        {
            botonFiltrar.Size = new Size(99,33);
            botonFiltrar.Text = "     Filtrar";
        }
        private void OnMouseLeavebotonFiltrar(object sender, EventArgs e)
        {
            botonFiltrar.Size = new Size(89,33);
            botonFiltrar.Text = "    Filtrar";
        }
        #endregion
        private void disenioInicial()
        {
            dataGridVer.Rows.Clear();

            for (int i = 0; i < dataGridVer.ColumnCount; i++)
            {
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 4 - 1;
            }

            try
            {

                MySqlCommand llenar = new MySqlCommand("SELECT * FROM directorio WHERE Fecha_Baja_D IS NULL", conexion);

                conexion.Open();

                MySqlDataReader registro = llenar.ExecuteReader();

                while (registro.Read())
                {
                    dataGridVer.Rows.Add(registro["Nombres_D"].ToString() + " " + registro["Apellido_1_D"].ToString() + " "
                                         + registro["Apellido_2_D"].ToString(),
                                         registro["Cargo_D"].ToString(),
                                         registro["Telefono_D"].ToString(),
                                         registro["Email_D"].ToString());
                }
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BotonFiltrar_Click_1(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedIndex == 0)
            {

            }
            else
            {

            }
        }

        private void PanelCentral_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridVer.ColumnCount; i++)
            {
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 4 - 1;
            }
        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            disenioInicial();
        }
    }
}
