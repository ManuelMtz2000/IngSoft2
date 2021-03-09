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
using System.Globalization;
using System.Text.RegularExpressions;

namespace interfazModernaONG
{
    public partial class Form_Servicios_Servicios_Agregar : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        int cont = 1000000000;
        public Form_Servicios_Servicios_Agregar()
        {
            InitializeComponent();
            cont = Contador();
            ocultarPaneles();

            botonAgregar.MouseEnter += OnMouseEnterbotonAgregar;
            botonAgregar.MouseLeave += OnMouseLeavebotonAgregar;
        }

        #region Animacion del boton
        private void OnMouseEnterbotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(99, 33);
            botonAgregar.Text = "   Agregar";
        }
        private void OnMouseLeavebotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(89, 33);
            botonAgregar.Text = "  Agregar";
        }
        #endregion

        private void ocultarPaneles()
        {
            panelTerapias.Visible = false;
            panelConsultas.Visible = false;
            panelOtros.Visible = false;
        }

        private int Contador()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT MAX(Folio_S) FROM servicios", conexion);
                conexion.Open();
                var res = command.ExecuteScalar();
                if (res != null)
                {
                    string aux = Convert.ToString(res);
                    command.ExecuteNonQuery();
                    conexion.Close();
                    return Convert.ToInt32(aux);
                }
                conexion.Close();
            }
            catch
            {

            }
            return 1000000000;
        }

        private bool ValidacionCampos(string tipo)
        {
            bool v = false, v1 = false, v2 = false, v3 = false, v4 = true, v5 = true, v6 = true;
            int number;
            if (textBoxNombre.TextLength > 0)
            {
                if (int.TryParse(textBoxNombre.Text, out number))
                {
                    if (Convert.ToInt32(textBoxNombre.Text) > 0)
                    {
                        v1 = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(comboBoxTipo.Text))
            {
                v2 = true;
            }
            if (dateTimeDesde.Value.Date <= DateTime.Now.Date)
            {
                v3 = true;
            }
            if (tipo == "Terapias")
            {
                if (!string.IsNullOrEmpty(comboBoxTerapias.Text))
                {
                    v4 = true;
                }
                else
                {
                    v4 = false;
                }
            }
            if (tipo == "Consulta Externa")
            {
                if (!string.IsNullOrEmpty(comboBoxConsultas.Text))
                {
                    v5 = true;
                }
                else
                {
                    v5 = false;
                }
            }
            if (tipo == "Otros")
            {
                if (textBoxEsquecifique.TextLength > 0)
                {
                    if (Regex.IsMatch(textBoxEsquecifique.Text, @"(^[a-zA-Z\s]{2,254})*"))
                    {
                        v6 = true;
                    }
                    else
                    {
                        v6 = false;
                    }
                }
                else
                {
                    v6 = false;
                }
            }
            if (v1 == true && v2 == true && v3 == true && v4 == true && v5 == true && v6 == true)// && v3 == true && v4 == true && v5 == true && v6 == true)
            {
                v = true;
            }
            return v;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            cont++;
            if (ValidacionCampos(comboBoxTipo.SelectedItem.ToString()))
            {
                try
                {
                    if (comboBoxTipo.SelectedItem.ToString() == "Terapias")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                             "servicios(Folio_S, Fecha_S, Tipo_S, Num_Beneficiarios_S, Observaciones_S,Especificar_Tipo_S) " +
                             "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@especificar)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeDesde.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBoxNombre.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxCargo.Text);
                        insert.Parameters.AddWithValue("@especificar", comboBoxTerapias.SelectedItem.ToString());
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Consulta Externa")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                             "servicios(Folio_S, Fecha_S, Tipo_S, Num_Beneficiarios_S, Observaciones_S,Especificar_Tipo_S) " +
                             "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@especificar)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeDesde.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBoxNombre.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxCargo.Text);
                        insert.Parameters.AddWithValue("@especificar", comboBoxConsultas.SelectedItem.ToString());
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Otros")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                            "servicios(Folio_S, Fecha_S, Tipo_S, Num_Beneficiarios_S, Observaciones_S,Especificar_Tipo_S) " +
                            "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@especificar)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeDesde.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBoxNombre.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxCargo.Text);
                        insert.Parameters.AddWithValue("@especificar", textBoxEsquecifique.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                              "servicios(Folio_S, Fecha_S, Tipo_S, Num_Beneficiarios_S, Observaciones_S,Especificar_Tipo_S) " +
                              "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,null)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeDesde.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToInt32(textBoxNombre.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxCargo.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }

                    textBoxCargo.Clear();
                    textBoxNombre.Clear();
                    textBoxEsquecifique.Clear();
                }
                catch
                {
                    MessageBox.Show("Error en la conexion.");
                }
            }
            else
            {
                MessageBox.Show("Uno o varios campos tienen un formato incorrecto, verifique.");
            }
        }

        private void ComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "Terapias")
            {
                ocultarPaneles();
                panelTerapias.Visible = true;
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Consulta Externa")
            {
                ocultarPaneles();
                panelConsultas.Visible = true;
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Otros")
            {
                ocultarPaneles();
                panelOtros.Visible = true;
            }
            else
            {
                ocultarPaneles();
            }
        }
    }
}
