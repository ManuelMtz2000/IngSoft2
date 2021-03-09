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
    //1000000001
    public partial class Form_Servicios_Servicios_Eliminar : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Servicios_Servicios_Eliminar()
        {
            InitializeComponent();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonEliminar.MouseEnter += OnMouseEnterbotonEliminar;
            botonEliminar.MouseLeave += OnMouseLeavebotonEliminar;
        }

        private bool ValidacionCampoBusqueda()
        {
            bool v = false;
            int numero;
            if (textBoxFolio.TextLength > 0)
            {
                if (int.TryParse(textBoxFolio.Text, out numero))
                {
                    if (Convert.ToInt32(textBoxFolio.Text) > 1000000000)
                    {
                        v = true;
                    }
                }
            }
            return v;
        }

        #region Animacion de botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(99, 33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(89, 33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonEliminar(object sender, EventArgs e)
        {
            botonEliminar.Size = new Size(99, 33);
            botonEliminar.Text = "   Eliminar";
        }
        private void OnMouseLeavebotonEliminar(object sender, EventArgs e)
        {
            botonEliminar.Size = new Size(89, 33);
            botonEliminar.Text = "  Eliminar";
        }
        #endregion
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM servicios WHERE Folio_S = @folio", conexion);
                command.Parameters.AddWithValue("@folio", textBoxFolio.Text);
                conexion.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    conexion.Close();
                    MySqlCommand modificar = new MySqlCommand("UPDATE servicios SET Fecha_Baja_S = @fecha, Estatus_S = @status WHERE Folio_S = @folio", conexion);
                    conexion.Open();
                    modificar.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                    modificar.Parameters.AddWithValue("@status", "Inactivo");
                    modificar.Parameters.AddWithValue("@folio", textBoxFolio.Text);
                    modificar.ExecuteNonQuery();
                    MessageBox.Show("Actualizado.");
                }
                else
                {
                    MessageBox.Show("Registro Inexistente.");
                }
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error de conexion.");
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionCampoBusqueda())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM servicios WHERE Folio_S = @folio", conexion);
                    command.Parameters.AddWithValue("@folio", textBoxFolio.Text);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        dateTimeDesde.Value = Convert.ToDateTime(reader["Fecha_S"].ToString());
                        comboBoxTipo.SelectedIndex = comboBoxTipo.FindString(reader["Tipo_S"].ToString());
                        textBoxNombre.Text = reader["Num_Beneficiarios_S"].ToString();
                        textBoxCargo.Text = reader["Observaciones_S"].ToString();
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registro inexistente.");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
            else
            {
                MessageBox.Show("Campo de busqueda con formato incorrecto, deben ser números.");
            }
        }
    }
}
