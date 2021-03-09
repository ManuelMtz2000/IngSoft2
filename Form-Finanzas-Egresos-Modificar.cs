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
    public partial class Form_Finanzas_Egresos_Modificar : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Finanzas_Egresos_Modificar()
        {
            InitializeComponent();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonActualizar.MouseEnter += OnMouseEnterbotonActualizar;
            botonActualizar.MouseLeave += OnMouseLeavebotonActualizar;
        }

        #region Animacion de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(101, 33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(91, 33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(101, 33);
            botonActualizar.Text = "  Actualizar";
        }
        private void OnMouseLeavebotonActualizar(object sender, EventArgs e)
        {
            botonActualizar.Size = new Size(91, 33);
            botonActualizar.Text = " Actualizar";
        }
        #endregion

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

        private bool ValidarCampos()
        {
            bool v = false, v1 = false, v2 = false, v3 = false, v4 = false;
            Decimal numero;
            if (ValidacionCampoBusqueda())
            {
                v1 = true;
            }
            if (textBoxCantidad.TextLength > 0)
            {
                if (decimal.TryParse(textBoxCantidad.Text, out numero))
                {
                    if (Convert.ToDouble(textBoxCantidad.Text) > 0)
                    {
                        v2 = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(comboBoxTipo.Text))
            {
                v3 = true;
            }
            if (dateTimeIngreso.Value.Date <= DateTime.Now.Date)
            {
                v4 = true;
            }
            if (v1 == true && v2 == true && v3 == true && v4 == true)
            {
                v = true;
            }
            return v;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (ValidacionCampoBusqueda())
            {
                try
                {
                    MySqlCommand consulta = new MySqlCommand("SELECT * FROM egresos WHERE Folio_E = @folio", conexion);
                    consulta.Parameters.AddWithValue("@folio", textBoxFolio.Text);
                    conexion.Open();
                    MySqlDataReader reader = consulta.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        dateTimeIngreso.Value = Convert.ToDateTime(reader["Fecha_E"].ToString());
                        comboBoxTipo.SelectedIndex = comboBoxTipo.FindString(reader["Tipo_E"].ToString());
                        textBoxCantidad.Text = reader["Cantidad_Intervenida_E"].ToString();
                        textBoxObservaciones.Text = reader["Observaciones_E"].ToString();
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

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM egresos WHERE Folio_E = @folio", conexion);
                    command.Parameters.AddWithValue("@folio", textBoxFolio.Text);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        conexion.Close();
                        MySqlCommand modificar = new MySqlCommand("UPDATE egresos SET FECHA_E = @fecha," +
                            "TIPO_E = @tipo, CANTIDAD_INTERVENIDA_E = @cantidad, OBSERVACIONES_E = @observacion WHERE Folio_E = @folio", conexion);
                        conexion.Open();
                        modificar.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        modificar.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        modificar.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        modificar.Parameters.AddWithValue("@observacion", textBoxObservaciones.Text);
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
            else
            {
                MessageBox.Show("Error de formato.\nVerifique que esten llenos correctamente los campos necesarios.");
            }
        }
    }
}
