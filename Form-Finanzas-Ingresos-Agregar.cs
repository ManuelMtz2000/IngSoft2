using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace interfazModernaONG
{
    public partial class Form_Finanzas_Ingresos_Agregar : Form
    {
        int cont = 1000000000;
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Finanzas_Ingresos_Agregar()
        {
            InitializeComponent();
            cont = Contador();
            //ocultar páneles
            panelIngresoOtro.Visible = false;
            panelDonativos.Visible = false;
            panelColectas.Visible = false;
            panelAportaciones.Visible = false;

            botonAgregar.MouseEnter += OnMouseEnterbotonAgregar;
            botonAgregar.MouseLeave += OnMouseLeavebotonAgregar;
        }

        private int Contador()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT MAX(Folio_I) FROM ingresos", conexion);
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
        #region Animación del botón
        private void OnMouseEnterbotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(101,33);
            botonAgregar.Text = "   Agregar";
        }
        private void OnMouseLeavebotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(91,33);
            botonAgregar.Text = "  Agregar";
        }
        #endregion

        private void ocultarPaneles()
        {
            panelIngresoOtro.Visible = false;
            panelDonativos.Visible = false;
            panelColectas.Visible = false;
            panelAportaciones.Visible = false;
        }

        private bool ValidacionCampos(string tipo)
        {
            bool v = false, v1 = false, v2 = false, v3 = false, v4 = true, v5 = true;
            decimal number;
            if(textBoxCantidad.TextLength > 0)
            {
                if(decimal.TryParse(textBoxCantidad.Text,out number))
                {
                    if(Convert.ToDouble(textBoxCantidad.Text) > 0)
                    {
                        v1 = true;
                    }
                }
            }
            if(!string.IsNullOrEmpty(comboBoxTipo.Text))
            {
                v2 = true;
            }
            if(dateTimeIngreso.Value.Date <= DateTime.Now.Date)
            {
                v3 = true;
            }
            if (tipo == "Donativos económicos" || tipo == "Donativos en especie")
            {
                if (textBoxNombreDonante.TextLength > 0)
                {
                    if (Regex.IsMatch(textBoxNombreDonante.Text, @"(^[a-zA-Z\s]{2,254})*"))
                    {
                        v4 = true;
                    }
                    else
                    {
                        v4 = false;
                    }
                }
                else
                {
                    v4 = false;
                }
            }
            if(tipo == "Aportaciones (socios)" || tipo == "Cuotas de recuperación")
            {
                if(textBoxAportador.TextLength > 0)
                {
                    if (Regex.IsMatch(textBoxNombreDonante.Text, @"(^[a-zA-Z\s]{2,254})*"))
                    {
                        v5 = true;
                    }
                    else
                    {
                        v5 = false;
                    }
                }
                else
                {
                    v5 = false;
                }
            }
            if(v1 == true && v2 == true && v3 == true && v4 == true && v5 == true)
            {
                v = true;
            }
            return v;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            cont++;
            if(ValidacionCampos(comboBoxTipo.SelectedItem.ToString()))
            {
                try
                {
                    if (comboBoxTipo.SelectedItem.ToString() == "Otros")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                        "ingresos(Folio_I, Fecha_I, Tipo_I, Cantidad_Recivida_I, Observaciones_I,Especificar_Otros_I) " +
                        "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@otros)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                        insert.Parameters.AddWithValue("@otros", textBoxEspecifique.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Aportaciones (socios)" || comboBoxTipo.SelectedItem.ToString() == "Cuotas de recuperación")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                        "ingresos(Folio_I, Fecha_I, Tipo_I, Cantidad_Recivida_I, Observaciones_I,Nombre_Aportador_I) " +
                        "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@aportaciones)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                        insert.Parameters.AddWithValue("@aportaciones", textBoxAportador.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Eventos o colectas")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                        "ingresos(Folio_I, Fecha_I, Tipo_I, Cantidad_Recivida_I, Observaciones_I,Tipo_Evento_I,Objetivo_Evento_I,Cantidad_Invertida_Evento_I) " +
                        "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@tevento,@oevento,@cevento)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                        insert.Parameters.AddWithValue("@tevento", textBoxTipoEvento.Text);
                        insert.Parameters.AddWithValue("@oevento", textBoxObjetivo.Text);
                        insert.Parameters.AddWithValue("@cevento", textBoxInversion.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Donativos económicos" || comboBoxTipo.SelectedItem.ToString() == "Donativos en especie")
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                        "ingresos(Folio_I, Fecha_I, Tipo_I, Cantidad_Recivida_I, Observaciones_I,Nombre_Donante_I,Donativo_Canalizado_I) " +
                        "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones,@donante,@canalizado)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                        insert.Parameters.AddWithValue("@donante", textBoxNombreDonante.Text);
                        insert.Parameters.AddWithValue("@canalizado", textBoxRounded1.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    else
                    {
                        MySqlCommand insert = new MySqlCommand("INSERT INTO " +
                        "ingresos(Folio_I, Fecha_I, Tipo_I, Cantidad_Recivida_I, Observaciones_I) " +
                        "VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones)", conexion);
                        conexion.Open();
                        insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                        insert.Parameters.AddWithValue("@fecha", dateTimeIngreso.Value);
                        insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                        insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                        insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                        insert.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Operación realizada.");
                    }
                    textBoxAportador.Clear();
                    textBoxCantidad.Clear();
                    textBoxEspecifique.Clear();
                    textBoxInversion.Clear();
                    textBoxNombreDonante.Clear();
                    textBoxObjetivo.Clear();
                    textBoxObservaciones.Clear();
                    textBoxRounded1.Clear();
                    textBoxTipoEvento.Clear();
                }
                catch
                {
                    MessageBox.Show("Error en la conexion.");
                }
            }
            else
            {
                MessageBox.Show("Error de formato.\nVerifique que esten llenos correctamente los campos necesarios.");
            }
        }

        private void ComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipo.SelectedItem.ToString() == "Otros")
            {
                ocultarPaneles();
                panelIngresoOtro.Visible = true;
            }
            else if(comboBoxTipo.SelectedItem.ToString() == "Donativos económicos" ||
                comboBoxTipo.SelectedItem.ToString() == "Donativos en especie")
            {
                ocultarPaneles();
                panelDonativos.Visible = true;
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Eventos o colectas")
            {
                ocultarPaneles();
                panelColectas.Visible = true;
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "Cuotas de recuperación" ||
                comboBoxTipo.SelectedItem.ToString() == "Aportaciones (socios)")
            {
                ocultarPaneles();
                panelAportaciones.Visible = true;
            }
            else
            {
                ocultarPaneles();
            }
        }

        private void dateTimeIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
