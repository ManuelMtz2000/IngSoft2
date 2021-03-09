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
    public partial class Form_Finanzas_Ingresos_Ver : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");

        public Form_Finanzas_Ingresos_Ver()
        {
            InitializeComponent();

            disenioInicial();

            botonFiltrar.MouseEnter += OnMouseEnterbotonFiltrar;
            botonFiltrar.MouseLeave += OnMouseLeavebotonFiltrar;
        }
        #region Animacion de botones
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM ingresos", conexion);
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
                    dataGridVer.Columns[2].HeaderText = "Tipo de Ingreso";
                    dataGridVer.Columns[3].HeaderText = "Cantidad Recibida";
                    dataGridVer.Columns[4].HeaderText = "Observaciones";
                    dataGridVer.Columns[5].HeaderText = "Ver más información";
                    for (int i = 0; i < dataGridVer.ColumnCount; i++)
                    {
                        dataGridVer.Columns[i].Width = dataGridVer.Size.Width / 6 - 1;
                    }
                    for(int i = 0; i < dataGridVer.RowCount; i++)
                    {
                        dataGridVer.Rows[i].Cells[5].Value = "Ver más";
                    }
                    for(int i = 6; i <= 11; i++)
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
                }
                MessageBox.Show("Error de conexion.");
            }
        }
        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedItem.ToString() == "Folio")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ingresos WHERE Folio_I = " + textBoxCargo.Text, conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
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
                        dataGridVer.Columns[2].HeaderText = "Tipo de Ingreso";
                        dataGridVer.Columns[3].HeaderText = "Cantidad Recibida";
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
                        for (int i = 6; i <= 11; i++)
                        {
                            dataGridVer.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado.");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
            if(comboBoxFiltro.SelectedItem.ToString() == "Fecha de alta")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ingresos WHERE Fecha_I = @fecha", conexion);
                    command.Parameters.AddWithValue("@fecha",textBoxCargo.Text);
                    command.ExecuteNonQuery();
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
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
                        dataGridVer.Columns[2].HeaderText = "Tipo de Ingreso";
                        dataGridVer.Columns[3].HeaderText = "Cantidad Recibida";
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
                        for (int i = 6; i <= 11; i++)
                        {
                            dataGridVer.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado.");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
            if(comboBoxFiltro.SelectedItem.ToString() == "Tipo de Ingreso")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ingresos WHERE Tipo_I = @tipo", conexion);
                    conexion.Open();
                    command.Parameters.AddWithValue("@tipo",textBoxCargo.Text);
                    command.ExecuteNonQuery();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
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
                        dataGridVer.Columns[2].HeaderText = "Tipo de Ingreso";
                        dataGridVer.Columns[3].HeaderText = "Cantidad Recibida";
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
                        for (int i = 6; i <= 11; i++)
                        {
                            dataGridVer.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado.");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
            if(comboBoxFiltro.SelectedItem.ToString() == "Cantidad Recibida")
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM ingresos WHERE Cantidad_Recivida_I = @cantidad", conexion);
                    command.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(textBoxCargo.Text));
                    command.ExecuteNonQuery();
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
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
                        dataGridVer.Columns[2].HeaderText = "Tipo de Ingreso";
                        dataGridVer.Columns[3].HeaderText = "Cantidad Recibida";
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
                        for (int i = 6; i <= 11; i++)
                        {
                            dataGridVer.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro no encontrado.");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
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
