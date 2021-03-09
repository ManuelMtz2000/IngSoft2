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
    public partial class Form_Organigrama_Personal_Ver : Form
    {
        // Variable que permite iniciar la conexión con la base de datos
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Organigrama_Personal_Ver()
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
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;

            try
            {
                MySqlCommand llenar = new MySqlCommand("SELECT * FROM personal WHERE Estatus_P = 1", conexion);

                conexion.Open();

                MySqlDataReader registro = llenar.ExecuteReader();

                while (registro.Read())
                {
                    string bas;
                    string even;
                    string voluntario;
                    string serv;

                    if (registro["Base_P"].ToString() == "1")
                        bas = "Si";
                    else
                        bas = "No";
                    if (registro["Eventual_P"].ToString() == "1")
                        even = "Si";
                    else
                        even = "No";
                    if (registro["Voluntario_P"].ToString() == "1")
                        voluntario = "Si";
                    else
                        voluntario = "No";
                    if (registro["Voluntario_P"].ToString() != "")
                    {
                        if (registro["Servicio_Social_P"].ToString() == "1")
                            serv = "Si";
                        else
                            serv = "No";
                    }
                    else
                    {
                        serv = registro["Servicio_Social_P"].ToString();
                    }

                    dataGridVer.Rows.Add(registro["Nombres_P"].ToString() + " " + registro["Apellido_1_P"].ToString() +
                                         " " + registro["Apellido_2_P"].ToString(),
                                         registro["Cargo_P"].ToString(),
                                         bas,
                                         even,
                                         voluntario,
                                         serv);
                }
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Falló la conexión a la Base de Datos \n Verificar conexión a internet...", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PanelCentral_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridVer.ColumnCount; i++)
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
        }
        private void BotonFiltrar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrado");
        }

        private void ButtonQuitar_Click(object sender, EventArgs e)
        {
            disenioInicial();
        }
    }
}
