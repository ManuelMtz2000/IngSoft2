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
    public partial class Form_Beneficiarios_Beneficiarios_Ver : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Beneficiarios_Beneficiarios_Ver()
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
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 9 - 1;

            try
            {
                MySqlCommand llenar = new MySqlCommand("SELECT * FROM beneficiarios WHERE Estatus_B = 1", conexion);

                conexion.Open();

                MySqlDataReader registro = llenar.ExecuteReader();
                while (registro.Read())
                {
                    string tipo;

                    if (registro["Tipo_B"].ToString() == "0")
                        tipo = "Interno";
                    else if (registro["Tipo_B"].ToString() == "1")
                        tipo = "Recurrente";
                    else
                        tipo = "Atendido en Campo ";

                    string fechaNac = registro["Fecha_Nacimiento_B"].ToString().Substring(0,10);

                    var today = DateTime.Today;
                    var edad = today.Year - DateTime.Parse(registro["Fecha_Nacimiento_B"].ToString()).Year;
                    if (DateTime.Parse(registro["Fecha_Nacimiento_B"].ToString()).Date > today.AddYears(-edad)) edad--;


                    dataGridVer.Rows.Add(registro["Nombres_B"].ToString() +
                                         " " + registro["Apellido_1_B"].ToString() +
                                         " " + registro["Apellido_2_B"].ToString(),
                                         fechaNac,
                                         edad,
                                         registro["Sexo_B"].ToString(),
                                         tipo,
                                         registro["Nombre_Fam_Responsable_B"].ToString(),
                                         registro["Domicilio_Fam_Responsable_B"].ToString(),
                                         registro["Telefono_Fam_Responsable_B"].ToString(),
                                         "$" + registro["Cuota_Mensual_B"].ToString()
                                         );

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
            MessageBox.Show("Filtrado");
        }

        private void PanelCentral_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridVer.ColumnCount; i++)
            {
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 9 - 1;
            }
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            disenioInicial();
        }
    }
}
