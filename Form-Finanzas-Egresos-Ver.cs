using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interfazModernaONG
{
    public partial class Form_Finanzas_Egresos_Ver : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Finanzas_Egresos_Ver()
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
            try
            {
                dataGridVer.Columns.Clear();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM egresos", conexion);
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridVer.DataSource = tabla;
                dataGridVer.Columns[0].HeaderText = "Folio";
                dataGridVer.Columns[1].HeaderText = "Fecha de Alta";
                dataGridVer.Columns[2].HeaderText = "Tipo de Egreso";
                dataGridVer.Columns[3].HeaderText = "Cantidad Invertida";
                dataGridVer.Columns[4].HeaderText = "Observaciones";
                for (int i = 0; i < 5; i++)
                {
                    dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 5 - 1;
                }
                conexion.Close();
            }
            catch
            {
                for (int i = 0; i < dataGridVer.ColumnCount; i++)
                {
                    dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 5 - 1;

                }
                MessageBox.Show("Error de conexion.");
            }
        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtardo");
        }

        private void PanelCentral_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridVer.ColumnCount; i++)
            {
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 5 - 1;
            }
        }
    }
}
