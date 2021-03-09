using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interfazModernaONG
{
    public partial class Form_Servicios_Servicios_Ver : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Servicios_Servicios_Ver()
        {
            InitializeComponent();

            disenioInicial();

            botonFiltrar.MouseEnter += OnMouseEnterbotonFiltrar;
            botonFiltrar.MouseLeave += OnMouseLeavebotonFiltrar;
        }

        #region Animacion boton
        private void OnMouseEnterbotonFiltrar(object sender, EventArgs e)
        {
            botonFiltrar.Size = new Size(99, 33);
            botonFiltrar.Text = "     Filtrar";
        }
        private void OnMouseLeavebotonFiltrar(object sender, EventArgs e)
        {
            botonFiltrar.Size = new Size(89, 33);
            botonFiltrar.Text = "    Filtrar";
        }
        #endregion

        private void disenioInicial()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM servicios WHERE Fecha_Baja_S IS NULL", conexion);
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    reader.Close();
                    dataGridVer.Columns.Clear();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dataGridVer.DataSource = tabla;
                    dataGridVer.Columns[0].HeaderText = "Folio";
                    dataGridVer.Columns[1].HeaderText = "Fecha de Alta";
                    dataGridVer.Columns[2].HeaderText = "Tipo de Servicio";
                    dataGridVer.Columns[3].HeaderText = "Número de beneficiarios";
                    dataGridVer.Columns[4].HeaderText = "Observaciones";
                    dataGridVer.Columns[5].HeaderText = "Ver más información";
                    for (int i = 0; i < dataGridVer.ColumnCount; i++)
                    {
                        dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
                    }
                    for (int i = 0; i < dataGridVer.RowCount; i++)
                    {
                        dataGridVer.Rows[i].Cells[5].Value = "Ver más";
                    }
                    for (int i = 6; i <= 7; i++)
                    {
                        dataGridVer.Columns[i].Visible = false;
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridVer.ColumnCount; i++)
                    {
                        dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
                    }
                }
                conexion.Close();
            }
            catch
            {
                for (int i = 0; i < dataGridVer.ColumnCount; i++)
                {
                    dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
                    dataGridVer.Rows.Add(i, i, i, i, i);
                }
                MessageBox.Show("Error de conexion.");
            }
        }
        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrado");
        }

        private void PanelCentral_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridVer.ColumnCount; i++)
            {
                dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
            }
        }
    }
}
